namespace ncea.mapper.Models
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public class Mdc_MD_Metadata: Gemini2_3_MD_Metadata
    {
        private nceaClassifierInfo nceaClassifierInfoField;

        private nceaIdentifiers nceaIdentifiersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
            "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaClassifierInfo nceaClassifierInfo
        {
            get
            {
                return this.nceaClassifierInfoField;
            }
            set
            {
                this.nceaClassifierInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
            "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
        public nceaIdentifiers nceaIdentifiers
        {
            get
            {
                return this.nceaIdentifiersField;
            }
            set
            {
                this.nceaIdentifiersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc", IsNullable = false)]
    public partial class nceaClassifierInfo
    {

        private nceaClassifierInfoClassifier[] nC_ClassifiersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("classifier", IsNullable = false)]
        public nceaClassifierInfoClassifier[] NC_Classifiers
        {
            get
            {
                return this.nC_ClassifiersField;
            }
            set
            {
                this.nC_ClassifiersField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifier
    {

        private nceaClassifierInfoClassifierClassifierType classifierTypeField;

        private nceaClassifierInfoClassifierClassifierValue classifierValueField;

        /// <remarks/>
        public nceaClassifierInfoClassifierClassifierType classifierType
        {
            get
            {
                return this.classifierTypeField;
            }
            set
            {
                this.classifierTypeField = value;
            }
        }

        /// <remarks/>
        public nceaClassifierInfoClassifierClassifierValue classifierValue
        {
            get
            {
                return this.classifierValueField;
            }
            set
            {
                this.classifierValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierType
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaClassifierInfoClassifierClassifierValue
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc", IsNullable = false)]
    public partial class nceaIdentifiers
    {

        private nceaIdentifiersProjectID projectIDField;

        private nceaIdentifiersMasterReferenceID masterReferenceIDField;

        /// <remarks/>
        public nceaIdentifiersProjectID ProjectID
        {
            get
            {
                return this.projectIDField;
            }
            set
            {
                this.projectIDField = value;
            }
        }

        /// <remarks/>
        public nceaIdentifiersMasterReferenceID MasterReferenceID
        {
            get
            {
                return this.masterReferenceIDField;
            }
            set
            {
                this.masterReferenceIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectID
    {

        private nceaIdentifiersProjectIDProjectID projectIDField;

        /// <remarks/>
        public nceaIdentifiersProjectIDProjectID projectID
        {
            get
            {
                return this.projectIDField;
            }
            set
            {
                this.projectIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersProjectIDProjectID
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceID
    {

        private nceaIdentifiersMasterReferenceIDCatalogueEntry catalogueEntryField;

        private nceaIdentifiersMasterReferenceIDSourceSystemReferenceID sourceSystemReferenceIDField;

        /// <remarks/>
        public nceaIdentifiersMasterReferenceIDCatalogueEntry catalogueEntry
        {
            get
            {
                return this.catalogueEntryField;
            }
            set
            {
                this.catalogueEntryField = value;
            }
        }

        /// <remarks/>
        public nceaIdentifiersMasterReferenceIDSourceSystemReferenceID sourceSystemReferenceID
        {
            get
            {
                return this.sourceSystemReferenceIDField;
            }
            set
            {
                this.sourceSystemReferenceIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDCatalogueEntry
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://github.com/DEFRA/ncea-geonetwork/tree/main/core-geonetwork/schemas/iso191" +
        "39.mdc/src/main/plugin/iso19139.mdc/schema/mdc")]
    public partial class nceaIdentifiersMasterReferenceIDSourceSystemReferenceID
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString
        {
            get
            {
                return this.characterStringField;
            }
            set
            {
                this.characterStringField = value;
            }
        }
    }




}