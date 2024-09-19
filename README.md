# Welcome to the NCEA Mapper ETL Service Repository

This is the code repository for the NCEA Metadata Mapper ETL Service codebase.

## Process Flow

- Receive message from **harvested-queue**
- If the MessageType is **Start** or **End** resend the message to **mapped-queue**
- If the MessageType is **Metadata**, read metadata file content from Azure Blob Storage (which saved by Harvester service) based File Identifier
- Transform the metadata xml content into MDC xml format
- Save the MDC formated xml file into mapper staging container in Azure Blob Storage ( *jncc-mapper-staging | medin-mapper-staging* )
- Send message to the **mapped-queue** with the following details,
    - FileIdentifier
    - DataSource ( *Medin | Jncc* )
    - MessageType ( *Start | Metadata | End* )

# Prerequisites

Before proceeding, ensure you have the following installed:

- .NET 8 SDK: You can download and install it from [dotnet.microsoft.com](https://dotnet.microsoft.com/download/dotnet/8.0).

# Configurations

## Azure Dependencies
   
***ServiceBus Configurations:***
    *ServiceBusHostName* to connect to ServiceBus, to send messages in servicebus queues and to dynamically create queues, if the *DynamicQueueCreation* is set to *True*   

    "ServiceBusHostName": "[Azure ServiceBus Namespace].servicebus.windows.net"
    "HarvesterQueueName": "harvested-queue"
    "MapperQueueName": "mapped-queue",
    "DynamicQueueCreation": true,

***KeyVault Configurations:***
    *KeyVaultUri* to access Azure KeyVault and to access secrets and connection strings.   

    "KeyVaultUri": "https://[Azure KeyVault Name].vault.azure.net/"

***BlobStorage Configuration:***
    *BlobStorageUri* to connect to Azure Blob Storage, to create containers per DataSource and to Save the XML files for the respective data source.
       
    "BlobStorageUri": "https://devnceinfst1401.blob.core.windows.net"

***ApplicationInsights Configuration:***
    *ApplicationInsights* to enable logging and monitoring.   

    "ApplicationInsights": {
        "LogLevel": {
        "Default": "Trace",
        "System": "Trace",
        "Microsoft": "Trace",
        "Microsoft.Hosting.Lifetime": "Information",
        "System.Net.Http.HttpClient": "Trace"
        }
    }
    "Logging": {
    "LogLevel": {
      "Default": "Trace",
      "System": "Trace",
      "Microsoft": "Trace",
      "Microsoft.Hosting.Lifetime": "Information",
      "System.Net.Http.HttpClient": "Trace"
     }
    }

## Helm Chart Variables

The variables on helm Chart value file (*ncea-mapper\values\values.yaml*) will be replaced during Helm Deploy with environment specific values

| Variable name               | Variable Group            | Notes                                                               |
| ----------------------------|---------------------------|---------------------------------------------------------------------|
| containerRepositoryFullPath | mapperServiceVariables    |                                                                     |
| imageTag                    |                           |  imageTag value is calculated dynamically variables-global.yml file |
| serviceAccountMapper        | mapperServiceVariables    |                                                                     |
| serviceBusHostName          | azureVariables            |                                                                     |
| keyVaultUri                 | azureVariables            |                                                                     |
| blobStorageUri              | azureVariables            |                                                                     |
| autoScalingEnabled          | mapperServiceVariables    |                                                                     |
| autoScalingReplicas         | mapperServiceVariables    |                                                                     | 

## Pipeline Configurations

### Pipeline Setup

- azure-pipelines.yaml

- ***Stage : Build***
    - steps-build-and-test.yaml
        - task: UseDotNet@2 | version: '8.x'
        - task: DotNetCoreCLI@2 | command: 'restore'
        - task: DotNetCoreCLI@2 | command: 'build'
        - task: DotNetCoreCLI@2 | command: 'dotnet test'
        - task: PublishCodeCoverageResults@1 | codeCoverageTool: 'Cobertura'
        - task: SonarCloudAnalyze@1
        - task: SonarCloudPublish@1
        
    - steps-build-and-push-docker-images.yaml
        - task: AzureCLI@2 | To build and push docker images to DEV ACR
        
    - steps-package-and-push-helm-charts.yaml
        - task: HelmDeploy@0 | command: package
        - task: PublishPipelineArtifact@1 | Saves the Helm Chart as Pipeline Artifact

- ***Stage : dev***
    - steps-deploy-helm-charts.yaml
        - task: DownloadPipelineArtifact@2 | Downloads Helm Chart
        - task: ExtractFiles@1 | Extracts files from Helm Chart
        - task: HelmDeploy@0 | command: 'upgrade'

- ***Stage : tst***
    - steps-deploy-helm-charts.yaml
        - task: DownloadPipelineArtifact@2 | Downloads Helm Chart
        - task: ExtractFiles@1 | Extracts files from Helm Chart
        - task: HelmDeploy@0 | command: 'upgrade' 

- ***Stage : pre***
    - steps-import-docker-images.yaml
        - task: AzureCLI@2 | Import Docker Image from Dev ACR to Pre ACR
    
    - steps-deploy-helm-charts.yaml
        - task: DownloadPipelineArtifact@2 | Downloads Helm Chart
        - task: ExtractFiles@1 | Extracts files from Helm Chart
        - task: HelmDeploy@0 | command: 'upgrade' 
    
### Service Connections
- **dev**: AZR-NCE-DEV1
- **tst**: AZR-NCE-TST
- **pre**: AZR-NCE-PRE

### Build / Deployment Agents
- **dev** | **tst** : DEFRA-COMMON-ubuntu2204-SSV3
- **pre**           : DEFRA-COMMON-ubuntu2204-SSV5

### Variable Groups

***pipelineVariables***

    - acrConatinerRegistry
    - acrContainerRegistryPre
    - acrContainerRegistryPreShort
    - acrContainerRegistryDevResourceId
    - acrContainerRepositoryMapper
    - acrName
    - acrUser
    - acrResourceGroupName
    - azureSubscriptionDev
    - azureSubscriptionTest
    - azureSubscriptionPre
    - sonarCloudOrganization
    - sonarProjectKeyMapper
    - sonarProjectNameMapper

***azureVariables-[dev/test/sandbox/...]***

    - aksNamespace
    - aksResourceGroupName
    - acrResourceGroupName
    - aksClusterName    
    - keyVaultUri
    - serviceBusHostName
    - blobStorageUri
    - fileShareClientUri
    - storageAccountName
    - storageAccountResourceGroup
    - storageAccountFilePrivateEndpointFqdn 

***MapperServiceVariables-[dev/test/sandbox/...]***

    - autoScalingEnabled
    - autoScalingReplicas
    - containerRepostitoryFullPath
    - serviceAccountMapper