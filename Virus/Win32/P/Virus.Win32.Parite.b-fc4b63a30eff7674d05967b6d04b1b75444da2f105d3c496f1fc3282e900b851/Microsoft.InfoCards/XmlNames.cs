using System;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class XmlNames
{
	internal sealed class Saml11
	{
		public const string DefaultPrefix = "saml";

		public const string Namespace = "urn:oasis:names:tc:SAML:1.0:assertion";

		public const string AltNamespace = "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLV1.1";

		private Saml11()
		{
		}
	}

	internal sealed class Saml10
	{
		public const string DefaultPrefix = "saml";

		public const string Namespace = "urn:oasis:names:tc:SAML:1.0:assertion";

		public const string Bearer = "urn:oasis:names:tc:SAML:1.0:cm:bearer";

		private Saml10()
		{
		}
	}

	internal sealed class Xml
	{
		public const string DefaultPrefix = "xml";

		public const string Namespace = "http://www.w3.org/XML/1998/namespace";

		public const string Language = "lang";

		public const string DateTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";

		private Xml()
		{
		}
	}

	internal sealed class XmlSchema
	{
		public const string DefaultPrefix = "xsd";

		public const string Namespace = "http://www.w3.org/2001/XMLSchema";

		public const string SchemaLocation = "http://www.w3.org/2001/xml.xsd";

		public const string LocalSchemaLocation = "xml.xsd";

		private XmlSchema()
		{
		}
	}

	internal sealed class WSAddressing
	{
		public const string DefaultPrefix = "wsa";

		public const string Namespace = "http://www.w3.org/2005/08/addressing";

		public const string SchemaLocation = "http://www.w3.org/2005/08/addressing/addressing.xsd";

		public const string LocalSchemaLocation = "addressing.xsd";

		public const string EndpointReference = "EndpointReference";

		public const string Address = "Address";

		private WSAddressing()
		{
		}
	}

	internal sealed class WSAddressing04
	{
		public const string DefaultPrefix = "wsa04";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2004/08/addressing";

		public const string SchemaLocation = "http://schemas.xmlsoap.org/ws/2004/08/addressing/";

		public const string LocalSchemaLocation = "addressing04.xsd";

		private WSAddressing04()
		{
		}
	}

	internal sealed class WSPolicy
	{
		public const string DefaultPrefix = "wsp";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2004/09/policy";

		public const string SchemaLocation = "http://schemas.xmlsoap.org/ws/2004/09/policy/ws-policy.xsd";

		public const string LocalSchemaLocation = "ws-policy.xsd";

		public const string Policy = "Policy";

		public const string AppliesTo = "AppliesTo";

		private WSPolicy()
		{
		}
	}

	internal enum WSSpecificationVersion
	{
		WSPolicyXmlSoap2004,
		WSPolicyW32007,
		WSTrustXmlSoap2005,
		WSTrustOasis2007,
		WSSecurityPolicyXmlSoap2005,
		WSSecurityPolicyOasis2007
	}

	internal interface IWSSpecification
	{
		WSSpecificationVersion Version { get; }
	}

	internal interface IWSPolicy : IWSSpecification
	{
		string DefaultPrefix { get; }

		string Namespace { get; }

		string SchemaLocation { get; }

		string LocalSchemaLocation { get; }

		string Policy { get; }

		string AppliesTo { get; }
	}

	internal sealed class WSPolicyXmlSoap2004 : IWSSpecification, IWSPolicy
	{
		public const string c_DefaultPrefix = "wsp2004";

		public const string c_Namespace = "http://schemas.xmlsoap.org/ws/2004/09/policy";

		public const string c_AppliesTo = "AppliesTo";

		public static WSPolicyXmlSoap2004 Instance = new WSPolicyXmlSoap2004();

		public WSSpecificationVersion Version => WSSpecificationVersion.WSPolicyXmlSoap2004;

		public string DefaultPrefix => "wsp2004";

		public string Namespace => "http://schemas.xmlsoap.org/ws/2004/09/policy";

		public string SchemaLocation => Namespace + "/ws-policy.xsd";

		public string LocalSchemaLocation => "ws-policy.xsd";

		public string Policy => "Policy";

		public string AppliesTo => "AppliesTo";

		private WSPolicyXmlSoap2004()
		{
		}
	}

	internal sealed class WSPolicyW32007 : IWSSpecification, IWSPolicy
	{
		public const string c_DefaultPrefix = "wsp2007";

		public const string c_Namespace = "http://www.w3.org/ns/ws-policy";

		public const string c_AppliesTo = "AppliesTo";

		public static WSPolicyW32007 Instance = new WSPolicyW32007();

		public WSSpecificationVersion Version => WSSpecificationVersion.WSPolicyW32007;

		public string DefaultPrefix => "wsp2007";

		public string Namespace => "http://www.w3.org/ns/ws-policy";

		public string SchemaLocation => "http://www.w3.org/2007/02/ws-policy.xsd";

		public string LocalSchemaLocation => "ws-policy-2007.xsd";

		public string Policy => "Policy";

		public string AppliesTo => "AppliesTo";

		private WSPolicyW32007()
		{
		}
	}

	internal sealed class XmlEnc
	{
		public const string DefaultPrefix = "enc";

		public const string Namespace = "http://www.w3.org/2001/04/xmlenc#";

		public const string EncryptedData = "EncryptedData";

		public const string EncryptionMethod = "EncryptionMethod";

		public const string EncryptionProperties = "EncryptionProperties";

		public const string CipherData = "CipherData";

		public const string CipherValue = "CipherValue";

		public const string Encoding = "Encoding";

		public const string MimeType = "MimeType";

		public const string Type = "Type";

		public const string Id = "Id";

		public const string Algorithm = "Algorithm";

		public const string LocalSchemaLocation = "xenc-schema.xsd";

		public const string SchemaLocation = "http://www.w3.org/TR/xmlenc-core/xenc-schema.xsd";

		private XmlEnc()
		{
		}
	}

	internal sealed class XmlDSig
	{
		public const string DefaultPrefix = "dsig";

		public const string Namespace = "http://www.w3.org/2000/09/xmldsig#";

		public const string SchemaLocation = "http://www.w3.org/TR/xmldsig-core/xmldsig-core-schema.xsd";

		public const string LocalSchemaLocation = "xmldsig-core-schema.xsd";

		public const string X509CertificateElement = "X509Certificate";

		public const string X509IssuerSerialElement = "X509IssuerSerial";

		public const string X509IssuerNameElement = "X509IssuerName";

		public const string X509SerialNumberElement = "X509SerialNumber";

		public const string X509DataElement = "X509Data";

		public const string RSAKeyValueElement = "RSAKeyValue";

		public const string Signature = "Signature";

		public const string KeyInfo = "KeyInfo";

		public const string KeyValue = "KeyValue";

		private XmlDSig()
		{
		}
	}

	internal sealed class WSSecurityPolicy
	{
		public const string DefaultPrefix = "sp";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2005/07/securitypolicy";

		public const string SchemaLocation = "http://schemas.xmlsoap.org/ws/2005/07/securitypolicy/ws-securitypolicy.xsd";

		public const string LocalSchemaLocation = "ws-securitypolicy.xsd";

		public const string RequestSecurityTokenTemplate = "RequestSecurityTokenTemplate";

		private WSSecurityPolicy()
		{
		}
	}

	internal interface IWSSecurityPolicy : IWSSpecification
	{
		string DefaultPrefix { get; }

		string Namespace { get; }

		string SchemaLocation { get; }

		string LocalSchemaLocation { get; }

		string RequestSecurityTokenTemplate { get; }
	}

	internal sealed class WSSecurityPolicyXmlSoap2005 : IWSSpecification, IWSSecurityPolicy
	{
		public const string c_Namespace = "http://schemas.xmlsoap.org/ws/2005/07/securitypolicy";

		public const string c_RequestSecurityTokenTemplate = "RequestSecurityTokenTemplate";

		public static WSSecurityPolicyXmlSoap2005 Instance = new WSSecurityPolicyXmlSoap2005();

		public WSSpecificationVersion Version => WSSpecificationVersion.WSSecurityPolicyXmlSoap2005;

		public string DefaultPrefix => "sp";

		public string Namespace => "http://schemas.xmlsoap.org/ws/2005/07/securitypolicy";

		public string SchemaLocation => "http://schemas.xmlsoap.org/ws/2005/07/securitypolicy/ws-securitypolicy.xsd";

		public string LocalSchemaLocation => "ws-securitypolicy.xsd";

		public string RequestSecurityTokenTemplate => "RequestSecurityTokenTemplate";

		private WSSecurityPolicyXmlSoap2005()
		{
		}
	}

	internal sealed class WSSecurityPolicyOasis2007 : IWSSpecification, IWSSecurityPolicy
	{
		public const string c_Namespace = "http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200512";

		public const string c_RequestSecurityTokenTemplate = "RequestSecurityTokenTemplate";

		public static WSSecurityPolicyOasis2007 Instance = new WSSecurityPolicyOasis2007();

		public WSSpecificationVersion Version => WSSpecificationVersion.WSSecurityPolicyOasis2007;

		public string DefaultPrefix => "sp";

		public string Namespace => "http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200512";

		public string SchemaLocation => "http://docs.oasis-open.org/ws-sx/ws-securitypolicy/200512/ws-securitypolicy-1.2.xsd";

		public string LocalSchemaLocation => "ws-securitypolicy-1.2.xsd";

		public string RequestSecurityTokenTemplate => "RequestSecurityTokenTemplate";

		private WSSecurityPolicyOasis2007()
		{
		}
	}

	internal sealed class WSSecurityUtility
	{
		public const string DefaultPrefix = "wssu";

		public const string Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";

		public const string SchemaLocation = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd";

		public const string LocalSchemaLocation = "oasis-200401-wss-wssecurity-utility-1.0.xsd";

		public const string Created = "Created";

		public const string Expires = "Expires";

		private WSSecurityUtility()
		{
		}
	}

	internal sealed class WSSecurityExt
	{
		public const string DefaultPrefix = "wsse";

		public const string Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

		public const string SchemaLocation = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd";

		public const string LocalSchemaLocation = "oasis-200401-wss-wssecurity-secext-1.0.xsd";

		public const string Sha1ThumbprintKeyTypeValue = "http://docs.oasis-open.org/wss/oasis-wss-soap-message-security-1.1#ThumbprintSHA1";

		public const string AltSha1ThumbprintKeyTypeValue = "http://docs.oasis-open.org/wss/2004/xx/oasis-2004xx-wss-soap-message-security-1.1#ThumbprintSHA1";

		public const string KeyIdentifierElement = "KeyIdentifier";

		public const string ValueTypeAttribute = "ValueType";

		private WSSecurityExt()
		{
		}
	}

	internal sealed class WSMetadataExchange
	{
		public const string DefaultPrefix = "wsmex";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2004/09/mex";

		public const string LocalSchemaLocation = "MetadataExchange.xsd";

		public const string SchemaLocation = "http://schemas.xmlsoap.org/ws/2004/09/mex/MetadataExchange.xsd";

		private WSMetadataExchange()
		{
		}
	}

	internal sealed class Soap11
	{
		public const string DefaultPrefix = "soap";

		public const string Namespace = "http://schemas.xmlsoap.org/soap/envelope/";

		private Soap11()
		{
		}
	}

	internal sealed class Soap12
	{
		public const string DefaultPrefix = "soap";

		public const string Namespace = "http://www.w3.org/2003/05/soap-envelope";

		private Soap12()
		{
		}
	}

	internal sealed class WSIdentity
	{
		public const string DefaultPrefix = "wsid";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity";

		public const string LocalSchemaLocation = "identity.xsd";

		public const string ClaimElement = "ClaimType";

		public const string SupportedClaimTypeElement = "SupportedClaimType";

		public const string ProvisionAtElement = "ProvisionAt";

		public const string RequestBrowserToken = "RequestBrowserToken";

		public const string Identity = "Identity";

		public const string DictionaryUri = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims";

		public const string SelfIssuerUri = "http://schemas.xmlsoap.org/ws/2005/05/identity/issuer/self";

		public const string AnonymousIssuerUri = "http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/Anonymous";

		public const string PersonalCategoryUri = "http://icardissuer.microsoft.com/categories/identitycard";

		public const string UserNamePasswordAuth = "http://schemas.xmlsoap.org/ws/2005/05/identity/A12nMethod/UsernamePassword";

		public const string KerberosV5Auth = "http://schemas.xmlsoap.org/ws/2005/05/identity/A12nMethod/KerberosV5";

		public const string X509V3SoftAuth = "http://schemas.xmlsoap.org/ws/2005/05/identity/A12nMethod/X509V3Soft";

		public const string X509V3SmartCardAuth = "http://schemas.xmlsoap.org/ws/2005/05/identity/A12nMethod/X509V3SmartCard";

		public const string SelfIssuedAuth = "http://schemas.xmlsoap.org/ws/2005/05/identity/A12nMethod/SelfIssuedToken";

		public const string RequestDisplayTokenElement = "RequestDisplayToken";

		public const string RequestedDisplayTokenElement = "RequestedDisplayToken";

		public const string DisplayTokenElement = "DisplayToken";

		public const string DisplayTokenTextElement = "DisplayTokenText";

		public const string DisplayClaimElement = "DisplayClaim";

		public const string DisplayTagElement = "DisplayTag";

		public const string DisplayValueElement = "DisplayValue";

		public const string DescriptionElement = "Description";

		public const string InfoCardElement = "InformationCard";

		public const string RoamingInfoCardElement = "RoamingInformationCard";

		public const string InfoCardRefElement = "InformationCardReference";

		public const string CardNameElement = "CardName";

		public const string CardImageElement = "CardImage";

		public const string CardIdElement = "CardId";

		public const string CardVersionElement = "CardVersion";

		public const string IssuerNameElement = "IssuerName";

		public const string IssuerElement = "Issuer";

		public const string IssuerUriElement = "IssuerUri";

		public const string TimeIssuedElement = "TimeIssued";

		public const string TimeExpiresElement = "TimeExpires";

		public const string SupportedClaimTypeListElement = "SupportedClaimTypeList";

		public const string SupportedTokenTypeListElement = "SupportedTokenTypeList";

		public const string RequirePinProtectionElement = "RequirePinProtection";

		public const string TokenServiceListElement = "TokenServiceList";

		public const string TokenServiceElement = "TokenService";

		public const string UserCredentialElement = "UserCredential";

		public const string DisplayCredentialHintElement = "DisplayCredentialHint";

		public const string UserNamePasswordCredentialElement = "UsernamePasswordCredential";

		public const string X509V3CredentialElement = "X509V3Credential";

		public const string KerberosV5CredentialElement = "KerberosV5Credential";

		public const string SelfIssuedCredentialElement = "SelfIssuedCredential";

		public const string RequireAppliesToElement = "RequireAppliesTo";

		public const string UserNameElement = "Username";

		public const string PrivatePersonalIdentifierElement = "PrivatePersonalIdentifier";

		public const string MaxTokenAgeElement = "MaxTokenAge";

		public const string OpaqueEndPointElement = "OpaqueEndpoint";

		public const string UriAttribute = "Uri";

		public const string OptionalAttribute = "Optional";

		public const string MimeTypeAttribute = "MimeType";

		public const string MethodAttribute = "Method";

		public const string PrivacyNoticeAtElement = "PrivacyNotice";

		public const string PrivacyNoticeVersionAttribute = "Version";

		public const string IsManagedElement = "IsManaged";

		public const string MasterKeyElement = "MasterKey";

		public const string PinDigestElement = "PinDigest";

		public const string HashSaltElement = "HashSalt";

		public const string TimeLastUpdatedElement = "TimeLastUpdated";

		public const string ClaimValueElement = "ClaimValue";

		public const string RoamingStoreElement = "RoamingStore";

		public const string IsSelfIssuedElement = "IsSelfIssued";

		public const string StoreSaltElement = "StoreSalt";

		public const string IssuerIdElement = "IssuerId";

		public const string IterationCountElement = "IterationCount";

		public const string EncryptedStoreElement = "EncryptedStore";

		public const string BackgroundColorElement = "BackgroundColor";

		public const string UserPrincipalNameElement = "UserPrincipalName";

		public const string InfoCardMetaDataElement = "InformationCardMetaData";

		public const string InfoCardPrivateDataElement = "InformationCardPrivateData";

		public const string ClaimValueListElement = "ClaimValueList";

		public const string ValueElement = "Value";

		public const string ThumbprintUri = "http://schemas.xmlsoap.org/ws/2005/05/identity/keyThumbprintSHA1";

		public const string ClientPseudonym = "ClientPseudonym";

		public const string PPID = "PPID";

		public const string FaultNamespace = "http://schemas.xmlsoap.org/ws/2005/05/identity/fault";

		public const string FaultRefreshRequired = "InformationCardRefreshRequired";

		public const string FaultMissingAppliesTo = "MissingAppliesTo";

		public const string FaultInvalidProofKey = "InvalidProofKey";

		public const string FaultUnknownReference = "UnknownInformationCardReference";

		public const string FaultRequiredClaims = "FailedRequiredClaims";

		public static readonly Uri SelfIssuerUriValue = new Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/issuer/self");

		public static readonly Uri AnonymousIssuerUriValue = new Uri("http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/Anonymous");

		public static readonly Uri NoProofKeyTypeValue = new Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/NoProofKey");

		private WSIdentity()
		{
		}
	}

	internal sealed class WSIdentity07
	{
		public const string DefaultPrefix = "wsid07";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2007/01/identity";

		public const string LocalSchemaLocation = "ws-identity-2007.xsd";

		public const string IssuerInformation = "IssuerInformation";

		public const string IssuerInformationEntry = "IssuerInformationEntry";

		public const string EntryName = "EntryName";

		public const string EntryValue = "EntryValue";

		public const string RequireStrongRPIdentity = "RequireStrongRecipientIdentity";

		private WSIdentity07()
		{
		}
	}

	internal sealed class WSTrust
	{
		public const string DefaultPrefix = "wst";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2005/02/trust";

		public const string SchemaLocation = "http://schemas.xmlsoap.org/ws/2005/02/trust/ws-trust.xsd";

		public const string LocalSchemaLocation = "ws-trust.xsd";

		public const string ClaimsElement = "Claims";

		public const string TokenType = "TokenType";

		public const string EncryptWith = "EncryptWith";

		public const string CustomToken = "customToken";

		public const string Context = "Context";

		public const string KeyType = "KeyType";

		public const string KeySize = "KeySize";

		public const string UseKey = "UseKey";

		public const string SigAttribute = "Sig";

		public const string RequestSecurityToken = "RequestSecurityToken";

		public const string RequestSecurityTokenAction = "http://schemas.xmlsoap.org/ws/2005/02/trust/RST/Issue";

		public const string RequestSecurityTokenResponseAction = "http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/Issue";

		public const string RequestedSecurityToken = "RequestedSecurityToken";

		public const string RequestedProofToken = "RequestedProofToken";

		public const string RequestSecurityTokenResponse = "RequestSecurityTokenResponse";

		public const string Lifetime = "Lifetime";

		public const string RequestedAttachedReference = "RequestedAttachedReference";

		public const string RequestedUnattachedReference = "RequestedUnattachedReference";

		public const string Entropy = "Entropy";

		public const string ComputedKey = "ComputedKey";

		public const string AuthenticationType = "AuthenticationType";

		public const string SignatureAlgorithm = "SignatureAlgorithm";

		public const string EncryptionAlgorithm = "EncryptionAlgorithm";

		public const string CanonicalizationAlgorithm = "CanonicalizationAlgorithm";

		public const string SignWith = "SignWith";

		public const string ComputedKeyAlgorithm = "http://schemas.xmlsoap.org/ws/2005/02/trust/CK/PSHA1";

		public const string RequestType = "RequestType";

		public const string IssueRequestType = "http://schemas.xmlsoap.org/ws/2005/02/trust/Issue";

		public static readonly Uri KeyTypeSymmetric = new Uri("http://schemas.xmlsoap.org/ws/2005/02/trust/SymmetricKey");

		public static readonly Uri KeyTypeAsymmetric = new Uri("http://schemas.xmlsoap.org/ws/2005/02/trust/PublicKey");

		private WSTrust()
		{
		}
	}

	internal interface IWSTrust : IWSSpecification
	{
		string DefaultPrefix { get; }

		string Namespace { get; }

		string SchemaLocation { get; }

		string LocalSchemaLocation { get; }

		string ClaimsElement { get; }

		string TokenType { get; }

		string EncryptWith { get; }

		string CustomToken { get; }

		string Context { get; }

		string KeyType { get; }

		string KeySize { get; }

		string UseKey { get; }

		string SigAttribute { get; }

		string RequestSecurityToken { get; }

		string RequestSecurityTokenAction { get; }

		string RequestSecurityTokenResponseAction { get; }

		string RequestedSecurityToken { get; }

		string RequestedProofToken { get; }

		string RequestSecurityTokenResponse { get; }

		string RequestSecurityTokenResponseCollection { get; }

		string Lifetime { get; }

		string RequestedAttachedReference { get; }

		string RequestedUnattachedReference { get; }

		string Entropy { get; }

		string ComputedKey { get; }

		string AuthenticationType { get; }

		string SignatureAlgorithm { get; }

		string EncryptionAlgorithm { get; }

		string CanonicalizationAlgorithm { get; }

		string SignWith { get; }

		string ComputedKeyAlgorithm { get; }

		string RequestType { get; }

		string IssueRequestType { get; }

		string SecondaryParameters { get; }

		string KeyWrapAlgorithm { get; }

		string Dialect { get; }

		Uri KeyTypeSymmetric { get; }

		Uri KeyTypeAsymmetric { get; }

		Uri KeyTypeBearer { get; }
	}

	internal sealed class WSTrustXmlSoap2005 : IWSSpecification, IWSTrust
	{
		public const string c_Namespace = "http://schemas.xmlsoap.org/ws/2005/02/trust";

		public const string c_RequestSecurityTokenAction = "http://schemas.xmlsoap.org/ws/2005/02/trust/RST/Issue";

		public const string c_RequestSecurityTokenResponseAction = "http://schemas.xmlsoap.org/ws/2005/02/trust/RSTR/Issue";

		public const string c_DefaultPrefix = "wst2005";

		public const string c_ClaimsElement = "Claims";

		public const string c_TokenType = "TokenType";

		public const string c_EncryptWith = "EncryptWith";

		public const string c_KeyType = "KeyType";

		public const string c_KeySize = "KeySize";

		public const string c_SignatureAlgorithm = "SignatureAlgorithm";

		public const string c_EncryptionAlgorithm = "EncryptionAlgorithm";

		public const string c_CanonicalizationAlgorithm = "CanonicalizationAlgorithm";

		public const string c_SignWith = "SignWith";

		public const string c_RequestType = "RequestType";

		public const string c_Dialect = "Dialect";

		public static WSTrustXmlSoap2005 Instance = new WSTrustXmlSoap2005();

		private static readonly Uri m_KeyTypeSymmetric = new Uri(Instance.Namespace + "/SymmetricKey");

		private static readonly Uri m_KeyTypeAsymmetric = new Uri(Instance.Namespace + "/PublicKey");

		public WSSpecificationVersion Version => WSSpecificationVersion.WSTrustXmlSoap2005;

		public string DefaultPrefix => "wst2005";

		public string Namespace => "http://schemas.xmlsoap.org/ws/2005/02/trust";

		public string SchemaLocation => Namespace + "/ws-trust.xsd";

		public string LocalSchemaLocation => "ws-trust.xsd";

		public string ClaimsElement => "Claims";

		public string TokenType => "TokenType";

		public string EncryptWith => "EncryptWith";

		public string CustomToken => "customToken";

		public string Context => "Context";

		public string KeyType => "KeyType";

		public string KeySize => "KeySize";

		public string UseKey => "UseKey";

		public string SigAttribute => "Sig";

		public string RequestSecurityToken => "RequestSecurityToken";

		public string RequestSecurityTokenAction => Namespace + "/RST/Issue";

		public string RequestSecurityTokenResponseAction => Namespace + "/RSTR/Issue";

		public string RequestedSecurityToken => "RequestedSecurityToken";

		public string RequestedProofToken => "RequestedProofToken";

		public string RequestSecurityTokenResponse => "RequestSecurityTokenResponse";

		public string RequestSecurityTokenResponseCollection
		{
			get
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new NotImplementedException());
			}
		}

		public string Lifetime => "Lifetime";

		public string RequestedAttachedReference => "RequestedAttachedReference";

		public string RequestedUnattachedReference => "RequestedUnattachedReference";

		public string Entropy => "Entropy";

		public string ComputedKey => "ComputedKey";

		public string AuthenticationType => "AuthenticationType";

		public string SignatureAlgorithm => "SignatureAlgorithm";

		public string EncryptionAlgorithm => "EncryptionAlgorithm";

		public string CanonicalizationAlgorithm => "CanonicalizationAlgorithm";

		public string SignWith => "SignWith";

		public string ComputedKeyAlgorithm => Namespace + "/CK/PSHA1";

		public string RequestType => "RequestType";

		public string IssueRequestType => Namespace + "/Issue";

		public string SecondaryParameters
		{
			get
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new NotImplementedException());
			}
		}

		public string KeyWrapAlgorithm
		{
			get
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new NotImplementedException());
			}
		}

		public string Dialect => "Dialect";

		public Uri KeyTypeSymmetric => m_KeyTypeSymmetric;

		public Uri KeyTypeAsymmetric => m_KeyTypeAsymmetric;

		public Uri KeyTypeBearer => WSIdentity.NoProofKeyTypeValue;

		private WSTrustXmlSoap2005()
		{
		}
	}

	internal sealed class WSTrustOasis2007 : IWSSpecification, IWSTrust
	{
		public const string c_Namespace = "http://docs.oasis-open.org/ws-sx/ws-trust/200512";

		public const string c_RequestSecurityTokenAction = "http://docs.oasis-open.org/ws-sx/ws-trust/200512/RST/Issue";

		public const string c_RequestSecurityTokenResponseAction = "http://docs.oasis-open.org/ws-sx/ws-trust/200512/RSTRC/IssueFinal";

		public const string c_DefaultPrefix = "wst";

		public const string c_ClaimsElement = "Claims";

		public const string c_TokenType = "TokenType";

		public const string c_EncryptWith = "EncryptWith";

		public const string c_KeyType = "KeyType";

		public const string c_KeySize = "KeySize";

		public const string c_SignatureAlgorithm = "SignatureAlgorithm";

		public const string c_EncryptionAlgorithm = "EncryptionAlgorithm";

		public const string c_CanonicalizationAlgorithm = "CanonicalizationAlgorithm";

		public const string c_SignWith = "SignWith";

		public const string c_RequestType = "RequestType";

		public const string c_SecondaryParameters = "SecondaryParameters";

		public const string c_KeyWrapAlgorithm = "KeyWrapAlgorithm";

		public const string c_Dialect = "Dialect";

		public static WSTrustOasis2007 Instance = new WSTrustOasis2007();

		private static readonly Uri m_KeyTypeSymmetric = new Uri(Instance.Namespace + "/SymmetricKey");

		private static readonly Uri m_KeyTypeAsymmetric = new Uri(Instance.Namespace + "/PublicKey");

		private static readonly Uri m_KeyTypeBearer = new Uri(Instance.Namespace + "/Bearer");

		public WSSpecificationVersion Version => WSSpecificationVersion.WSTrustOasis2007;

		public string DefaultPrefix => "wst";

		public string Namespace => "http://docs.oasis-open.org/ws-sx/ws-trust/200512";

		public string SchemaLocation => Namespace + "/ws-trust-1.3.xsd";

		public string LocalSchemaLocation => "ws-trust-1.3.xsd";

		public string ClaimsElement => "Claims";

		public string TokenType => "TokenType";

		public string EncryptWith => "EncryptWith";

		public string CustomToken => "customToken";

		public string Context => "Context";

		public string KeyType => "KeyType";

		public string KeySize => "KeySize";

		public string UseKey => "UseKey";

		public string SigAttribute => "Sig";

		public string RequestSecurityToken => "RequestSecurityToken";

		public string RequestSecurityTokenAction => Namespace + "/RST/Issue";

		public string RequestSecurityTokenResponseAction => Namespace + "/RSTRC/IssueFinal";

		public string RequestedSecurityToken => "RequestedSecurityToken";

		public string RequestedProofToken => "RequestedProofToken";

		public string RequestSecurityTokenResponse => "RequestSecurityTokenResponse";

		public string RequestSecurityTokenResponseCollection => "RequestSecurityTokenResponseCollection";

		public string Lifetime => "Lifetime";

		public string RequestedAttachedReference => "RequestedAttachedReference";

		public string RequestedUnattachedReference => "RequestedUnattachedReference";

		public string Entropy => "Entropy";

		public string ComputedKey => "ComputedKey";

		public string AuthenticationType => "AuthenticationType";

		public string SignatureAlgorithm => "SignatureAlgorithm";

		public string EncryptionAlgorithm => "EncryptionAlgorithm";

		public string CanonicalizationAlgorithm => "CanonicalizationAlgorithm";

		public string SignWith => "SignWith";

		public string ComputedKeyAlgorithm => Namespace + "/CK/PSHA1";

		public string RequestType => "RequestType";

		public string IssueRequestType => Namespace + "/Issue";

		public string SecondaryParameters => "SecondaryParameters";

		public string KeyWrapAlgorithm => "KeyWrapAlgorithm";

		public string Dialect => "Dialect";

		public Uri KeyTypeSymmetric => m_KeyTypeSymmetric;

		public Uri KeyTypeAsymmetric => m_KeyTypeAsymmetric;

		public Uri KeyTypeBearer => m_KeyTypeBearer;

		private WSTrustOasis2007()
		{
		}
	}

	internal sealed class WSTransfer
	{
		public const string DefaultPrefix = "wxf";

		public const string Namespace = "http://schemas.xmlsoap.org/ws/2004/09/transfer";

		public const string Create = "Create";

		public const string CreateAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/Create";

		public const string CreateResponseAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/CreateResponse";

		public const string Get = "Get";

		public const string GetAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/Get";

		public const string GetResponseAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/GetResponse";

		public const string Put = "Put";

		public const string PutAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/Put";

		public const string PutResponseAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/PutResponse";

		public const string Delete = "Delete";

		public const string DeleteAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/Delete";

		public const string DeleteResponseAction = "http://schemas.xmlsoap.org/ws/2004/09/transfer/DeleteResponse";

		public const string ResourceCreated = "ResourceCreated";

		public const string WSTransferContractName = "WS-Transfer";

		private WSTransfer()
		{
		}
	}

	private XmlNames()
	{
	}

	public static XmlNamespaceManager CreateNamespaceManager(XmlNameTable nameTable)
	{
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(nameTable);
		xmlNamespaceManager.AddNamespace("saml", "urn:oasis:names:tc:SAML:1.0:assertion");
		xmlNamespaceManager.AddNamespace("soap", "http://www.w3.org/2003/05/soap-envelope");
		xmlNamespaceManager.AddNamespace("wsa", "http://www.w3.org/2005/08/addressing");
		xmlNamespaceManager.AddNamespace("wsid", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		xmlNamespaceManager.AddNamespace("wsmex", "http://schemas.xmlsoap.org/ws/2004/09/mex");
		xmlNamespaceManager.AddNamespace("wsp", "http://schemas.xmlsoap.org/ws/2004/09/policy");
		xmlNamespaceManager.AddNamespace("wsse", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
		xmlNamespaceManager.AddNamespace("wssu", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd");
		xmlNamespaceManager.AddNamespace("wxf", "http://schemas.xmlsoap.org/ws/2004/09/transfer");
		xmlNamespaceManager.AddNamespace("wst", "http://schemas.xmlsoap.org/ws/2005/02/trust");
		xmlNamespaceManager.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
		xmlNamespaceManager.AddNamespace("enc", "http://www.w3.org/2001/04/xmlenc#");
		xmlNamespaceManager.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
		return xmlNamespaceManager;
	}
}
