
using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper.BusinessExceptions;

[ExcludeFromCodeCoverageAttribute]
public class MapperArgumentException : BusinessException
{
    public MapperArgumentException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
