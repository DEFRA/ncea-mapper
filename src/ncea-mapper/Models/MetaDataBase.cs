using System.Xml.Serialization;

namespace Ncea.Mapper.Models
{
    public class CharacterStringBase
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string? CharacterString { get; set; }
    }
}