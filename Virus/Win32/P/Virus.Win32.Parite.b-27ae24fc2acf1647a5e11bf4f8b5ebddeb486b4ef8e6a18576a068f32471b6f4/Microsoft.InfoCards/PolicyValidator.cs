using System;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class PolicyValidator
{
	private InfoCardPolicy m_policy;

	public PolicyValidator(InfoCardPolicy policy)
	{
		InfoCardTrace.Assert(null != policy, "PolicyValidator: policy cannot be null.", new object[0]);
		m_policy = policy;
	}

	public virtual void Validate()
	{
		ValidateClaims();
		ValidateNonWhiteListElements();
		ValidateRequestType();
		ValidateTokenType();
		ValidateKeySize();
		ValidatePrivacyVersion();
		ValidateKeyTypeSpecified();
		ValidateKeyType();
		ValidateKeyWrapAlgorithm();
		ValidateAppliesTo();
		ValidateRecipients();
	}

	protected void ValidateClaims()
	{
		string[] requiredClaims = m_policy.RequiredClaims;
		if (requiredClaims != null && requiredClaims.Length != 0)
		{
			string[] requiredClaims2 = m_policy.RequiredClaims;
			foreach (string claimType in requiredClaims2)
			{
				if (!PolicyUtility.IsSelfIssuedClaim(claimType))
				{
					string @string = SR.GetString("ServiceDoesNotSupportThisClaim");
					ThrowIfSelfIssued((Exception)(object)new UnsupportedPolicyOptionsException(@string));
				}
			}
			return;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("NoClaimsFoundInPolicy")));
	}

	protected void ValidateNonWhiteListElements()
	{
		if (!m_policy.NonWhiteListElementsFound)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string nonWhiteListElement in m_policy.NonWhiteListElements)
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(nonWhiteListElement);
		}
		string @string = SR.GetString("ServiceUnsupportedPolicyElementFound", new object[1] { stringBuilder.ToString() });
		ThrowIfSelfIssued((Exception)(object)new UnsupportedPolicyOptionsException(@string));
	}

	protected void ValidateRequestType()
	{
		if (!string.IsNullOrEmpty(m_policy.RequestType) && m_policy.MergedPolicy.ProtocolVersionProfile.WSTrust.IssueRequestType != m_policy.RequestType)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new UnsupportedPolicyOptionsException(SR.GetString("OnlyIssueRequestTypeSupported", new object[2]
			{
				m_policy.RequestType,
				m_policy.MergedPolicy.ProtocolVersionProfile.WSTrust.IssueRequestType
			})));
		}
	}

	protected void ValidateTokenType()
	{
		if (!string.IsNullOrEmpty(m_policy.OptionalRstParams.TokenType) && !PolicyUtility.IsSelfIssuedTokenType(m_policy.OptionalRstParams.TokenType))
		{
			string @string = SR.GetString("ServiceDoesNotSupportThisTokenType");
			ThrowIfSelfIssued((Exception)(object)new UnsupportedPolicyOptionsException(@string));
		}
	}

	protected void ValidateKeySize()
	{
		if (SecurityKeyTypeInternal.AsymmetricKey == m_policy.KeyType && m_policy.KeySizeSpecified && 2048 != m_policy.KeySize)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new UnsupportedPolicyOptionsException(SR.GetString("ServiceInvalidAsymmetricKeySize")));
		}
	}

	protected void ValidatePrivacyVersion()
	{
		if ((m_policy.PrivacyPolicyVersion == 0 && !string.IsNullOrEmpty(m_policy.PrivacyPolicyLink)) || (m_policy.PrivacyPolicyVersion != 0 && string.IsNullOrEmpty(m_policy.PrivacyPolicyLink)))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("ServiceInvalidPrivacyNoticeVersion")));
		}
	}

	protected void ValidateKeyTypeSpecified()
	{
		if (SecurityKeyTypeInternal.NoKey == m_policy.MergedPolicy.KeyType)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("NoProofKeyOnlyAllowedInBrowser", new object[1] { XmlNames.WSIdentity.NoProofKeyTypeValue })));
		}
	}

	protected void ValidateKeyType()
	{
		if (!(m_policy.ImmediateTokenRecipient is X509RecipientIdentity) && m_policy.KeyTypeSpecified && m_policy.KeyType == SecurityKeyTypeInternal.SymmetricKey)
		{
			string @string = SR.GetString("InvalidKeyOption");
			ThrowIfSelfIssued((Exception)(object)new UnsupportedPolicyOptionsException(@string));
		}
	}

	protected void ValidateKeyWrapAlgorithm()
	{
		if (!string.IsNullOrEmpty(m_policy.OptionalRstParams.KeyWrapAlgorithm) && m_policy.OptionalRstParams.KeyWrapAlgorithm != SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm())
		{
			string @string = SR.GetString("ServiceInvalidArguments");
			ThrowIfSelfIssued((Exception)(object)new UnsupportedPolicyOptionsException(@string));
		}
	}

	protected void ValidateRecipients()
	{
		m_policy.Recipient.Validate();
		m_policy.ImmediateTokenRecipient.Validate();
	}

	protected void ValidateAppliesTo()
	{
		if ((EndpointAddress)null == m_policy.MergedPolicy.PolicyAppliesTo)
		{
			return;
		}
		if (Uri.Compare(m_policy.MergedPolicy.PolicyAppliesTo.get_Uri(), m_policy.ImmediateTokenRecipient.Address.get_Uri(), UriComponents.SchemeAndServer, UriFormat.UriEscaped, StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidAppliesToInPolicy", new object[1] { SR.GetString("RecipientNotFromSameSecurityDomain") })));
		}
		string components = m_policy.MergedPolicy.PolicyAppliesTo.get_Uri().GetComponents(UriComponents.Path, UriFormat.UriEscaped);
		string components2 = m_policy.ImmediateTokenRecipient.Address.get_Uri().GetComponents(UriComponents.Path, UriFormat.UriEscaped);
		if (!string.IsNullOrEmpty(components))
		{
			if (string.IsNullOrEmpty(components2))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidAppliesToInPolicy", new object[1] { SR.GetString("RecipientNotFromSameSecurityDomain") })));
			}
			components = components.ToLowerInvariant();
			components2 = components2.ToLowerInvariant();
			if (!components2.StartsWith(components, StringComparison.OrdinalIgnoreCase))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new PolicyValidationException(SR.GetString("InvalidAppliesToInPolicy", new object[1] { SR.GetString("RecipientNotFromSameSecurityDomain") })));
			}
		}
	}

	private void ThrowIfSelfIssued(Exception e)
	{
		if (InfoCardPolicy.IsSelfIssuedUriPresent(m_policy.Issuer))
		{
			throw InfoCardTrace.ThrowHelperError(e);
		}
	}
}
