using System.ComponentModel;
using System.Xml.Serialization;

namespace ncea.mapper.Models
{
    public class CharacterStringBase
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string? CharacterString { get; set; }
    }

    [DesignerCategory("code"), Serializable, XmlType(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
}