using Azure.Identity;
using Ncea.Mapper;
using Ncea.Mapper.Infrastructure;
using Azure.Messaging.ServiceBus;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Processors.Contracts;
using Azure.Security.KeyVault.Secrets;
using Azure.Messaging.ServiceBus.Administration;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging.ApplicationInsights;
using Microsoft.ApplicationInsights.DependencyCollector;
using Microsoft.Extensions.Azure;
using Ncea.Mapper.Processor;
using Ncea.Mapper.Processor.Contracts;
using Ncea.Mapper.Processors;
using Azure.Extensions.AspNetCore.Configuration.Secrets;
using Ncea.Mapper.AutoMapper;
using Azure.Storage.Blobs;
using Ncea.Mapper.Enums;
using Ncea.mapper.Infrastructure.Contracts;

var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .AddEnvironmentVariables()
                                .Build();

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddHealthChecks().AddCheck<HealthCheck>("custom_hc");
builder.Services.AddHostedService<TcpHealthProbeService>();

builder.Services.AddHttpClient();
// Add AutoMapper with a custom mapping profile
builder.Services.AddAutoMapper(typeof(MappingProfile));

ConfigureKeyVault(configuration, builder);
ConfigureLogging(builder);
await ConfigureStorage(configuration, builder);
await ConfigureServiceBusQueue(configuration, builder);
ConfigureServices(builder);

var host = builder.Build();
await host.RunAsync();

static async Task ConfigureServiceBusQueue(IConfigurationRoot configuration, HostApplicationBuilder builder)
{
    var harvesterQueueName = configuration.GetValue<string>("HarvesterQueueName");
    var mapperQueueName = configuration.GetValue<string>("MapperQueueName");

    var servicebusHostName = configuration.GetValue<string>("ServiceBusHostName");

    var createQueue = configuration.GetValue<bool>("DynamicQueueCreation");
    if (createQueue)
    {
        var servicebusAdminClient = new ServiceBusAdministrationClient(servicebusHostName, new DefaultAzureCredential());
        await CreateServiceBusQueueIfNotExist(servicebusAdminClient, harvesterQueueName!);
        await CreateServiceBusQueueIfNotExist(servicebusAdminClient, mapperQueueName!);        
    }

    builder.Services.AddAzureClients(builder =>
    {
        builder.AddServiceBusClientWithNamespace(servicebusHostName);
        builder.UseCredential(new DefaultAzureCredential());

        builder.AddClient<ServiceBusSender, ServiceBusClientOptions>(
            (_, _, provider) => provider.GetService<ServiceBusClient>()!.CreateSender(mapperQueueName))
            .WithName(mapperQueueName);

        builder.AddClient<ServiceBusProcessor, ServiceBusClientOptions>(
            (_, _, provider) => provider.GetService<ServiceBusClient>()!.CreateProcessor(harvesterQueueName))
            .WithName(harvesterQueueName);
    });
}

static void ConfigureKeyVault(IConfigurationRoot configuration, HostApplicationBuilder builder)
{
    var keyVaultEndpoint = new Uri(configuration.GetValue<string>("KeyVaultUri")!);
    var secretClient = new SecretClient(keyVaultEndpoint, new DefaultAzureCredential());
    builder.Configuration.AddAzureKeyVault(secretClient, new KeyVaultSecretManager());
    builder.Services.AddSingleton(secretClient);
}

static void ConfigureLogging(HostApplicationBuilder builder)
{
    builder.Services.AddLogging(loggingBuilder =>
    {
        loggingBuilder.ClearProviders();
        loggingBuilder.AddApplicationInsights(
            configureTelemetryConfiguration: (config) =>
                config.ConnectionString = builder.Configuration.GetValue<string>("ApplicationInsights:ConnectionString"),
                configureApplicationInsightsLoggerOptions: (options) => { }
            );
        loggingBuilder.AddConsole();
        loggingBuilder.AddFilter<ApplicationInsightsLoggerProvider>(null, LogLevel.Information);

    });
    builder.Services.AddApplicationInsightsTelemetryWorkerService();
    builder.Services.ConfigureTelemetryModule<DependencyTrackingTelemetryModule>((module, o) =>
    {
        module.EnableSqlCommandTextInstrumentation = true;
        o.ConnectionString = builder.Configuration.GetValue<string>("ApplicationInsights:ConnectionString");
    });
}

static void ConfigureServices(HostApplicationBuilder builder)
{
    builder.Services.AddSingleton<IApiClient, ApiClient>();
    builder.Services.AddSingleton<IOrchestrationService, OrchestrationService>();
    builder.Services.AddSingleton<IKeyVaultService, KeyVaultService>();
    builder.Services.AddSingleton<IBlobService, BlobService>();
    builder.Services.AddKeyedSingleton<IMapperService, JnccMapper>("Jncc");
    builder.Services.AddKeyedSingleton<IMapperService, MedinMapper>("Medin");
}

static async Task ConfigureStorage(IConfigurationRoot configuration, HostApplicationBuilder builder)
{
    var blobStorageEndpoint = new Uri(configuration.GetValue<string>("BlobStorageUri")!);
    var mapperStagingContainerSuffix = configuration.GetValue<string>("MapperStagingContainerSuffix");
    var blobServiceClient = new BlobServiceClient(blobStorageEndpoint, new DefaultAzureCredential());

    builder.Services.AddSingleton(x => blobServiceClient);

    foreach (string dataSourceName in Enum.GetNames(typeof(DataSource)))
    {
        var containerName = $"{dataSourceName.ToLowerInvariant()}-{mapperStagingContainerSuffix}";
        var container = blobServiceClient.GetBlobContainerClient(containerName);
        await container.CreateIfNotExistsAsync();
    }
}

static async Task CreateServiceBusQueueIfNotExist(ServiceBusAdministrationClient servicebusAdminClient, string queueName)
{    
    bool queueExists = await servicebusAdminClient.QueueExistsAsync(queueName);
    if (!queueExists)
    {
        await servicebusAdminClient.CreateQueueAsync(queueName);
    }
}

[ExcludeFromCodeCoverage]
public static partial class Program { }