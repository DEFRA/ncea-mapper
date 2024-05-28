using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper.BusinessExceptions
{
    [ExcludeFromCodeCoverageAttribute]
    public class MapperException : BusinessException
    {
        public MapperException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
