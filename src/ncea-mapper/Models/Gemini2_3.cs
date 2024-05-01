using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ncea.mapper.Models
{
    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    [XmlRootAttribute(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd", IsNullable = false)]
    public partial class Gemini2_3_MD_Metadata
    {
        public MD_MetadataFileIdentifier? fileIdentifier { get; set; }
        public MD_MetadataLanguage? language { get; set; }
        public MD_MetadataCharacterSet? characterSet { get; set; }
        public MD_MetadataContact? contact { get; set; }
        public MD_MetadataDateStamp? dateStamp { get; set; }
        public MD_MetadataMetadataStandardName? metadataStandardName { get; set; }
        public MD_MetadataMetadataStandardVersion? metadataStandardVersion { get; set; }
        public MD_MetadataSpatialRepresentationInfo? spatialRepresentationInfo { get; set; }
        public MD_MetadataReferenceSystemInfo? referenceSystemInfo { get; set; }
        public MD_MetadataIdentificationInfo? identificationInfo { get; set; }
        public MD_MetadataDistributionInfo? distributionInfo { get; set; }
        public MD_MetadataDataQualityInfo? dataQualityInfo { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataFileIdentifier : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataLanguage : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataCharacterSet
    {
        public MD_MetadataCharacterSetMD_CharacterSetCode? MD_CharacterSetCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataCharacterSetMD_CharacterSetCode
    {
        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }

        [XmlAttributeAttribute()]
        public string? codeList { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContact
    {
        public MD_MetadataContactCI_ResponsibleParty? CI_ResponsibleParty { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsibleParty
    {
        public MD_MetadataContactCI_ResponsiblePartyIndividualName? individualName { get; set; }
        public MD_MetadataContactCI_ResponsiblePartyOrganisationName? organisationName { get; set; }
        public MD_MetadataContactCI_ResponsiblePartyPositionName? positionName { get; set; }
        public MD_MetadataContactCI_ResponsiblePartyRole? role { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyIndividualName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyOrganisationName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyPositionName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyRole
    {
        public MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode? CI_RoleCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataContactCI_ResponsiblePartyRoleCI_RoleCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDateStamp
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public DateTime DateTime { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataStandardName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataMetadataStandardVersion : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfo
    {
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentation? MD_VectorSpatialRepresentation { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentation
    {
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevel? topologyLevel { get; set; }
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjects? geometricObjects { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevel
    {
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevelMD_TopologyLevelCode? MD_TopologyLevelCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationTopologyLevelMD_TopologyLevelCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjects
    {
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjects? MD_GeometricObjects { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjects
    {
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectType? geometricObjectType { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectType
    {
        public MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectTypeMD_GeometricObjectTypeCode? MD_GeometricObjectTypeCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataSpatialRepresentationInfoMD_VectorSpatialRepresentationGeometricObjectsMD_GeometricObjectsGeometricObjectTypeMD_GeometricObjectTypeCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfo
    {
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystem? MD_ReferenceSystem { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystem
    {
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier? referenceSystemIdentifier { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifier
    {
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier? RS_Identifier { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_Identifier
    {
        public MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode? code { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataReferenceSystemInfoMD_ReferenceSystemReferenceSystemIdentifierRS_IdentifierCode : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfo
    {
        public MD_MetadataIdentificationInfoMD_DataIdentification? MD_DataIdentification { get; set; }

        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/srv")]
        public SV_ServiceIdentification? SV_ServiceIdentification { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/srv")]
    [XmlRootAttribute(Namespace = "http://www.isotc211.org/2005/srv", IsNullable = false)]
    public partial class SV_ServiceIdentification
    {
        public SV_ServiceIdentificationServiceType? serviceType { get; set; }
        public SV_ServiceIdentificationOperatesOn? operatesOn { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/srv")]
    public partial class SV_ServiceIdentificationServiceType
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string? LocalName { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/srv")]
    public partial class SV_ServiceIdentificationOperatesOn
    {
        [XmlAttributeAttribute(Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/xlink")]
        public string? href { get; set; }
    }



    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentification
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitation? citation { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationAbstract? @abstract { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPurpose? purpose { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationStatus? status { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContact? pointOfContact { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenance? resourceMaintenance { get; set; }
        [XmlElementAttribute("graphicOverview")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverview[]? graphicOverview { get; set; }
        [XmlElementAttribute("descriptiveKeywords")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords[]? descriptiveKeywords { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints? resourceConstraints { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType? spatialRepresentationType { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolution? spatialResolution { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationLanguage? language { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet? characterSet { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory? topicCategory { get; set; }
        [XmlElementAttribute("extent")]
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtent[]? extent { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationSupplementalInformation? supplementalInformation { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitation
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation? CI_Citation { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_Citation
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle? title { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate? date { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition? edition { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm? presentationForm { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationTitle : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDate
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date? CI_Date { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_Date
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate? date { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType? dateType { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDate
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco", DataType = "date")]
        public DateTime Date { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateType
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode? CI_DateTypeCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationDateCI_DateDateTypeCI_DateTypeCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationEdition : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationForm
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode? CI_PresentationFormCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCitationCI_CitationPresentationFormCI_PresentationFormCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationAbstract : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPurpose : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationStatus
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationStatusMD_ProgressCode? MD_ProgressCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationStatusMD_ProgressCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContact
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsibleParty? CI_ResponsibleParty { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsibleParty
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyIndividualName? individualName { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyOrganisationName? organisationName { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyPositionName? positionName { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfo? contactInfo { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRole? role { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyIndividualName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyOrganisationName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyPositionName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfo
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_Contact? CI_Contact { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_Contact
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddress? address { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddress
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address? CI_Address { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_Address
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint? deliveryPoint { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity? city { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea? administrativeArea { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode? postalCode { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry? country { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress? electronicMailAddress { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressDeliveryPoint : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCity : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressAdministrativeArea : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressPostalCode : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressCountry : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyContactInfoCI_ContactAddressCI_AddressElectronicMailAddress : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRole
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRoleCI_RoleCode? CI_RoleCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationPointOfContactCI_ResponsiblePartyRoleCI_RoleCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenance
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformation? MD_MaintenanceInformation { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformation
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequency? maintenanceAndUpdateFrequency { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequency
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequencyMD_MaintenanceFrequencyCode? MD_MaintenanceFrequencyCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceMaintenanceMD_MaintenanceInformationMaintenanceAndUpdateFrequencyMD_MaintenanceFrequencyCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverview
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphic? MD_BrowseGraphic { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphic
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileName? fileName { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileDescription? fileDescription { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationGraphicOverviewMD_BrowseGraphicFileDescription : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywords
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_Keywords? MD_Keywordst { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_Keywords
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsKeyword? keyword { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsType? type { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsKeyword : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsType
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsTypeMD_KeywordTypeCode? MD_KeywordTypeCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationDescriptiveKeywordsMD_KeywordsTypeMD_KeywordTypeCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraints
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraints? MD_LegalConstraints { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraints
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraints? accessConstraints { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraints? useConstraints { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsOtherConstraints? otherConstraints { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraints
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode? MD_RestrictionCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsAccessConstraintsMD_RestrictionCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraints
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode? MD_RestrictionCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsUseConstraintsMD_RestrictionCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationResourceConstraintsMD_LegalConstraintsOtherConstraints : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationType
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode? MD_SpatialRepresentationTypeCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialRepresentationTypeMD_SpatialRepresentationTypeCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolution
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_Resolution? MD_Resolution { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_Resolution
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScale? equivalentScale { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScale
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFraction? MD_RepresentativeFraction { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFraction
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFractionDenominator? denominator { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSpatialResolutionMD_ResolutionEquivalentScaleMD_RepresentativeFractionDenominator
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public uint Integer { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationLanguage : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSet
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode? MD_CharacterSetCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationCharacterSetMD_CharacterSetCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }

        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationTopicCategory
    {
        public string? MD_TopicCategoryCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtent
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent? EX_Extent { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_Extent
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement? geographicElement { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElement? temporalElement { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElement
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox? EX_GeographicBoundingBox { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBox
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude? westBoundLongitude { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude? eastBoundLongitude { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude? southBoundLatitude { get; set; }
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude? northBoundLatitude { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxWestBoundLongitude
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxEastBoundLongitude
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxSouthBoundLatitude
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentGeographicElementEX_GeographicBoundingBoxNorthBoundLatitude
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public short Decimal { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElement
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtent? EX_TemporalExtent { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtent
    {
        public MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtentExtent? extent { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationExtentEX_ExtentTemporalElementEX_TemporalExtentExtent
    {
        [XmlElementAttribute(Namespace = "http://www.opengis.net/gml")]
        public TimePeriod? TimePeriod { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opengis.net/gml")]
    [XmlRootAttribute(Namespace = "http://www.opengis.net/gml", IsNullable = false)]
    public partial class TimePeriod
    {
        public DateTime beginPosition { get; set; }
        public DateTime endPosition { get; set; }
        [XmlAttributeAttribute(Form = XmlSchemaForm.Qualified)]
        public string? id { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataIdentificationInfoMD_DataIdentificationSupplementalInformation : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfo
    {
        public MD_MetadataDistributionInfoMD_Distribution? MD_Distribution { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_Distribution
    {
        public MD_MetadataDistributionInfoMD_DistributionTransferOptions? transferOptions { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptions
    {
        [XmlArrayItemAttribute("onLine", IsNullable = false)]
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLine[]? MD_DigitalTransferOptions { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLine
    {
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResource? CI_OnlineResource { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResource
    {
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceLinkage? linkage { get; set; }
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceProtocol? protocol { get; set; }
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceName? name { get; set; }
        public MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceDescription? description { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceLinkage
    {
        public string? URL { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceProtocol : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceName : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDistributionInfoMD_DistributionTransferOptionsOnLineCI_OnlineResourceDescription : CharacterStringBase
    { }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfo
    {
        public MD_MetadataDataQualityInfoDQ_DataQuality? DQ_DataQuality { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQuality
    {
        public MD_MetadataDataQualityInfoDQ_DataQualityScope? scope { get; set; }
        public MD_MetadataDataQualityInfoDQ_DataQualityLineage? lineage { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScope
    {
        public MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_Scope? DQ_Scope { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_Scope
    {
        public MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevel? level { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevel
    {
        public MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevelMD_ScopeCode? MD_ScopeCode { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityScopeDQ_ScopeLevelMD_ScopeCode
    {
        [XmlAttributeAttribute()]
        public string? codeList { get; set; }
        [XmlAttributeAttribute()]
        public string? codeListValue { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityLineage
    {
        public MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_Lineage? LI_Lineage { get; set; }
    }


    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_Lineage
    {
        public MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_LineageStatement? statement { get; set; }
    }

    [SerializableAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataDataQualityInfoDQ_DataQualityLineageLI_LineageStatement : CharacterStringBase
    {
    }
    public class CharacterStringBase
    {
        [XmlElementAttribute(Namespace = "http://www.isotc211.org/2005/gco")]
        public string? CharacterString { get; set; }
    }
}