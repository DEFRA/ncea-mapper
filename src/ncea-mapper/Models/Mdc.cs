namespace ncea.mapper.Models
{
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public class Mdc_MD_Metadata: Gemini2_3_MD_Metadata
    {
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
            "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfo? nceaClassifierInfo { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
            "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiers? nceaIdentifiers { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc", IsNullable = false)]
    public partial class nceaClassifierInfo
    {
        [System.Xml.Serialization.XmlArrayItemAttribute("classifier", IsNullable = false)]
        public nceaClassifierInfoClassifier[]? NC_Classifiers { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifier
    {
        public nceaClassifierInfoClassifierClassifierType? classifierType { get; set; }
        public nceaClassifierInfoClassifierClassifierValue? classifierValue { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierType : CharacterStringBase
    {
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierValue : CharacterStringBase
    {
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc", IsNullable = false)]
    public partial class nceaIdentifiers
    {
        public nceaIdentifiersProjectID? ProjectID { get; set; }
        public nceaIdentifiersMasterReferenceID? MasterReferenceID { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectID
    {
        public nceaIdentifiersProjectIDProjectID? projectID { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectIDProjectID : CharacterStringBase
    {
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceID
    {
        public nceaIdentifiersMasterReferenceIDCatalogueEntry? catalogueEntry { get; set; }
        public nceaIdentifiersMasterReferenceIDSourceSystemReferenceID? sourceSystemReferenceID { get; set; }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDCatalogueEntry : CharacterStringBase
    {
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDSourceSystemReferenceID : CharacterStringBase
    {
    }




}