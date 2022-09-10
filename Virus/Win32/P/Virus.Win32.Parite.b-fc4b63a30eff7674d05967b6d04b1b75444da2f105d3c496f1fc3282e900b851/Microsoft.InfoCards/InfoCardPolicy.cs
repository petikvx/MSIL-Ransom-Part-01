using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Xml;
using System.Xml.Schema;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardPolicy
{
	private static XmlNamespaceManager m_defNamespaces = XmlNames.CreateNamespaceManager(new NameTable());

	private EndpointAddress m_issuer;

	private string m_privacyPolicyLink = string.Empty;

	private uint m_privacyPolicyVersion;

	private bool m_isManaged;

	private bool m_requiresManagedCard;

	private RecipientIdentity m_immediateTokenRecipientIdentity;

	private RecipientIdentity m_recipientIdentity;

	private Policy m_policyPrimary;

	private Policy m_policySecondary;

	private Policy m_policyMerged;

	private readonly PolicyUsageContext m_policyUsageContext;

	public Policy MergedPolicy => m_policyMerged;

	public string RequestType => m_policyMerged.RequestType;

	public Policy ClientPolicy => m_policyPrimary;

	public Policy RelyingPartyPolicy => m_policySecondary;

	public OptionalRstParameters OptionalRstParams => m_policyMerged.OptionalRstParams;

	public string[] RequiredClaims => m_policyMerged.RequiredClaims;

	public string[] OptionalClaims => m_policyMerged.OptionalClaims;

	public SecurityKeyTypeInternal KeyType => m_policyMerged.KeyType;

	public bool KeyTypeSpecified => m_policyMerged.KeyTypeSpecified;

	public EndpointAddress PolicyAppliesTo => m_policyMerged.PolicyAppliesTo;

	public MemoryStream UnprocessedPolicyElements => m_policyMerged.UnprocessedPolicyElements;

	public bool KeySizeSpecified => m_policyMerged.KeySizeSpecified;

	public uint KeySize => m_policyMerged.KeySize;

	public bool NonWhiteListElementsFound => m_policyMerged.NonWhiteListElementsFound;

	public List<string> NonWhiteListElements => m_policyMerged.NonWhiteListElements;

	public ProtocolProfile ProtocolVersionProfile => m_policyMerged.ProtocolVersionProfile;

	public RecipientIdentity ImmediateTokenRecipient => m_immediateTokenRecipientIdentity;

	public EndpointAddress Issuer => m_issuer;

	public RecipientIdentity Recipient => m_recipientIdentity;

	public string PrivacyPolicyLink => m_privacyPolicyLink;

	public uint PrivacyPolicyVersion => m_privacyPolicyVersion;

	public bool IsManaged => m_isManaged;

	public bool RequiresManagedCard => m_requiresManagedCard;

	public bool RequiresSelfIssuedCard
	{
		get
		{
			if ((EndpointAddress)null == m_issuer)
			{
				return false;
			}
			return Utility.CompareUri(m_issuer.get_Uri(), new Uri("http://schemas.xmlsoap.org/ws/2005/05/identity/issuer/self"));
		}
	}

	public InfoCardPolicy(EndpointAddress immediateTokenRecipient, EndpointAddress issuer, ParsedPolicy policy, PolicyUsageContext policyUsageContext, string privacyUrl, uint privacyVersion, RecipientIdentity recipientIdentity, bool isManaged)
	{
		m_policyUsageContext = policyUsageContext;
		m_issuer = issuer;
		m_recipientIdentity = recipientIdentity;
		m_immediateTokenRecipientIdentity = RecipientIdentity.CreateIdentity(immediateTokenRecipient, validate: false);
		m_isManaged = isManaged;
		if (policy != null)
		{
			ParseIncomingPolicy(policy);
		}
		if (!IsSelfIssuedUriPresent(m_issuer) && issuer != (EndpointAddress)null && !Utility.CompareUri(issuer.get_Uri(), new Uri("http://schemas.microsoft.com/2005/12/ServiceModel/Addressing/Anonymous")))
		{
			m_requiresManagedCard = true;
		}
		m_privacyPolicyLink = privacyUrl;
		m_privacyPolicyVersion = privacyVersion;
	}

	private void ParseIncomingPolicy(ParsedPolicy parsedPolicy)
	{
		if (PolicyType.Composite == parsedPolicy.PolicyType)
		{
			try
			{
				m_policyPrimary = PolicyFactory.CreatePolicyFromUnwrappedPolicyXml(parsedPolicy.PolicyXmlPrimary);
				m_policySecondary = PolicyFactory.CreatePolicyFromUnwrappedPolicyXml(parsedPolicy.PolicyXmlSecondary);
				m_policyMerged = Policy.CreateMergedPolicy(parsedPolicy.PolicyXmlOriginal, m_policyPrimary, m_policySecondary);
				return;
			}
			catch (XmlSchemaValidationException inner)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("SchemaValidationFailed"), inner));
			}
		}
		if (parsedPolicy.PolicyType == PolicyType.PrimaryOnly)
		{
			try
			{
				m_policyPrimary = PolicyFactory.CreatePolicyFromUnwrappedPolicyXml(parsedPolicy.PolicyXmlPrimary);
				m_policyMerged = m_policyPrimary;
				return;
			}
			catch (XmlSchemaValidationException inner2)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("SchemaValidationFailed"), inner2));
			}
		}
		if (PolicyType.SecondaryOnly == parsedPolicy.PolicyType)
		{
			try
			{
				m_policySecondary = PolicyFactory.CreatePolicyFromUnwrappedPolicyXml(parsedPolicy.PolicyXmlSecondary);
				m_policyMerged = m_policySecondary;
			}
			catch (XmlSchemaValidationException inner3)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("SchemaValidationFailed"), inner3));
			}
		}
	}

	public uint GetIntelligentKeySize(bool isSelfIssuedCardSelected)
	{
		if (isSelfIssuedCardSelected)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException());
		}
		if (SecurityKeyTypeInternal.AsymmetricKey == KeyType)
		{
			return 2048u;
		}
		if (KeyType == SecurityKeyTypeInternal.SymmetricKey)
		{
			if (!KeySizeSpecified)
			{
				return (uint)SecurityAlgorithmSuite.get_Default().get_DefaultSymmetricKeyLength();
			}
			return KeySize;
		}
		InfoCardTrace.Assert(false, "Should access this property only in managed card non-no proof key scenario", new object[0]);
		throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException());
	}

	public string GetKeyTypeString()
	{
		switch (KeyType)
		{
		default:
			InfoCardTrace.Assert(false, "Impossible condition in code", new object[0]);
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException());
		case SecurityKeyTypeInternal.SymmetricKey:
			return m_policyMerged.ProtocolVersionProfile.WSTrust.KeyTypeSymmetric.ToString();
		case SecurityKeyTypeInternal.AsymmetricKey:
			return m_policyMerged.ProtocolVersionProfile.WSTrust.KeyTypeAsymmetric.ToString();
		case SecurityKeyTypeInternal.NoKey:
			return m_policyMerged.ProtocolVersionProfile.WSTrust.KeyTypeBearer.ToString();
		}
	}

	public void SetRecipientInfo(RecipientIdentity recipientIdentity, string privacyUrl, uint privacyVersion)
	{
		m_recipientIdentity = recipientIdentity;
		m_privacyPolicyLink = privacyUrl;
		m_privacyPolicyVersion = privacyVersion;
	}

	private void ComputeRequiresManagedCardFlag()
	{
		if (m_policyMerged.NonWhiteListElementsFound)
		{
			m_requiresManagedCard = true;
		}
		string[] requiredClaims = m_policyMerged.RequiredClaims;
		foreach (string claimType in requiredClaims)
		{
			if (!PolicyUtility.IsSelfIssuedClaim(claimType))
			{
				m_requiresManagedCard = true;
			}
		}
		if (!string.IsNullOrEmpty(m_policyMerged.OptionalRstParams.TokenType) && !PolicyUtility.IsSelfIssuedTokenType(m_policyMerged.OptionalRstParams.TokenType))
		{
			m_requiresManagedCard = true;
		}
		if (!(m_immediateTokenRecipientIdentity is X509RecipientIdentity) && m_policyMerged.KeyType == SecurityKeyTypeInternal.SymmetricKey)
		{
			m_requiresManagedCard = true;
		}
		if (!string.IsNullOrEmpty(m_policyMerged.OptionalRstParams.KeyWrapAlgorithm) && m_policyMerged.OptionalRstParams.KeyWrapAlgorithm != SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm())
		{
			m_requiresManagedCard = true;
		}
	}

	private void FillComputedPolicy()
	{
		ComputeRequiresManagedCardFlag();
	}

	public void Validate()
	{
		bool flag = m_policyMerged.RequiredClaims == null || 0 == m_policyMerged.RequiredClaims.Length;
		PolicyValidator policyValidator = null;
		if (m_policyUsageContext == PolicyUsageContext.Browser)
		{
			if (flag)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("NoClaimsFoundInPolicy")));
			}
			FillComputedPolicy();
			policyValidator = new BrowserPolicyValidator(this);
		}
		else if (PolicyUsageContext.GetToken == m_policyUsageContext)
		{
			if (flag)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("NoClaimsFoundInPolicy")));
			}
			FillComputedPolicy();
			policyValidator = new PolicyValidator(this);
		}
		else
		{
			policyValidator = new IntermediatePolicyValidator(this);
		}
		policyValidator.Validate();
	}

	public void ThrowIfNonPpidClaimsPresent()
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(m_policyMerged.RequiredClaims == null || m_policyMerged.OptionalClaims == null, "claims");
		if (m_policyMerged.RequiredClaims.Length != 1 || !(m_policyMerged.RequiredClaims[0] == InfoCardConstants.PPIDClaimsUri) || m_policyMerged.OptionalClaims.Length != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("IPStsPolicyRequestingNonPpidClaims")));
		}
	}

	public static bool IsSelfIssuedUriPresent(EndpointAddress address)
	{
		if ((EndpointAddress)null == address)
		{
			return false;
		}
		if (Utility.CompareUri(address.get_Uri(), XmlNames.WSIdentity.SelfIssuerUriValue))
		{
			return true;
		}
		return false;
	}
}
