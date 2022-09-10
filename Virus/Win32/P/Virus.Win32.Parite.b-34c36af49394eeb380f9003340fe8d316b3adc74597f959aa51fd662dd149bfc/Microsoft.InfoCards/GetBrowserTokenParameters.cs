using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;
using System.Xml;

namespace Microsoft.InfoCards;

internal class GetBrowserTokenParameters
{
	private GetBrowserTokenEndpoint m_recipient;

	private GetBrowserTokenEndpoint m_issuer;

	private Uri m_tokenType;

	private List<string> m_requiredClaims;

	private List<string> m_optionalClaims;

	private int m_flags;

	private uint m_privacyVersion;

	private Uri m_privacyUrl;

	public GetBrowserTokenEndpoint Recipient => m_recipient;

	public GetBrowserTokenEndpoint Issuer => m_issuer;

	public IList<string> RequiredClaims => m_requiredClaims.AsReadOnly();

	public IList<string> OptionalClaims => m_optionalClaims.AsReadOnly();

	public Uri PrivacyUrl => m_privacyUrl;

	public uint PrivacyVersion => m_privacyVersion;

	public GetBrowserTokenParameters()
	{
		m_recipient = new GetBrowserTokenEndpoint();
		m_issuer = new GetBrowserTokenEndpoint();
		m_requiredClaims = new List<string>();
		m_optionalClaims = new List<string>();
	}

	public void Load(BinaryReader reader, int paramVersion)
	{
		m_flags = paramVersion;
		m_recipient.Load(reader, paramVersion);
		m_issuer.Load(reader, paramVersion);
		string text = Utility.DeserializeString(reader);
		if (!string.IsNullOrEmpty(text))
		{
			m_tokenType = new Uri(text);
		}
		int num = reader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			m_requiredClaims.Add(Utility.DeserializeString(reader));
		}
		num = reader.ReadInt32();
		for (int j = 0; j < num; j++)
		{
			m_optionalClaims.Add(Utility.DeserializeString(reader));
		}
		m_privacyVersion = reader.ReadUInt32();
		string text2 = Utility.DeserializeString(reader);
		if (!string.IsNullOrEmpty(text2))
		{
			m_privacyUrl = new Uri(text2);
		}
		else
		{
			m_privacyUrl = null;
		}
	}

	public CardSpacePolicyElement CreatePolicyElement(ProtocolProfile protocolProfile)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		XmlDocument xmlDocument = new XmlDocument();
		XmlElement xmlElement = xmlDocument.CreateElement(protocolProfile.WSTrust.DefaultPrefix, protocolProfile.WSTrust.ClaimsElement, protocolProfile.WSTrust.Namespace);
		foreach (string requiredClaim in RequiredClaims)
		{
			xmlElement.AppendChild(CreateClaimElement(xmlDocument, requiredClaim, optional: false));
		}
		foreach (string optionalClaim in OptionalClaims)
		{
			xmlElement.AppendChild(CreateClaimElement(xmlDocument, optionalClaim, optional: true));
		}
		IssuedSecurityTokenParameters val = new IssuedSecurityTokenParameters();
		if (null != m_tokenType)
		{
			val.set_TokenType(m_tokenType.ToString());
		}
		val.get_AdditionalRequestParameters().Add(xmlElement);
		Collection<XmlElement> collection = val.CreateRequestParameters(protocolProfile.MsgSecurityVersion, (SecurityTokenSerializer)new WSSecurityTokenSerializer(protocolProfile.MsgSecurityVersion.get_SecurityVersion(), true, (SamlSerializer)null, (SecurityStateEncoder)null, (IEnumerable<Type>)null));
		foreach (XmlElement item in collection)
		{
			if (StringComparer.Ordinal.Equals(item.LocalName, protocolProfile.WSTrust.KeyType) && StringComparer.Ordinal.Equals(item.NamespaceURI, protocolProfile.WSTrust.Namespace))
			{
				item.RemoveAll();
				item.AppendChild(item.OwnerDocument.CreateTextNode(protocolProfile.WSTrust.KeyTypeBearer.OriginalString));
				break;
			}
		}
		return new CardSpacePolicyElement((m_recipient != null) ? m_recipient.CreateEndpointAddressXml() : null, (m_issuer != null) ? m_issuer.CreateEndpointAddressXml() : null, collection, m_privacyUrl, Convert.ToInt32(m_privacyVersion), false);
	}

	private static XmlElement CreateClaimElement(XmlDocument document, string claimUri, bool optional)
	{
		XmlElement xmlElement = document.CreateElement("wsid", "ClaimType", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		xmlElement.SetAttribute("Uri", claimUri);
		if (optional)
		{
			xmlElement.SetAttribute("Optional", "true");
		}
		return xmlElement;
	}
}
