using Azure.Storage.Blobs;
using Ncea.mapper.Infrastructure.Contracts;
using Ncea.Mapper.Infrastructure.Models.Requests;
using System.Text;

namespace Ncea.Mapper.Infrastructure;

public class BlobService : IBlobService
{
    private readonly BlobServiceClient _blobServiceClient;

    public BlobService(BlobServiceClient blobServiceClient) =>
        (_blobServiceClient) = (blobServiceClient);

    public async Task<string> GetContentAsync(GetBlobContentRequest request, CancellationToken cancellationToken)
    {
        BlobContainerClient containerClient = _blobServiceClient.GetBlobContainerClient(request.Container);

        var blobClient = containerClient.GetBlobClient(request.FileName);
        var response = await blobClient.DownloadContentAsync(cancellationToken);

        var data = response.Value.Content;
        var blobContents = Encoding.UTF8.GetString(data);

        return blobContents;
    }

    public async Task<string> SaveAsync(SaveBlobRequest request, CancellationToken cancellationToken)
    {
        var blobContainer = _blobServiceClient.GetBlobContainerClient(request.Container);
        var blobClient = blobContainer.GetBlobClient(request.FileName);
        await blobClient.UploadAsync(request.Blob, true, cancellationToken);
        return blobClient.Uri.AbsoluteUri;
    }
}
