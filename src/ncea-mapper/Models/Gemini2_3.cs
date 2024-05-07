﻿using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace ncea.mapper.Models
{
    [XmlRoot(ElementName = "MD_Metadata", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Gemini2_3_MD_Metadata
    {
        [XmlElement(ElementName = "fileIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public FileIdentifier FileIdentifier { get; set; }
        [XmlElement(ElementName = "language", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Language Language { get; set; }
        [XmlElement(ElementName = "hierarchyLevel", Namespace = "http://www.isotc211.org/2005/gmd")]
        public HierarchyLevel HierarchyLevel { get; set; }
        [XmlElement(ElementName = "parentIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ParentIdentifier ParentIdentifier { get; set; }
        [XmlElement(ElementName = "contact", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Contact Contact { get; set; }
        [XmlElement(ElementName = "dateStamp", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DateStamp DateStamp { get; set; }
        [XmlElement(ElementName = "metadataStandardName", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MetadataStandardName MetadataStandardName { get; set; }
        [XmlElement(ElementName = "metadataStandardVersion", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MetadataStandardVersion MetadataStandardVersion { get; set; }
        [XmlElement(ElementName = "referenceSystemInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ReferenceSystemInfo ReferenceSystemInfo { get; set; }
        [XmlElement(ElementName = "identificationInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
        public IdentificationInfo IdentificationInfo { get; set; }
        [XmlElement(ElementName = "distributionInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DistributionInfo DistributionInfo { get; set; }
        [XmlElement(ElementName = "dataQualityInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DataQualityInfo DataQualityInfo { get; set; }
        [XmlAttribute(AttributeName = "gss", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gss { get; set; }
        [XmlAttribute(AttributeName = "gsr", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gsr { get; set; }
        [XmlAttribute(AttributeName = "gco", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gco { get; set; }
        [XmlAttribute(AttributeName = "gml", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gml { get; set; }
        [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xlink { get; set; }
        [XmlAttribute(AttributeName = "gts", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gts { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "srv", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Srv { get; set; }
        [XmlAttribute(AttributeName = "gmx", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gmx { get; set; }
        [XmlAttribute(AttributeName = "gmd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Gmd { get; set; }
        [XmlElement(ElementName = "hierarchyLevelName", Namespace = "http://www.isotc211.org/2005/gmd")]
        public HierarchyLevelName HierarchyLevelName { get; set; }
        [XmlAttribute(AttributeName = "geonet", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Geonet { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
    }

    [XmlRoot(ElementName = "fileIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class FileIdentifier
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "LanguageCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class LanguageCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "language", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Language
    {
        [XmlElement(ElementName = "LanguageCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public LanguageCode LanguageCode { get; set; }
    }

    [XmlRoot(ElementName = "MD_ScopeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_ScopeCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "hierarchyLevel", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class HierarchyLevel
    {
        [XmlElement(ElementName = "MD_ScopeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_ScopeCode MD_ScopeCode { get; set; }
    }

    [XmlRoot(ElementName = "parentIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ParentIdentifier
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "organisationName", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class OrganisationName
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "electronicMailAddress", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ElectronicMailAddress
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "CI_Address", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_Address
    {
        [XmlElement(ElementName = "electronicMailAddress", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ElectronicMailAddress ElectronicMailAddress { get; set; }
    }

    [XmlRoot(ElementName = "address", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Address
    {
        [XmlElement(ElementName = "CI_Address", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Address CI_Address { get; set; }
    }

    [XmlRoot(ElementName = "CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_Contact
    {
        [XmlElement(ElementName = "address", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Address Address { get; set; }
    }

    [XmlRoot(ElementName = "contactInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ContactInfo
    {
        [XmlElement(ElementName = "CI_Contact", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Contact CI_Contact { get; set; }
    }

    [XmlRoot(ElementName = "CI_RoleCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_RoleCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "role", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Role
    {
        [XmlElement(ElementName = "CI_RoleCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_RoleCode CI_RoleCode { get; set; }
    }

    [XmlRoot(ElementName = "CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_ResponsibleParty
    {
        [XmlElement(ElementName = "organisationName", Namespace = "http://www.isotc211.org/2005/gmd")]
        public OrganisationName OrganisationName { get; set; }
        [XmlElement(ElementName = "contactInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ContactInfo ContactInfo { get; set; }
        [XmlElement(ElementName = "role", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Role Role { get; set; }
        [XmlElement(ElementName = "positionName", Namespace = "http://www.isotc211.org/2005/gmd")]
        public PositionName PositionName { get; set; }
    }

    [XmlRoot(ElementName = "contact", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Contact
    {
        [XmlElement(ElementName = "CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_ResponsibleParty CI_ResponsibleParty { get; set; }
    }

    [XmlRoot(ElementName = "dateStamp", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DateStamp
    {
        [XmlElement(ElementName = "Date", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Date { get; set; }
        [XmlElement(ElementName = "DateTime", Namespace = "http://www.isotc211.org/2005/gco")]
        public string DateTime { get; set; }
    }

    [XmlRoot(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
    public class Anchor
    {
        [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/1999/xlink")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "metadataStandardName", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MetadataStandardName
    {
        [XmlElement(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
        public Anchor Anchor { get; set; }
    }

    [XmlRoot(ElementName = "metadataStandardVersion", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MetadataStandardVersion
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "title", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Title
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
        [XmlElement(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
        public Anchor Anchor { get; set; }
    }

    [XmlRoot(ElementName = "date", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Date
    {
        [XmlElement(ElementName = "Date", Namespace = "http://www.isotc211.org/2005/gco")]
        public string date { get; set; }
        [XmlElement(ElementName = "CI_Date", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Date CI_Date { get; set; }
    }

    [XmlRoot(ElementName = "CI_DateTypeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_DateTypeCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "dateType", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DateType
    {
        [XmlElement(ElementName = "CI_DateTypeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_DateTypeCode CI_DateTypeCode { get; set; }
    }

    [XmlRoot(ElementName = "CI_Date", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_Date
    {
        [XmlElement(ElementName = "date", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Date Date { get; set; }
        [XmlElement(ElementName = "dateType", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DateType DateType { get; set; }
    }

    [XmlRoot(ElementName = "CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_Citation
    {
        [XmlElement(ElementName = "title", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Title Title { get; set; }
        [XmlElement(ElementName = "date", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<Date> Date { get; set; }
        [XmlElement(ElementName = "alternateTitle", Namespace = "http://www.isotc211.org/2005/gmd")]
        public AlternateTitle AlternateTitle { get; set; }
        [XmlElement(ElementName = "identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<Identifier> Identifier { get; set; }
        [XmlElement(ElementName = "otherCitationDetails", Namespace = "http://www.isotc211.org/2005/gmd")]
        public OtherCitationDetails OtherCitationDetails { get; set; }
    }

    [XmlRoot(ElementName = "authority", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Authority
    {
        [XmlElement(ElementName = "CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Citation CI_Citation { get; set; }
    }

    [XmlRoot(ElementName = "code", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Code
    {
        [XmlElement(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
        public Anchor Anchor { get; set; }
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "RS_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class RS_Identifier
    {
        [XmlElement(ElementName = "authority", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Authority Authority { get; set; }
        [XmlElement(ElementName = "code", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Code Code { get; set; }
    }

    [XmlRoot(ElementName = "referenceSystemIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ReferenceSystemIdentifier
    {
        [XmlElement(ElementName = "RS_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public RS_Identifier RS_Identifier { get; set; }
    }

    [XmlRoot(ElementName = "MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_ReferenceSystem
    {
        [XmlElement(ElementName = "referenceSystemIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ReferenceSystemIdentifier ReferenceSystemIdentifier { get; set; }
    }

    [XmlRoot(ElementName = "referenceSystemInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ReferenceSystemInfo
    {
        [XmlElement(ElementName = "MD_ReferenceSystem", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_ReferenceSystem MD_ReferenceSystem { get; set; }
    }

    [XmlRoot(ElementName = "alternateTitle", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class AlternateTitle
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "codeSpace", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CodeSpace
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_Identifier
    {
        [XmlElement(ElementName = "code", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Code Code { get; set; }
        [XmlElement(ElementName = "codeSpace", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CodeSpace CodeSpace { get; set; }
        [XmlElement(ElementName = "authority", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Authority Authority { get; set; }
    }

    [XmlRoot(ElementName = "identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Identifier
    {
        [XmlElement(ElementName = "MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_Identifier MD_Identifier { get; set; }
    }

    [XmlRoot(ElementName = "citation", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Citation
    {
        [XmlElement(ElementName = "CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Citation CI_Citation { get; set; }
    }

    [XmlRoot(ElementName = "abstract", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Abstract
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "positionName", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class PositionName
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "pointOfContact", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class PointOfContact
    {
        [XmlElement(ElementName = "CI_ResponsibleParty", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_ResponsibleParty CI_ResponsibleParty { get; set; }
    }

    [XmlRoot(ElementName = "MD_MaintenanceFrequencyCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_MaintenanceFrequencyCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "maintenanceAndUpdateFrequency", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MaintenanceAndUpdateFrequency
    {
        [XmlElement(ElementName = "MD_MaintenanceFrequencyCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_MaintenanceFrequencyCode MD_MaintenanceFrequencyCode { get; set; }
    }

    [XmlRoot(ElementName = "MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_MaintenanceInformation
    {
        [XmlElement(ElementName = "maintenanceAndUpdateFrequency", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MaintenanceAndUpdateFrequency MaintenanceAndUpdateFrequency { get; set; }
    }

    [XmlRoot(ElementName = "resourceMaintenance", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ResourceMaintenance
    {
        [XmlElement(ElementName = "MD_MaintenanceInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_MaintenanceInformation MD_MaintenanceInformation { get; set; }
    }

    [XmlRoot(ElementName = "keyword", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Keyword
    {
        [XmlElement(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
        public Anchor Anchor { get; set; }
    }

    [XmlRoot(ElementName = "thesaurusName", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ThesaurusName
    {
        [XmlElement(ElementName = "CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Citation CI_Citation { get; set; }
    }

    [XmlRoot(ElementName = "MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_Keywords
    {
        [XmlElement(ElementName = "keyword", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Keyword Keyword { get; set; }
        [XmlElement(ElementName = "thesaurusName", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ThesaurusName ThesaurusName { get; set; }
    }

    [XmlRoot(ElementName = "descriptiveKeywords", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DescriptiveKeywords
    {
        [XmlElement(ElementName = "MD_Keywords", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_Keywords MD_Keywords { get; set; }
    }

    [XmlRoot(ElementName = "MD_RestrictionCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_RestrictionCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "accessConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class AccessConstraints
    {
        [XmlElement(ElementName = "MD_RestrictionCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_RestrictionCode MD_RestrictionCode { get; set; }
    }

    [XmlRoot(ElementName = "otherConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class OtherConstraints
    {
        [XmlElement(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
        public Anchor Anchor { get; set; }
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_LegalConstraints
    {
        [XmlElement(ElementName = "accessConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
        public AccessConstraints AccessConstraints { get; set; }
        [XmlElement(ElementName = "otherConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<OtherConstraints> OtherConstraints { get; set; }
        [XmlElement(ElementName = "useConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
        public UseConstraints UseConstraints { get; set; }
    }

    [XmlRoot(ElementName = "resourceConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class ResourceConstraints
    {
        [XmlElement(ElementName = "MD_LegalConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<MD_LegalConstraints> MD_LegalConstraints { get; set; }
    }

    [XmlRoot(ElementName = "useConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class UseConstraints
    {
        [XmlElement(ElementName = "MD_RestrictionCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_RestrictionCode MD_RestrictionCode { get; set; }
    }

    [XmlRoot(ElementName = "MD_SpatialRepresentationTypeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_SpatialRepresentationTypeCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
    }

    [XmlRoot(ElementName = "spatialRepresentationType", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class SpatialRepresentationType
    {
        [XmlElement(ElementName = "MD_SpatialRepresentationTypeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_SpatialRepresentationTypeCode MD_SpatialRepresentationTypeCode { get; set; }
    }

    [XmlRoot(ElementName = "Distance", Namespace = "http://www.isotc211.org/2005/gco")]
    public class GcoDistance
    {
        [XmlAttribute(AttributeName = "uom")]
        public string Uom { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "distance", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Distance
    {
        [XmlElement(ElementName = "Distance", Namespace = "http://www.isotc211.org/2005/gco")]
        public GcoDistance distance { get; set; }
        [XmlAttribute(AttributeName = "nilReason", Namespace = "http://www.isotc211.org/2005/gco")]
        public string NilReason { get; set; }
    }

    [XmlRoot(ElementName = "MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_Resolution
    {
        [XmlElement(ElementName = "distance", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Distance Distance { get; set; }
        [XmlElement(ElementName = "equivalentScale", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EquivalentScale EquivalentScale { get; set; }
    }

    [XmlRoot(ElementName = "spatialResolution", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class SpatialResolution
    {
        [XmlElement(ElementName = "MD_Resolution", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_Resolution MD_Resolution { get; set; }
    }

    [XmlRoot(ElementName = "MD_CharacterSetCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_CharacterSetCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "characterSet", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CharacterSet
    {
        [XmlElement(ElementName = "MD_CharacterSetCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_CharacterSetCode MD_CharacterSetCode { get; set; }
    }

    [XmlRoot(ElementName = "topicCategory", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class TopicCategory
    {
        [XmlElement(ElementName = "MD_TopicCategoryCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public string MD_TopicCategoryCode { get; set; }
    }

    [XmlRoot(ElementName = "westBoundLongitude", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class WestBoundLongitude
    {
        [XmlElement(ElementName = "Decimal", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Decimal { get; set; }
    }

    [XmlRoot(ElementName = "eastBoundLongitude", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EastBoundLongitude
    {
        [XmlElement(ElementName = "Decimal", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Decimal { get; set; }
    }

    [XmlRoot(ElementName = "southBoundLatitude", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class SouthBoundLatitude
    {
        [XmlElement(ElementName = "Decimal", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Decimal { get; set; }
    }

    [XmlRoot(ElementName = "northBoundLatitude", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class NorthBoundLatitude
    {
        [XmlElement(ElementName = "Decimal", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Decimal { get; set; }
    }

    [XmlRoot(ElementName = "EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EX_GeographicBoundingBox
    {
        [XmlElement(ElementName = "westBoundLongitude", Namespace = "http://www.isotc211.org/2005/gmd")]
        public WestBoundLongitude WestBoundLongitude { get; set; }
        [XmlElement(ElementName = "eastBoundLongitude", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EastBoundLongitude EastBoundLongitude { get; set; }
        [XmlElement(ElementName = "southBoundLatitude", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SouthBoundLatitude SouthBoundLatitude { get; set; }
        [XmlElement(ElementName = "northBoundLatitude", Namespace = "http://www.isotc211.org/2005/gmd")]
        public NorthBoundLatitude NorthBoundLatitude { get; set; }
    }

    [XmlRoot(ElementName = "geographicElement", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class GeographicElement
    {
        [XmlElement(ElementName = "EX_GeographicBoundingBox", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EX_GeographicBoundingBox EX_GeographicBoundingBox { get; set; }
        [XmlElement(ElementName = "EX_GeographicDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EX_GeographicDescription EX_GeographicDescription { get; set; }
    }

    [XmlRoot(ElementName = "geographicIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class GeographicIdentifier
    {
        [XmlElement(ElementName = "MD_Identifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_Identifier MD_Identifier { get; set; }
    }

    [XmlRoot(ElementName = "EX_GeographicDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EX_GeographicDescription
    {
        [XmlElement(ElementName = "geographicIdentifier", Namespace = "http://www.isotc211.org/2005/gmd")]
        public GeographicIdentifier GeographicIdentifier { get; set; }
    }

    [XmlRoot(ElementName = "minimumValue", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MinimumValue
    {
        [XmlElement(ElementName = "Real", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Real { get; set; }
    }

    [XmlRoot(ElementName = "maximumValue", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MaximumValue
    {
        [XmlElement(ElementName = "Real", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Real { get; set; }
    }

    [XmlRoot(ElementName = "verticalCRS", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class VerticalCRS
    {
        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EX_VerticalExtent
    {
        [XmlElement(ElementName = "minimumValue", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MinimumValue MinimumValue { get; set; }
        [XmlElement(ElementName = "maximumValue", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MaximumValue MaximumValue { get; set; }
        [XmlElement(ElementName = "verticalCRS", Namespace = "http://www.isotc211.org/2005/gmd")]
        public VerticalCRS VerticalCRS { get; set; }
    }

    [XmlRoot(ElementName = "verticalElement", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class VerticalElement
    {
        [XmlElement(ElementName = "EX_VerticalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EX_VerticalExtent EX_VerticalExtent { get; set; }
    }

    [XmlRoot(ElementName = "TimePeriod", Namespace = "http://www.opengis.net/gml/3.2")]
    public class TimePeriod
    {
        [XmlElement(ElementName = "beginPosition", Namespace = "http://www.opengis.net/gml/3.2")]
        public string BeginPosition { get; set; }
        [XmlElement(ElementName = "endPosition", Namespace = "http://www.opengis.net/gml/3.2")]
        public string EndPosition { get; set; }
        [XmlAttribute(AttributeName = "id", Namespace = "http://www.opengis.net/gml/3.2")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "extent", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Extent
    {
        [XmlElement(ElementName = "TimePeriod", Namespace = "http://www.opengis.net/gml/3.2")]
        public TimePeriod TimePeriod { get; set; }
        [XmlElement(ElementName = "EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EX_Extent EX_Extent { get; set; }
    }

    [XmlRoot(ElementName = "EX_TemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EX_TemporalExtent
    {
        [XmlElement(ElementName = "extent", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Extent Extent { get; set; }
    }

    [XmlRoot(ElementName = "temporalElement", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class TemporalElement
    {
        [XmlElement(ElementName = "EX_TemporalExtent", Namespace = "http://www.isotc211.org/2005/gmd")]
        public EX_TemporalExtent EX_TemporalExtent { get; set; }
    }

    [XmlRoot(ElementName = "EX_Extent", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EX_Extent
    {
        [XmlElement(ElementName = "geographicElement", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<GeographicElement> GeographicElement { get; set; }
        [XmlElement(ElementName = "verticalElement", Namespace = "http://www.isotc211.org/2005/gmd")]
        public VerticalElement VerticalElement { get; set; }
        [XmlElement(ElementName = "temporalElement", Namespace = "http://www.isotc211.org/2005/gmd")]
        public TemporalElement TemporalElement { get; set; }
    }

    [XmlRoot(ElementName = "supplementalInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class SupplementalInformation
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "name", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Name
    {
        [XmlElement(ElementName = "Anchor", Namespace = "http://www.isotc211.org/2005/gmx")]
        public Anchor Anchor { get; set; }
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "version", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Version
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
        [XmlAttribute(AttributeName = "nilReason", Namespace = "http://www.isotc211.org/2005/gco")]
        public string NilReason { get; set; }
    }

    [XmlRoot(ElementName = "MD_Format", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_Format
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "version", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Version Version { get; set; }
    }

    [XmlRoot(ElementName = "distributionFormat", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DistributionFormat
    {
        [XmlElement(ElementName = "MD_Format", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_Format MD_Format { get; set; }
    }

    [XmlRoot(ElementName = "MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_DataIdentification
    {
        [XmlElement(ElementName = "citation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Citation Citation { get; set; }
        [XmlElement(ElementName = "abstract", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Abstract Abstract { get; set; }
        [XmlElement(ElementName = "pointOfContact", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<PointOfContact> PointOfContact { get; set; }
        [XmlElement(ElementName = "resourceMaintenance", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ResourceMaintenance ResourceMaintenance { get; set; }
        [XmlElement(ElementName = "descriptiveKeywords", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<DescriptiveKeywords> DescriptiveKeywords { get; set; }
        [XmlElement(ElementName = "resourceConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<ResourceConstraints> ResourceConstraints { get; set; }
        [XmlElement(ElementName = "spatialRepresentationType", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SpatialRepresentationType SpatialRepresentationType { get; set; }
        [XmlElement(ElementName = "spatialResolution", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SpatialResolution SpatialResolution { get; set; }
        [XmlElement(ElementName = "language", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Language Language { get; set; }
        [XmlElement(ElementName = "characterSet", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CharacterSet CharacterSet { get; set; }
        [XmlElement(ElementName = "topicCategory", Namespace = "http://www.isotc211.org/2005/gmd")]
        public TopicCategory TopicCategory { get; set; }
        [XmlElement(ElementName = "extent", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Extent Extent { get; set; }
        [XmlElement(ElementName = "supplementalInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SupplementalInformation SupplementalInformation { get; set; }
        [XmlElement(ElementName = "distributionFormat", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DistributionFormat DistributionFormat { get; set; }
    }

    [XmlRoot(ElementName = "identificationInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class IdentificationInfo
    {
        [XmlElement(ElementName = "MD_DataIdentification", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_DataIdentification MD_DataIdentification { get; set; }
        [XmlElement(ElementName = "SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv")]
        public SV_ServiceIdentification SV_ServiceIdentification { get; set; }
    }

    [XmlRoot(ElementName = "linkage", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Linkage
    {
        [XmlElement(ElementName = "URL", Namespace = "http://www.isotc211.org/2005/gmd")]
        public string URL { get; set; }
    }

    [XmlRoot(ElementName = "description", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Description
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "CI_OnLineFunctionCode", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_OnLineFunctionCode
    {
        [XmlAttribute(AttributeName = "codeList")]
        public string CodeList { get; set; }
        [XmlAttribute(AttributeName = "codeListValue")]
        public string CodeListValue { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "function", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Function
    {
        [XmlElement(ElementName = "CI_OnLineFunctionCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_OnLineFunctionCode CI_OnLineFunctionCode { get; set; }
    }

    [XmlRoot(ElementName = "CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class CI_OnlineResource
    {
        [XmlElement(ElementName = "linkage", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Linkage Linkage { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Name Name { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Description Description { get; set; }
        [XmlElement(ElementName = "function", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Function Function { get; set; }
    }

    [XmlRoot(ElementName = "onLine", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class OnLine
    {
        [XmlElement(ElementName = "CI_OnlineResource", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_OnlineResource CI_OnlineResource { get; set; }
    }

    [XmlRoot(ElementName = "MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_DigitalTransferOptions
    {
        [XmlElement(ElementName = "onLine", Namespace = "http://www.isotc211.org/2005/gmd")]
        public OnLine OnLine { get; set; }
    }

    [XmlRoot(ElementName = "transferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class TransferOptions
    {
        [XmlElement(ElementName = "MD_DigitalTransferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_DigitalTransferOptions MD_DigitalTransferOptions { get; set; }
    }

    [XmlRoot(ElementName = "MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_Distribution
    {
        [XmlElement(ElementName = "distributionFormat", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<DistributionFormat> DistributionFormat { get; set; }
        [XmlElement(ElementName = "transferOptions", Namespace = "http://www.isotc211.org/2005/gmd")]
        public TransferOptions TransferOptions { get; set; }
    }

    [XmlRoot(ElementName = "distributionInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DistributionInfo
    {
        [XmlElement(ElementName = "MD_Distribution", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_Distribution MD_Distribution { get; set; }
    }

    [XmlRoot(ElementName = "level", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Level
    {
        [XmlElement(ElementName = "MD_ScopeCode", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_ScopeCode MD_ScopeCode { get; set; }
    }

    [XmlRoot(ElementName = "DQ_Scope", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DQ_Scope
    {
        [XmlElement(ElementName = "level", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Level Level { get; set; }
        [XmlElement(ElementName = "levelDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
        public LevelDescription LevelDescription { get; set; }
    }

    [XmlRoot(ElementName = "scope", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Scope
    {
        [XmlElement(ElementName = "DQ_Scope", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DQ_Scope DQ_Scope { get; set; }
    }

    [XmlRoot(ElementName = "specification", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Specification
    {
        [XmlElement(ElementName = "CI_Citation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public CI_Citation CI_Citation { get; set; }
    }

    [XmlRoot(ElementName = "explanation", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Explanation
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "pass", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Pass
    {
        [XmlElement(ElementName = "Boolean", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Boolean { get; set; }
    }

    [XmlRoot(ElementName = "DQ_ConformanceResult", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DQ_ConformanceResult
    {
        [XmlElement(ElementName = "specification", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Specification Specification { get; set; }
        [XmlElement(ElementName = "explanation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Explanation Explanation { get; set; }
        [XmlElement(ElementName = "pass", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Pass Pass { get; set; }
    }

    [XmlRoot(ElementName = "result", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Result
    {
        [XmlElement(ElementName = "DQ_ConformanceResult", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DQ_ConformanceResult DQ_ConformanceResult { get; set; }
    }

    [XmlRoot(ElementName = "DQ_DomainConsistency", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DQ_DomainConsistency
    {
        [XmlElement(ElementName = "result", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Result Result { get; set; }
    }

    [XmlRoot(ElementName = "report", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Report
    {
        [XmlElement(ElementName = "DQ_DomainConsistency", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DQ_DomainConsistency DQ_DomainConsistency { get; set; }
    }

    [XmlRoot(ElementName = "statement", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Statement
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "LI_Lineage", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class LI_Lineage
    {
        [XmlElement(ElementName = "statement", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Statement Statement { get; set; }
    }

    [XmlRoot(ElementName = "lineage", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Lineage
    {
        [XmlElement(ElementName = "LI_Lineage", Namespace = "http://www.isotc211.org/2005/gmd")]
        public LI_Lineage LI_Lineage { get; set; }
    }

    [XmlRoot(ElementName = "DQ_DataQuality", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DQ_DataQuality
    {
        [XmlElement(ElementName = "scope", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Scope Scope { get; set; }
        [XmlElement(ElementName = "report", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Report Report { get; set; }
        [XmlElement(ElementName = "lineage", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Lineage Lineage { get; set; }
    }

    [XmlRoot(ElementName = "dataQualityInfo", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class DataQualityInfo
    {
        [XmlElement(ElementName = "DQ_DataQuality", Namespace = "http://www.isotc211.org/2005/gmd")]
        public DQ_DataQuality DQ_DataQuality { get; set; }
    }

        

    [XmlRoot(ElementName = "hierarchyLevelName", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class HierarchyLevelName
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "serviceType", Namespace = "http://www.isotc211.org/2005/srv")]
    public class ServiceType
    {
        [XmlElement(ElementName = "LocalName", Namespace = "http://www.isotc211.org/2005/gco")]
        public string LocalName { get; set; }
    }

    [XmlRoot(ElementName = "otherCitationDetails", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class OtherCitationDetails
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "operatesOn", Namespace = "http://www.isotc211.org/2005/srv")]
    public class OperatesOn
    {
        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
    }

    [XmlRoot(ElementName = "SV_ServiceIdentification", Namespace = "http://www.isotc211.org/2005/srv")]
    public class SV_ServiceIdentification
    {
        [XmlElement(ElementName = "serviceType", Namespace = "http://www.isotc211.org/2005/srv")]
        public ServiceType ServiceType { get; set; }
        [XmlElement(ElementName = "citation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Citation Citation { get; set; }
        [XmlElement(ElementName = "abstract", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Abstract Abstract { get; set; }
        [XmlElement(ElementName = "topicCategory", Namespace = "http://www.isotc211.org/2005/gmd")]
        public TopicCategory TopicCategory { get; set; }
        [XmlElement(ElementName = "spatialRepresentationType", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SpatialRepresentationType SpatialRepresentationType { get; set; }
        [XmlElement(ElementName = "descriptiveKeywords", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<DescriptiveKeywords> DescriptiveKeywords { get; set; }
        [XmlElement(ElementName = "geographicElement", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<GeographicElement> GeographicElement { get; set; }
        [XmlElement(ElementName = "extent", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Extent Extent { get; set; }
        [XmlElement(ElementName = "spatialResolution", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SpatialResolution SpatialResolution { get; set; }
        [XmlElement(ElementName = "supplementalInformation", Namespace = "http://www.isotc211.org/2005/gmd")]
        public SupplementalInformation SupplementalInformation { get; set; }
        [XmlElement(ElementName = "resourceConstraints", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<ResourceConstraints> ResourceConstraints { get; set; }
        [XmlElement(ElementName = "pointOfContact", Namespace = "http://www.isotc211.org/2005/gmd")]
        public List<PointOfContact> PointOfContact { get; set; }
        [XmlElement(ElementName = "resourceMaintenance", Namespace = "http://www.isotc211.org/2005/gmd")]
        public ResourceMaintenance ResourceMaintenance { get; set; }
        [XmlElement(ElementName = "operatesOn", Namespace = "http://www.isotc211.org/2005/srv")]
        public OperatesOn OperatesOn { get; set; }
    }

    [XmlRoot(ElementName = "other", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Other
    {
        [XmlElement(ElementName = "CharacterString", Namespace = "http://www.isotc211.org/2005/gco")]
        public string CharacterString { get; set; }
    }

    [XmlRoot(ElementName = "MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_ScopeDescription
    {
        [XmlElement(ElementName = "other", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Other Other { get; set; }
    }

    [XmlRoot(ElementName = "levelDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class LevelDescription
    {
        [XmlElement(ElementName = "MD_ScopeDescription", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_ScopeDescription MD_ScopeDescription { get; set; }
    }

    [XmlRoot(ElementName = "denominator", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class Denominator
    {
        [XmlElement(ElementName = "Integer", Namespace = "http://www.isotc211.org/2005/gco")]
        public string Integer { get; set; }
    }

    [XmlRoot(ElementName = "MD_RepresentativeFraction", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class MD_RepresentativeFraction
    {
        [XmlElement(ElementName = "denominator", Namespace = "http://www.isotc211.org/2005/gmd")]
        public Denominator Denominator { get; set; }
    }

    [XmlRoot(ElementName = "equivalentScale", Namespace = "http://www.isotc211.org/2005/gmd")]
    public class EquivalentScale
    {
        [XmlElement(ElementName = "MD_RepresentativeFraction", Namespace = "http://www.isotc211.org/2005/gmd")]
        public MD_RepresentativeFraction MD_RepresentativeFraction { get; set; }
    }
 }