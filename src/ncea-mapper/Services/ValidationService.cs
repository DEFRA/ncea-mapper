
using Ncea.Mapper.Services.Contracts;
using System.Xml.Linq;

namespace Ncea.Mapper.Services;

public class ValidationService : IValidationService
{
    public bool IsValid(string harvestedData, string mdcMappedData)
    {
        var sourceXml = XDocument.Parse(harvestedData);
        var targetXml = XDocument.Parse(mdcMappedData);
        return (sourceXml.Descendants().Count() == targetXml.Descendants().Count());
    }
}
