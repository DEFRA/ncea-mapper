using System.ComponentModel;
using System.Xml.Serialization;

namespace ncea.mapper.Models
{
    [XmlRoot(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Mdc_MD_Metadata: Gemini2_3_MD_Metadata
    {
        [XmlElement(ElementName = "nceaClassifierInfo", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfo? nceaClassifierInfo { get; set; }

        [XmlElement(ElementName = "nceaIdentifiers", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiers? nceaIdentifiers { get; set; }

        [XmlAttribute(AttributeName = "mdc", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/")]
        public string mdc { get; set; }
    }

    [XmlRoot(ElementName = "nceaClassifierInfo", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfo
    {
        [XmlArrayItemAttribute("classifier", IsNullable = false, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfoClassifier[]? NC_Classifiers { get; set; }
    }

    [XmlRoot(ElementName = "Classifier", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifier
    {
        [XmlElement(ElementName = "ClassifierType", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfoClassifierClassifierType? classifierType { get; set; }
        [XmlElement(ElementName = "ClassifierValue", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfoClassifierClassifierValue? classifierValue { get; set; }
    }

    [XmlRoot(ElementName = "ClassifierType", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierType : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "ClassifierValue", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierValue : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "nceaIdentifiers", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiers
    {
        [XmlElement(ElementName = "ProjectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiersProjectID? ProjectID { get; set; }
        [XmlElement(ElementName = "MasterReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiersMasterReferenceID? MasterReferenceID { get; set; }
    }

    [XmlRoot(ElementName = "ProjectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectID
    {
        [XmlElement(ElementName = "projectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiersProjectIDProjectID? projectID { get; set; }
    }

    [XmlRoot(ElementName = "projectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectIDProjectID : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "MasterReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceID
    {
        [XmlElement(ElementName = "catalogueEntry", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiersMasterReferenceIDCatalogueEntry? catalogueEntry { get; set; }
        [XmlElement(ElementName = "sourceSystemReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiersMasterReferenceIDSourceSystemReferenceID? sourceSystemReferenceID { get; set; }
    }

    [XmlRoot(ElementName = "CatalogueEntry", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDCatalogueEntry : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "sourceSystemReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDSourceSystemReferenceID : CharacterStringBase
    {
    }
}