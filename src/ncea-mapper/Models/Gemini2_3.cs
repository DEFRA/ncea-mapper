
namespace ncea.mapper.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public partial class Gemini2_3_MD_Metadata
    {

        private MD_MetadataFileIdentifier fileIdentifierField;

        private MD_MetadataLanguage languageField;

        private MD_MetadataCharacterSet characterSetField;

        private MD_MetadataContact contactField;

        private MD_MetadataDateStamp dateStampField;

        private MD_MetadataMetadataStandardName metadataStandardNameField;

        private MD_MetadataMetadataStandardVersion metadataStandardVersionField;

        private MD_MetadataSpatialRepresentationInfo spatialRepresentationInfoField;

        private MD_MetadataReferenceSystemInfo referenceSystemInfoField;

        private MD_MetadataIdentificationInfo identificationInfoField;

        private MD_MetadataDistributionInfo distributionInfoField;

        private MD_MetadataDataQualityInfo dataQualityInfoField;

        /// <remarks/>
        public MD_MetadataFileIdentifier fileIdentifier { get; set; }

        /// <remarks/>
        public MD_MetadataLanguage language { get; set; }

        /// <remarks/>
        public MD_MetadataCharacterSet characterSet { get; set; }

        /// <remarks/>
        public MD_MetadataContact contact { get; set; }

        /// <remarks/>
        public MD_MetadataDateStamp dateStamp { get; set; }

        /// <remarks/>
        public MD_MetadataMetadataStandardName metadataStandardName { get; set; }

        /// <remarks/>
        public MD_MetadataMetadataStandardVersion metadataStandardVersion { get; set; }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfo spatialRepresentationInfo { get; set; }

        /// <remarks/>
        public MD_MetadataReferenceSystemInfo referenceSystemInfo { get; set; }

        /// <remarks/>
        public MD_MetadataIdentificationInfo identificationInfo { get; set; }

        /// <remarks/>
        public MD_MetadataDistributionInfo distributionInfo { get; set; }

        /// <remarks/>
        public MD_MetadataDataQualityInfo dataQualityInfo { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataFileIdentifier
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataLanguage
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataCharacterSet
    {

        private MD_MetadataCharacterSetMD_CharacterSetCode mD_CharacterSetCodeField;

        /// <remarks/>
        public MD_MetadataCharacterSetMD_CharacterSetCode MD_CharacterSetCode { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataCharacterSetMD_CharacterSetCode
    {

        private string codeListValueField;

        private string codeListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContact
    {

        private MD_MetadataContactCI_ResponsibleParty cI_ResponsiblePartyField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsibleParty CI_ResponsibleParty { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsibleParty
    {

        private MD_MetadataContactCI_ResponsiblePartyIndividualName individualNameField;

        private MD_MetadataContactCI_ResponsiblePartyOrganisationName organisationNameField;

        private MD_MetadataContactCI_ResponsiblePartyPositionName positionNameField;

        private MD_MetadataContactCI_ResponsiblePartyRole roleField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyIndividualName individualName { get; set; }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyOrganisationName organisationName { get; set; }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyPositionName positionName { get; set; }

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyRole role { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyIndividualName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyOrganisationName
    {

        private string characterStringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyPositionName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyRole
    {

        private MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode cI_RoleCodeField;

        /// <remarks/>
        public MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode CI_RoleCode
        {
            get
            {
                return this.cI_RoleCodeField;
            }
            set
            {
                this.cI_RoleCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDateStamp
    {

        private System.DateTime dateTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public System.DateTime DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataStandardName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataStandardVersion
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfo
    {

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentation mD_VectorSpatialRepresentationField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentation MD_VectorSpatialRepresentation
        {
            get
            {
                return this.mD_VectorSpatialRepresentationField;
            }
            set
            {
                this.mD_VectorSpatialRepresentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentation
    {

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevel topologyLevelField;

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjects geometricObjectsField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevel topologyLevel
        {
            get
            {
                return this.topologyLevelField;
            }
            set
            {
                this.topologyLevelField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjects geometricObjects
        {
            get
            {
                return this.geometricObjectsField;
            }
            set
            {
                this.geometricObjectsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevel
    {

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevelMD_TopologyLevelCode mD_TopologyLevelCodeField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevelMD_TopologyLevelCode MD_TopologyLevelCode
        {
            get
            {
                return this.mD_TopologyLevelCodeField;
            }
            set
            {
                this.mD_TopologyLevelCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevelMD_TopologyLevelCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjects
    {

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjects mD_GeometricObjectsField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjects MD_GeometricObjects
        {
            get
            {
                return this.mD_GeometricObjectsField;
            }
            set
            {
                this.mD_GeometricObjectsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjects
    {

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectType geometricObjectTypeField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectType geometricObjectType
        {
            get
            {
                return this.geometricObjectTypeField;
            }
            set
            {
                this.geometricObjectTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectType
    {

        private MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectTypeMD_GeometricObjectTypeCode mD_GeometricObjectTypeCodeField;

        /// <remarks/>
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectTypeMD_GeometricObjectTypeCode MD_GeometricObjectTypeCode
        {
            get
            {
                return this.mD_GeometricObjectTypeCodeField;
            }
            set
            {
                this.mD_GeometricObjectTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectTypeMD_GeometricObjectTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfo
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystem mD_ReferenceSystemField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystem MD_ReferenceSystem
        {
            get
            {
                return this.mD_ReferenceSystemField;
            }
            set
            {
                this.mD_ReferenceSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystem
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier referenceSystemIdentifierField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier referenceSystemIdentifier
        {
            get
            {
                return this.referenceSystemIdentifierField;
            }
            set
            {
                this.referenceSystemIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier rS_IdentifierField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier RS_Identifier
        {
            get
            {
                return this.rS_IdentifierField;
            }
            set
            {
                this.rS_IdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier
    {

        private MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode codeField;

        /// <remarks/>
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfo
    {
        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentification? MD_DataIdentification
        {
            get; set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/srv")]
        public SV_ServiceIdentification? SV_ServiceIdentification
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/srv")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
    public partial class SV_ServiceIdentification
    {
        /// <remarks/>
        public SV_ServiceIdentificationServiceType serviceType
        {
            get; set;
        }

        /// <remarks/>
        public SV_ServiceIdentificationOperatesOn operatesOn
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/srv")]
    public partial class SV_ServiceIdentificationServiceType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string LocalName
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/srv")]
    public partial class SV_ServiceIdentificationOperatesOn
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string href
        {
            get; set;
        }
    }


    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentification
    {
        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitation citation
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationAbstract @abstract
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPurpose purpose
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationStatus status
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContact pointOfContact
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenance resourceMaintenance
        {
            get; set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("graphicOverview")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverview[] graphicOverview
        {
            get; set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("descriptiveKeywords")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords[] descriptiveKeywords
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints resourceConstraints
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType spatialRepresentationType
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolution spatialResolution
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationLanguage language
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet characterSet
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory topicCategory
        {
            get; set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("extent")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtent[] extent
        {
            get; set;
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSupplementalInformation supplementalInformation
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitation
    {
        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation CI_Citation
        {
            get; set;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle titleField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate dateField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition editionField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm presentationFormField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition edition
        {
            get
            {
                return this.editionField;
            }
            set
            {
                this.editionField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm presentationForm
        {
            get
            {
                return this.presentationFormField;
            }
            set
            {
                this.presentationFormField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date cI_DateField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date CI_Date
        {
            get
            {
                return this.cI_DateField;
            }
            set
            {
                this.cI_DateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate dateField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType dateTypeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType dateType
        {
            get
            {
                return this.dateTypeField;
            }
            set
            {
                this.dateTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate
    {

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco", DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode cI_DateTypeCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode CI_DateTypeCode
        {
            get
            {
                return this.cI_DateTypeCodeField;
            }
            set
            {
                this.cI_DateTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode cI_PresentationFormCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode CI_PresentationFormCode
        {
            get
            {
                return this.cI_PresentationFormCodeField;
            }
            set
            {
                this.cI_PresentationFormCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationAbstract
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPurpose
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationStatus
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationStatusMD_ProgressCode mD_ProgressCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationStatusMD_ProgressCode MD_ProgressCode
        {
            get
            {
                return this.mD_ProgressCodeField;
            }
            set
            {
                this.mD_ProgressCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationStatusMD_ProgressCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContact
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsibleParty cI_ResponsiblePartyField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsibleParty CI_ResponsibleParty
        {
            get
            {
                return this.cI_ResponsiblePartyField;
            }
            set
            {
                this.cI_ResponsiblePartyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsibleParty
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyIndividualName individualNameField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyOrganisationName organisationNameField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyPositionName positionNameField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfo contactInfoField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRole roleField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyIndividualName individualName
        {
            get
            {
                return this.individualNameField;
            }
            set
            {
                this.individualNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyOrganisationName organisationName
        {
            get
            {
                return this.organisationNameField;
            }
            set
            {
                this.organisationNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyPositionName positionName
        {
            get
            {
                return this.positionNameField;
            }
            set
            {
                this.positionNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfo contactInfo
        {
            get
            {
                return this.contactInfoField;
            }
            set
            {
                this.contactInfoField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRole role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyIndividualName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyOrganisationName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyPositionName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfo
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_Contact cI_ContactField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_Contact CI_Contact
        {
            get
            {
                return this.cI_ContactField;
            }
            set
            {
                this.cI_ContactField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_Contact
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddress addressField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddress address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddress
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address cI_AddressField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address CI_Address
        {
            get
            {
                return this.cI_AddressField;
            }
            set
            {
                this.cI_AddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint deliveryPointField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity cityField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea administrativeAreaField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode postalCodeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry countryField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress electronicMailAddressField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint deliveryPoint
        {
            get
            {
                return this.deliveryPointField;
            }
            set
            {
                this.deliveryPointField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea administrativeArea
        {
            get
            {
                return this.administrativeAreaField;
            }
            set
            {
                this.administrativeAreaField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress electronicMailAddress
        {
            get
            {
                return this.electronicMailAddressField;
            }
            set
            {
                this.electronicMailAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRole
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRoleCI_RoleCode cI_RoleCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRoleCI_RoleCode CI_RoleCode
        {
            get
            {
                return this.cI_RoleCodeField;
            }
            set
            {
                this.cI_RoleCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRoleCI_RoleCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenance
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformation mD_MaintenanceInformationField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformation MD_MaintenanceInformation
        {
            get
            {
                return this.mD_MaintenanceInformationField;
            }
            set
            {
                this.mD_MaintenanceInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformation
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequency maintenanceAndUpdateFrequencyField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequency maintenanceAndUpdateFrequency
        {
            get
            {
                return this.maintenanceAndUpdateFrequencyField;
            }
            set
            {
                this.maintenanceAndUpdateFrequencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequency
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequencyMD_MaintenanceFrequencyCode mD_MaintenanceFrequencyCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequencyMD_MaintenanceFrequencyCode MD_MaintenanceFrequencyCode
        {
            get
            {
                return this.mD_MaintenanceFrequencyCodeField;
            }
            set
            {
                this.mD_MaintenanceFrequencyCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequencyMD_MaintenanceFrequencyCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverview
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphic mD_BrowseGraphicField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphic MD_BrowseGraphic
        {
            get
            {
                return this.mD_BrowseGraphicField;
            }
            set
            {
                this.mD_BrowseGraphicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphic
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileName fileNameField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileDescription fileDescriptionField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileName fileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileDescription fileDescription
        {
            get
            {
                return this.fileDescriptionField;
            }
            set
            {
                this.fileDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileDescription
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_Keywords mD_KeywordsField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_Keywords MD_Keywords
        {
            get
            {
                return this.mD_KeywordsField;
            }
            set
            {
                this.mD_KeywordsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_Keywords
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsKeyword keywordField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsType typeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsKeyword keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsKeyword
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsType
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsTypeMD_KeywordTypeCode mD_KeywordTypeCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsTypeMD_KeywordTypeCode MD_KeywordTypeCode
        {
            get
            {
                return this.mD_KeywordTypeCodeField;
            }
            set
            {
                this.mD_KeywordTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsTypeMD_KeywordTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraints mD_LegalConstraintsField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraints MD_LegalConstraints
        {
            get
            {
                return this.mD_LegalConstraintsField;
            }
            set
            {
                this.mD_LegalConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraints
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraints accessConstraintsField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraints useConstraintsField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsOtherConstraints otherConstraintsField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraints accessConstraints
        {
            get
            {
                return this.accessConstraintsField;
            }
            set
            {
                this.accessConstraintsField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraints useConstraints
        {
            get
            {
                return this.useConstraintsField;
            }
            set
            {
                this.useConstraintsField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsOtherConstraints otherConstraints
        {
            get
            {
                return this.otherConstraintsField;
            }
            set
            {
                this.otherConstraintsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraints
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode mD_RestrictionCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode MD_RestrictionCode
        {
            get
            {
                return this.mD_RestrictionCodeField;
            }
            set
            {
                this.mD_RestrictionCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraints
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode mD_RestrictionCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode MD_RestrictionCode
        {
            get
            {
                return this.mD_RestrictionCodeField;
            }
            set
            {
                this.mD_RestrictionCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsOtherConstraints
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode mD_SpatialRepresentationTypeCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode MD_SpatialRepresentationTypeCode
        {
            get
            {
                return this.mD_SpatialRepresentationTypeCodeField;
            }
            set
            {
                this.mD_SpatialRepresentationTypeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolution
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_Resolution mD_ResolutionField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_Resolution MD_Resolution
        {
            get
            {
                return this.mD_ResolutionField;
            }
            set
            {
                this.mD_ResolutionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_Resolution
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScale equivalentScaleField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScale equivalentScale
        {
            get
            {
                return this.equivalentScaleField;
            }
            set
            {
                this.equivalentScaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScale
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFraction mD_RepresentativeFractionField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFraction MD_RepresentativeFraction
        {
            get
            {
                return this.mD_RepresentativeFractionField;
            }
            set
            {
                this.mD_RepresentativeFractionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFraction
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFractionDenominator denominatorField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFractionDenominator denominator
        {
            get
            {
                return this.denominatorField;
            }
            set
            {
                this.denominatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFractionDenominator
    {

        private uint integerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public uint Integer
        {
            get
            {
                return this.integerField;
            }
            set
            {
                this.integerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationLanguage
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode mD_CharacterSetCodeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode MD_CharacterSetCode
        {
            get
            {
                return this.mD_CharacterSetCodeField;
            }
            set
            {
                this.mD_CharacterSetCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory
    {

        private string mD_TopicCategoryCodeField;

        /// <remarks/>
        public string MD_TopicCategoryCode
        {
            get
            {
                return this.mD_TopicCategoryCodeField;
            }
            set
            {
                this.mD_TopicCategoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtent
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent eX_ExtentField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent EX_Extent
        {
            get
            {
                return this.eX_ExtentField;
            }
            set
            {
                this.eX_ExtentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement geographicElementField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElement temporalElementField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement geographicElement
        {
            get
            {
                return this.geographicElementField;
            }
            set
            {
                this.geographicElementField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElement temporalElement
        {
            get
            {
                return this.temporalElementField;
            }
            set
            {
                this.temporalElementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox eX_GeographicBoundingBoxField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox EX_GeographicBoundingBox
        {
            get
            {
                return this.eX_GeographicBoundingBoxField;
            }
            set
            {
                this.eX_GeographicBoundingBoxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude westBoundLongitudeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude eastBoundLongitudeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude southBoundLatitudeField;

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude northBoundLatitudeField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude westBoundLongitude
        {
            get
            {
                return this.westBoundLongitudeField;
            }
            set
            {
                this.westBoundLongitudeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude eastBoundLongitude
        {
            get
            {
                return this.eastBoundLongitudeField;
            }
            set
            {
                this.eastBoundLongitudeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude southBoundLatitude
        {
            get
            {
                return this.southBoundLatitudeField;
            }
            set
            {
                this.southBoundLatitudeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude northBoundLatitude
        {
            get
            {
                return this.northBoundLatitudeField;
            }
            set
            {
                this.northBoundLatitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude
    {

        private short decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude
    {

        private short decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude
    {

        private short decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude
    {

        private short decimalField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal
        {
            get
            {
                return this.decimalField;
            }
            set
            {
                this.decimalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElement
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtent eX_TemporalExtentField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtent EX_TemporalExtent
        {
            get
            {
                return this.eX_TemporalExtentField;
            }
            set
            {
                this.eX_TemporalExtentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtent
    {

        private MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtentExtent extentField;

        /// <remarks/>
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtentExtent extent
        {
            get
            {
                return this.extentField;
            }
            set
            {
                this.extentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtentExtent
    {

        private TimePeriod timePeriodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opengis.net/gml")]
        public TimePeriod TimePeriod
        {
            get
            {
                return this.timePeriodField;
            }
            set
            {
                this.timePeriodField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimePeriod
    {

        private System.DateTime beginPositionField;

        private System.DateTime endPositionField;

        private string idField;

        /// <remarks/>
        public System.DateTime beginPosition
        {
            get
            {
                return this.beginPositionField;
            }
            set
            {
                this.beginPositionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime endPosition
        {
            get
            {
                return this.endPositionField;
            }
            set
            {
                this.endPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified)]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSupplementalInformation
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfo
    {

        private MD_MetadataDistributionInfoMD_Distribution mD_DistributionField;

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_Distribution MD_Distribution
        {
            get
            {
                return this.mD_DistributionField;
            }
            set
            {
                this.mD_DistributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_Distribution
    {

        private MD_MetadataDistributionInfoMD_DistributionTransferOptions transferOptionsField;

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_DistributionTransferOptions transferOptions
        {
            get
            {
                return this.transferOptionsField;
            }
            set
            {
                this.transferOptionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptions
    {

        private MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLine[] mD_DigitalTransferOptionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("onLine", IsNullable = false)]
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLine[] MD_DigitalTransferOptions
        {
            get
            {
                return this.mD_DigitalTransferOptionsField;
            }
            set
            {
                this.mD_DigitalTransferOptionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLine
    {

        private MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResource cI_OnlineResourceField;

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResource CI_OnlineResource
        {
            get
            {
                return this.cI_OnlineResourceField;
            }
            set
            {
                this.cI_OnlineResourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResource
    {

        private MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceLinkage linkageField;

        private MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceProtocol protocolField;

        private MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceName nameField;

        private MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceDescription descriptionField;

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceLinkage linkage
        {
            get
            {
                return this.linkageField;
            }
            set
            {
                this.linkageField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceProtocol protocol
        {
            get
            {
                return this.protocolField;
            }
            set
            {
                this.protocolField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceName name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceDescription description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceLinkage
    {

        private string uRLField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceProtocol
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceName
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceDescription
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfo
    {

        private MD_MetadataDataQualityInfoDQ_DataQuality dQ_DataQualityField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQuality DQ_DataQuality
        {
            get
            {
                return this.dQ_DataQualityField;
            }
            set
            {
                this.dQ_DataQualityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQuality
    {

        private MD_MetadataDataQualityInfoDQ_DataQualityScope scopeField;

        private MD_MetadataDataQualityInfoDQ_DataQualityLineage lineageField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityScope scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityLineage lineage
        {
            get
            {
                return this.lineageField;
            }
            set
            {
                this.lineageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScope
    {

        private MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_Scope dQ_ScopeField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_Scope DQ_Scope
        {
            get
            {
                return this.dQ_ScopeField;
            }
            set
            {
                this.dQ_ScopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_Scope
    {

        private MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevel levelField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevel level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevel
    {

        private MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevelMD_ScopeCode mD_ScopeCodeField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevelMD_ScopeCode MD_ScopeCode
        {
            get
            {
                return this.mD_ScopeCodeField;
            }
            set
            {
                this.mD_ScopeCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevelMD_ScopeCode
    {

        private string codeListField;

        private string codeListValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeList
        {
            get
            {
                return this.codeListField;
            }
            set
            {
                this.codeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeListValue
        {
            get
            {
                return this.codeListValueField;
            }
            set
            {
                this.codeListValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityLineage
    {

        private MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_Lineage lI_LineageField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_Lineage LI_Lineage
        {
            get
            {
                return this.lI_LineageField;
            }
            set
            {
                this.lI_LineageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_Lineage
    {

        private MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_LineageStatement statementField;

        /// <remarks/>
        public MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_LineageStatement statement
        {
            get
            {
                return this.statementField;
            }
            set
            {
                this.statementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_LineageStatement
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