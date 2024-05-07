﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace ncea.mapper.Models
{
    [XmlRoot(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MdcMdMetadata: Gemini23MdMetadata
    {
        [XmlElement(ElementName = "nceaClassifierInfo", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaClassifierInfo? nceaClassifierInfo { get; set; }

        [XmlElement(ElementName = "nceaIdentifiers", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaIdentifiers? nceaIdentifiers { get; set; }

        [XmlAttribute(AttributeName = "mdc", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/")]
        public string? mdc { get; set; }
    }

    [XmlRoot(ElementName = "nceaClassifierInfo", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaClassifierInfo
    {
        [XmlArrayItemAttribute("classifier", IsNullable = false, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaClassifierInfoClassifier[]? NC_Classifiers { get; set; }
    }

    [XmlRoot(ElementName = "Classifier", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaClassifierInfoClassifier
    {
        [XmlElement(ElementName = "ClassifierType", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaClassifierInfoClassifierClassifierType? classifierType { get; set; }
        [XmlElement(ElementName = "ClassifierValue", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaClassifierInfoClassifierClassifierValue? classifierValue { get; set; }
    }

    [XmlRoot(ElementName = "ClassifierType", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaClassifierInfoClassifierClassifierType : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "ClassifierValue", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaClassifierInfoClassifierClassifierValue : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "nceaIdentifiers", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaIdentifiers
    {
        [XmlElement(ElementName = "ProjectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaIdentifiersProjectId? ProjectID { get; set; }
        [XmlElement(ElementName = "MasterReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaIdentifiersMasterReferenceID? MasterReferenceID { get; set; }
    }

    [XmlRoot(ElementName = "ProjectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaIdentifiersProjectId
    {
        [XmlElement(ElementName = "projectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaIdentifiersProjectIdProjectId? projectID { get; set; }
    }

    [XmlRoot(ElementName = "projectID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaIdentifiersProjectIdProjectId : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "MasterReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaIdentifiersMasterReferenceID
    {
        [XmlElement(ElementName = "catalogueEntry", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaIdentifiersMasterReferenceIDCatalogueEntry? catalogueEntry { get; set; }
        [XmlElement(ElementName = "sourceSystemReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public NceaIdentifiersMasterReferenceIdSourceSystemReferenceId? sourceSystemReferenceID { get; set; }
    }

    [XmlRoot(ElementName = "CatalogueEntry", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaIdentifiersMasterReferenceIDCatalogueEntry : CharacterStringBase
    {
    }

    [XmlRoot(ElementName = "sourceSystemReferenceID", Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso19139.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class NceaIdentifiersMasterReferenceIdSourceSystemReferenceId : CharacterStringBase
    {
    }
}