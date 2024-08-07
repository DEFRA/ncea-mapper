﻿//<auto-generated/>
using System.Xml.Serialization;

namespace Ncea.Mapper.Models
{
    [XmlRoot(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MdcMdMetadata: Gemini23MdMetadata
    {
        [XmlElement(ElementName = "NceaClassifierInfo", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaClassifierInfo nceaClassifierInfo { get; set; }

        [XmlElement(ElementName = "NceaIdentifiers", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaIdentifiers nceaIdentifiers { get; set; }

        [XmlAttribute(AttributeName = "mdc", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public string mdc { get; set; }
    }

    [XmlRoot(ElementName = "NceaClassifierInfo", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaClassifierInfo
    {
        [XmlArrayItemAttribute("Classifier", IsNullable = false, Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaClassifierInfoClassifier[] NC_Classifiers { get; set; }
    }

    [XmlRoot(ElementName = "Classifier", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaClassifierInfoClassifier
    {
        [XmlElement(ElementName = "Name", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaClassifierInfoClassifierName name { get; set; }
        [XmlElement(ElementName = "Code", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaClassifierInfoClassifierCode code { get; set; }
    }

    [XmlRoot(ElementName = "Name", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaClassifierInfoClassifierName : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "Code", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaClassifierInfoClassifierCode : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "NceaIdentifiers", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaIdentifiers
    {
        [XmlElement(ElementName = "ProjectID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaIdentifiersProjectId ProjectID { get; set; }
        [XmlElement(ElementName = "MasterReferenceID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaIdentifiersMasterReferenceId MasterReferenceID { get; set; }
    }

    [XmlRoot(ElementName = "ProjectID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaIdentifiersProjectId
    {
        [XmlElement(ElementName = "projectID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaIdentifiersProjectIdProjectId projectID { get; set; }
    }

    [XmlRoot(ElementName = "projectID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaIdentifiersProjectIdProjectId : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "MasterReferenceID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaIdentifiersMasterReferenceId
    {
        [XmlElement(ElementName = "CatalogueEntry", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaIdentifiersMasterReferenceIdCatalogueEntry catalogueEntry { get; set; }
        [XmlElement(ElementName = "SourceSystemReferenceID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
        public NceaIdentifiersMasterReferenceIdSourceSystemReferenceId sourceSystemReferenceID { get; set; }
    }

    [XmlRoot(ElementName = "CatalogueEntry", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaIdentifiersMasterReferenceIdCatalogueEntry : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "SourceSystemReferenceID", Namespace = "https://ncea-search.azure.defra.cloud/mdc")]
    public partial class NceaIdentifiersMasterReferenceIdSourceSystemReferenceId : CharacterStringBase
    {
    }
}