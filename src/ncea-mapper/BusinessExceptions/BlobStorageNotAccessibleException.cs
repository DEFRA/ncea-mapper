using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper.BusinessExceptions;

[ExcludeFromCodeCoverageAttribute]
public class BlobStorageNotAccessibleException : BusinessException
{
    public BlobStorageNotAccessibleException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
