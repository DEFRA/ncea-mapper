using Azure.Identity;
using Ncea.Mapper;
using Ncea.Mapper.Infrastructure;
using Azure.Messaging.ServiceBus;
using Ncea.Mapper.Infrastructure.Contracts;
using Ncea.Mapper.Models;
using Ncea.Mapper.Processors.Contracts;
using Azure.Security.KeyVault.Secrets;
using Azure.Messaging.ServiceBus.Administration;
using Ncea.Mapper.Constants;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging.ApplicationInsights;
using Microsoft.ApplicationInsights.DependencyCollector;

var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json")
                                .AddEnvironmentVariables()
                                .Build();


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddHealthChecks().AddCheck<CustomHealthCheck>("custom_hc");
builder.Services.AddHostedService<TcpHealthProbeService>();

builder.Services.Configure<MapperConfiguration>(configuration.GetSection("MapperConfigurations"));
builder.Services.AddHttpClient();

var dataSource = configuration.GetValue<string>("DataSource");
var dataSourceName = Enum.Parse(typeof(ProcessorType), dataSource!).ToString()!.ToLowerInvariant();
var processorType = (ProcessorType)Enum.Parse(typeof(ProcessorType), dataSource!);
var mapperConfigurations = configuration.GetSection("MapperConfigurations").Get<List<MapperConfiguration>>()!;

ConfigureKeyVault(configuration, builder);
ConfigureLogging(builder);
await ConfigureServiceBusQueue(configuration, builder, dataSourceName);
ConfigureServices(builder);
ConfigureProcessor(builder, mapperConfigurations, processorType);

var host = builder.Build();
host.Run();

static void ConfigureProcessor(HostApplicationBuilder builder, IList<MapperConfiguration> mapperConfigurations, ProcessorType processorType)
{
    var mapperConfiguration = mapperConfigurations.Single(x => x.ProcessorType == processorType);
    var assembly = typeof(Program).Assembly;
    var type = assembly.GetType(mapperConfiguration.Type);

    if (type != null)
    {
        builder.Services.AddSingleton(typeof(IProcessor), type);
        builder.Services.AddSingleton(typeof(MapperConfiguration), mapperConfiguration);
    }
}

static async Task ConfigureServiceBusQueue(IConfigurationRoot configuration, HostApplicationBuilder builder, string dataSourceName)
{
    var servicebusHostName = configuration.GetValue<string>("ServiceBusHostName");
    builder.Services.AddSingleton(x => new ServiceBusClient(servicebusHostName, new DefaultAzureCredential()));
    
    var createQueue = configuration.GetValue<bool>("DynamicQueueCreation");
    if (createQueue)
    {
        var mapperQueueName = $"{dataSourceName}-mapper-queue";
        await CreateServiceBusQueueIfNotExist(servicebusHostName, mapperQueueName);

        var harvesterQueueName = $"{dataSourceName}-harvester-queue";
        await CreateServiceBusQueueIfNotExist(servicebusHostName, harvesterQueueName);
    }
}

static void ConfigureKeyVault(IConfigurationRoot configuration, HostApplicationBuilder builder)
{
    var keyVaultEndpoint = new Uri(configuration.GetValue<string>("KeyVaultUri")!);
    builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());
    builder.Services.AddSingleton(x => new SecretClient(keyVaultEndpoint, new DefaultAzureCredential()));
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
    builder.Services.AddSingleton<IServiceBusService, ServiceBusService>();
    builder.Services.AddSingleton<IKeyVaultService, KeyVaultService>();
}

static async Task CreateServiceBusQueueIfNotExist(string? servicebusHostName, string queueName)
{
    var servicebusAdminClient = new ServiceBusAdministrationClient(servicebusHostName, new DefaultAzureCredential());
    bool queueExists = await servicebusAdminClient.QueueExistsAsync(queueName);
    if (!queueExists)
    {
        await servicebusAdminClient.CreateQueueAsync(queueName);
    }
}

[ExcludeFromCodeCoverage]
public static partial class Program { }