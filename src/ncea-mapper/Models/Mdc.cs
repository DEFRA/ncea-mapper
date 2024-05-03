using System.ComponentModel;
using System.Xml.Serialization;

namespace ncea.mapper.Models
{
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlRootAttribute(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public class Mdc_MD_Metadata: Gemini2_3_MD_Metadata
    {
        [XmlElementAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfo? nceaClassifierInfo { get; set; }

        [XmlElementAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiers? nceaIdentifiers { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    [XmlRootAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc", IsNullable = false)]
    public partial class nceaClassifierInfo
    {
        [XmlArrayItemAttribute("classifier", IsNullable = false)]
        public nceaClassifierInfoClassifier[]? NC_Classifiers { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifier
    {
        public nceaClassifierInfoClassifierClassifierType? classifierType { get; set; }
        public nceaClassifierInfoClassifierClassifierValue? classifierValue { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierType : CharacterStringBase
    {
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierValue : CharacterStringBase
    {
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    [XmlRootAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc", IsNullable = false)]
    public partial class nceaIdentifiers
    {
        public nceaIdentifiersProjectID? ProjectID { get; set; }
        public nceaIdentifiersMasterReferenceID? MasterReferenceID { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectID
    {
        public nceaIdentifiersProjectIDProjectID? projectID { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectIDProjectID : CharacterStringBase
    {
    }
        
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceID
    {
        public nceaIdentifiersMasterReferenceIDCatalogueEntry? catalogueEntry { get; set; }
        public nceaIdentifiersMasterReferenceIDSourceSystemReferenceID? sourceSystemReferenceID { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDCatalogueEntry : CharacterStringBase
    {
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDSourceSystemReferenceID : CharacterStringBase
    {
    }
}