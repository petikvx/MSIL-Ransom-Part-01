using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security.Tokens;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RequestSecurityTokenSerializer
{
	private XmlWriter m_writer;

	private ProtocolProfile m_profile;

	public XmlWriter Writer => m_writer;

	public ProtocolProfile Profile => m_profile;

	private XmlNames.IWSTrust WSTrust => Profile.WSTrust;

	private XmlNames.IWSPolicy WSPolicy => Profile.WSPolicy;

	private string WSTPrefix => Profile.WSTrust.DefaultPrefix;

	private string WSIPrefix => "wsid";

	private string WSPPrefix => Profile.WSPolicy.DefaultPrefix;

	private string DSIGPrefix => "dsig";

	public RequestSecurityTokenSerializer(XmlWriter writer, ProtocolProfile profile)
	{
		m_writer = writer;
		m_profile = profile;
	}

	public void WriteClaimElement(string claimUri, bool bIsOptionalClaim)
	{
		Writer.WriteStartElement(WSIPrefix, "ClaimType", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteAttributeString("Uri", claimUri);
		if (bIsOptionalClaim)
		{
			Writer.WriteAttributeString("Optional", "true");
		}
		Writer.WriteEndElement();
	}

	public void WriteClaimsElement(Dictionary<string, bool> disclosedClaims, string[] requiredClaims, string[] optionalClaims)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.ClaimsElement, WSTrust.Namespace);
		Writer.WriteAttributeString(WSTrust.Dialect, "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (disclosedClaims != null)
		{
			foreach (KeyValuePair<string, bool> disclosedClaim in disclosedClaims)
			{
				WriteClaimElement(disclosedClaim.Key, disclosedClaim.Value);
			}
		}
		else
		{
			foreach (string claimUri in requiredClaims)
			{
				WriteClaimElement(claimUri, bIsOptionalClaim: false);
			}
			foreach (string claimUri2 in optionalClaims)
			{
				WriteClaimElement(claimUri2, bIsOptionalClaim: true);
			}
		}
		Writer.WriteEndElement();
	}

	public void WriteRequestTypeElement(string requestType)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.RequestType, WSTrust.Namespace);
		Writer.WriteString(requestType);
		Writer.WriteEndElement();
	}

	public void WritePPIDElement(byte[] ppid)
	{
		Writer.WriteStartElement("ClientPseudonym", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteStartElement("PPID", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteBase64(ppid, 0, ppid.Length);
		Writer.WriteEndElement();
		Writer.WriteEndElement();
	}

	public void WriteAppliesToElement(EndpointAddress address, AddressingVersion version)
	{
		Writer.WriteStartElement(WSPPrefix, WSPolicy.AppliesTo, WSPolicy.Namespace);
		address.WriteTo(version, Writer);
		Writer.WriteEndElement();
	}

	public void WriteKeySizeElement(string keySize)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.KeySize, WSTrust.Namespace);
		Writer.WriteString(keySize);
		Writer.WriteEndElement();
	}

	public void WriteKeyTypeElement(string keyType)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.KeyType, WSTrust.Namespace);
		Writer.WriteString(keyType);
		Writer.WriteEndElement();
	}

	public void WriteUseKeyElement(XmlElement useKey)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.UseKey, WSTrust.Namespace);
		Writer.WriteStartElement(DSIGPrefix, "KeyInfo", "http://www.w3.org/2000/09/xmldsig#");
		Writer.WriteStartElement(DSIGPrefix, "KeyValue", "http://www.w3.org/2000/09/xmldsig#");
		useKey.WriteContentTo(Writer);
		Writer.WriteEndElement();
		Writer.WriteEndElement();
		Writer.WriteEndElement();
	}

	public void WriteBinarySecretElement(BinarySecretSecurityToken bst)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.Entropy, WSTrust.Namespace);
		((SecurityTokenSerializer)Profile.TokenSerializer).WriteToken(Writer, (SecurityToken)(object)bst);
		Writer.WriteEndElement();
	}

	public void WriteInfoCardReferenceElement(InfoCard card)
	{
		Writer.WriteStartElement(WSIPrefix, "InformationCardReference", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteStartElement(WSIPrefix, "CardId", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteString(card.Id.ToString());
		Writer.WriteEndElement();
		Writer.WriteStartElement(WSIPrefix, "CardVersion", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteString(card.Epoch.ToString(CultureInfo.InvariantCulture));
		Writer.WriteEndElement();
		Writer.WriteEndElement();
	}

	public void WriteDisplayTokenElement(CultureInfo displayCulture)
	{
		Writer.WriteStartElement(WSIPrefix, "RequestDisplayToken", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		Writer.WriteAttributeString("xml", "lang", null, displayCulture.TwoLetterISOLanguageName);
		Writer.WriteEndElement();
	}

	public void WriteTokenTypeElement(string tokenType)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.TokenType, WSTrust.Namespace);
		Writer.WriteString(tokenType);
		Writer.WriteEndElement();
	}

	public void WriteEncryptionAlgorithmElement(string encryptionAlgorithm)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.EncryptionAlgorithm, WSTrust.Namespace);
		Writer.WriteString(encryptionAlgorithm);
		Writer.WriteEndElement();
	}

	public void WriteSignWithElement(string signWith)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.SignWith, WSTrust.Namespace);
		Writer.WriteString(signWith);
		Writer.WriteEndElement();
	}

	public void WriteEncryptWithElement(string encryptWith)
	{
		Writer.WriteStartElement(WSTPrefix, WSTrust.EncryptWith, WSTrust.Namespace);
		Writer.WriteString(encryptWith);
		Writer.WriteEndElement();
	}

	public void WriteKeyWrapAlgorithmElement(string keyWrapAlgorithm)
	{
		InfoCardTrace.Assert(WSTrust.Version == XmlNames.WSSpecificationVersion.WSTrustOasis2007, "KeyWrapAlgorithm element is valid in WS-Trust 1.3 only", new object[0]);
		Writer.WriteStartElement(WSTPrefix, WSTrust.KeyWrapAlgorithm, WSTrust.Namespace);
		Writer.WriteString(keyWrapAlgorithm);
		Writer.WriteEndElement();
	}

	public void WriteUnprocessedPolicyElements(MemoryStream unprocessedElements)
	{
		unprocessedElements.Seek(0L, SeekOrigin.Begin);
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.ConformanceLevel = ConformanceLevel.Fragment;
		XmlReader xmlReader = XmlReader.Create(unprocessedElements, xmlReaderSettings);
		while (!xmlReader.EOF)
		{
			Writer.WriteNode(xmlReader, defattr: true);
		}
	}

	public void WriteSecondaryParametersElement(string policyXml)
	{
		InfoCardTrace.Assert(WSTrust.Version == XmlNames.WSSpecificationVersion.WSTrustOasis2007, "SecondaryParameters element is valid in WS-Trust 1.3 only", new object[0]);
		Writer.WriteStartElement(WSTPrefix, WSTrust.SecondaryParameters, WSTrust.Namespace);
		StringReader input = new StringReader(policyXml);
		XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
		xmlReaderSettings.ConformanceLevel = ConformanceLevel.Fragment;
		XmlReader xmlReader = XmlReader.Create(input, xmlReaderSettings);
		while (!xmlReader.EOF)
		{
			Writer.WriteNode(xmlReader, defattr: true);
		}
		Writer.WriteEndElement();
	}
}
