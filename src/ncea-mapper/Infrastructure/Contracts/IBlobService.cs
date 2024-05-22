using Ncea.Mapper.Infrastructure.Models.Requests;

namespace Ncea.mapper.Infrastructure.Contracts
{
    public interface IBlobService
    {
        Task<string> SaveAsync(SaveBlobRequest request, CancellationToken cancellationToken);
        Task<string> GetContentAsync(GetBlobContentRequest request, CancellationToken cancellationToken);
    }
}
