using System.Diagnostics.CodeAnalysis;

namespace Ncea.Mapper.BusinessExceptions;

[ExcludeFromCodeCoverageAttribute]
public class XmlValidationException : BusinessException
{
    public XmlValidationException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
