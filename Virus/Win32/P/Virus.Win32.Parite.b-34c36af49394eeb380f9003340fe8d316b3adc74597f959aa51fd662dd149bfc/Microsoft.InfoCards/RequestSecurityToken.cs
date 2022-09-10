using System;
using System.Globalization;
using System.Security.Cryptography.Xml;
using System.ServiceModel.Channels;
using System.ServiceModel.Security.Tokens;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class RequestSecurityToken : BodyWriter
{
	protected RequestSecurityTokenParameters m_rstParams;

	protected RequestSecurityTokenSerializer m_serializer;

	protected XmlDictionaryWriter m_xmlWriter;

	protected ProtocolProfile ProtocolVersionProfile => m_rstParams.Profile;

	protected InfoCardPolicy Policy => m_rstParams.Policy;

	protected RequestSecurityTokenSerializer Serializer
	{
		get
		{
			return m_serializer;
		}
		set
		{
			m_serializer = value;
		}
	}

	protected XmlDictionaryWriter Writer
	{
		get
		{
			return m_xmlWriter;
		}
		set
		{
			m_xmlWriter = value;
		}
	}

	protected string WstPrefix => ProtocolVersionProfile.WSTrust.DefaultPrefix;

	public RequestSecurityToken(RequestSecurityTokenParameters rstParams)
		: base(false)
	{
		m_rstParams = rstParams;
	}

	protected virtual void WriteRSTOpeningElement()
	{
		((XmlWriter)(object)Writer).WriteStartElement(WstPrefix, ProtocolVersionProfile.WSTrust.RequestSecurityToken, ProtocolVersionProfile.WSTrust.Namespace);
		((XmlWriter)(object)Writer).WriteAttributeString(ProtocolVersionProfile.WSTrust.Context, (string?)null, m_rstParams.Context);
	}

	protected virtual void WriteInfoCardReferenceElement()
	{
		if (m_rstParams.Card != null)
		{
			Serializer.WriteInfoCardReferenceElement(m_rstParams.Card);
		}
	}

	protected virtual void WriteKeyTypeElement()
	{
		Serializer.WriteKeyTypeElement(Policy.GetKeyTypeString());
	}

	protected virtual void WriteKeySupportingElements()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (Policy.KeyType == SecurityKeyTypeInternal.SymmetricKey)
		{
			Serializer.WriteKeySizeElement(Policy.GetIntelligentKeySize(isSelfIssuedCardSelected: false).ToString(CultureInfo.InvariantCulture));
			InfoCardTrace.Assert(null != m_rstParams.ClientEntropyForSymmetric, "Should not be null", new object[0]);
			BinarySecretSecurityToken bst = new BinarySecretSecurityToken(m_rstParams.ClientEntropyForSymmetric);
			Serializer.WriteBinarySecretElement(bst);
			if (!string.IsNullOrEmpty(Policy.OptionalRstParams.EncryptWith))
			{
				Serializer.WriteEncryptWithElement(Policy.OptionalRstParams.EncryptWith);
			}
			if (!string.IsNullOrEmpty(Policy.OptionalRstParams.SignWith))
			{
				Serializer.WriteSignWithElement(Policy.OptionalRstParams.SignWith);
			}
		}
		else if (SecurityKeyTypeInternal.AsymmetricKey == Policy.KeyType)
		{
			if (XmlNames.WSSpecificationVersion.WSTrustOasis2007 == ProtocolVersionProfile.WSTrust.Version && !string.IsNullOrEmpty(Policy.OptionalRstParams.KeyWrapAlgorithm))
			{
				Serializer.WriteKeyWrapAlgorithmElement(Policy.OptionalRstParams.KeyWrapAlgorithm);
			}
			Serializer.WriteKeySizeElement(Policy.GetIntelligentKeySize(isSelfIssuedCardSelected: false).ToString(CultureInfo.InvariantCulture));
			InfoCardTrace.Assert(null != m_rstParams.RSAKey, "Should have been populated in asymmetric case", new object[0]);
			Serializer.WriteUseKeyElement(((KeyInfoClause)m_rstParams.RSAKey).GetXml());
			if (!string.IsNullOrEmpty(Policy.OptionalRstParams.EncryptWith))
			{
				Serializer.WriteEncryptWithElement(Policy.OptionalRstParams.EncryptWith);
			}
			if (!string.IsNullOrEmpty(Policy.OptionalRstParams.SignWith))
			{
				Serializer.WriteSignWithElement(Policy.OptionalRstParams.SignWith);
			}
		}
		else
		{
			InfoCardTrace.Assert(SecurityKeyTypeInternal.NoKey == Policy.KeyType, "Should be no proof key", new object[0]);
		}
	}

	protected virtual void WriteRequestTypeElement()
	{
		if (!string.IsNullOrEmpty(Policy.RequestType))
		{
			Serializer.WriteRequestTypeElement(Policy.RequestType);
		}
		else
		{
			Serializer.WriteRequestTypeElement(ProtocolVersionProfile.WSTrust.IssueRequestType);
		}
	}

	protected virtual void WritePPIDElement()
	{
		if (m_rstParams.Card != null && m_rstParams.Card.GetClaims().ContainsKey(InfoCardConstants.PPIDClaimsUri))
		{
			byte[] ppid = Utility.CreateHash(m_rstParams.Card.Key, Convert.FromBase64String(Policy.ImmediateTokenRecipient.GetOrganizationPPIDIdentifier()), m_rstParams.Card.HashSalt);
			Serializer.WritePPIDElement(ppid);
		}
	}

	protected virtual void WriteEncryptionAlgorithmElement()
	{
		if (!string.IsNullOrEmpty(Policy.OptionalRstParams.EncryptionAlgorithm))
		{
			Serializer.WriteEncryptionAlgorithmElement(Policy.OptionalRstParams.EncryptionAlgorithm);
		}
	}

	protected virtual void WriteClaimsElement()
	{
		Serializer.WriteClaimsElement(m_rstParams.DisclosedClaims, Policy.RequiredClaims, Policy.OptionalClaims);
	}

	protected virtual void WriteDisplayTokenElement()
	{
		if (m_rstParams.Culture != null)
		{
			Serializer.WriteDisplayTokenElement(m_rstParams.Culture);
		}
	}

	protected virtual void WriteTokenTypeElement()
	{
		if (!string.IsNullOrEmpty(Policy.OptionalRstParams.TokenType))
		{
			Serializer.WriteTokenTypeElement(Policy.OptionalRstParams.TokenType);
		}
	}

	protected virtual void WritePassOnElements()
	{
		Policy.OptionalRstParams.WritePassOnElements(Writer, ProtocolVersionProfile);
	}

	protected virtual void WriteUnprocessedPolicyElements()
	{
		if (Policy.UnprocessedPolicyElements != null && Policy.UnprocessedPolicyElements.Length > 0L)
		{
			Serializer.WriteUnprocessedPolicyElements(Policy.UnprocessedPolicyElements);
		}
	}

	protected abstract void WriteSecondaryParametersElement();

	protected virtual void WriteEndElement()
	{
		((XmlWriter)(object)Writer).WriteEndElement();
	}

	protected abstract void WriteAppliesToElement();

	protected virtual void InitializeWriters(XmlDictionaryWriter writer)
	{
		Writer = writer;
		Serializer = new RequestSecurityTokenSerializer((XmlWriter)(object)writer, ProtocolVersionProfile);
	}

	protected override void OnWriteBodyContents(XmlDictionaryWriter writer)
	{
		CustomWriteBodyContents(writer);
	}

	protected abstract void CustomWriteBodyContents(XmlDictionaryWriter writer);
}
