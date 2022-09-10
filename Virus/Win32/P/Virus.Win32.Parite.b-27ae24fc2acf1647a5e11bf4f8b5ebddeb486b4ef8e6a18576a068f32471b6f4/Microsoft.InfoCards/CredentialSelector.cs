using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class CredentialSelector : IXmlSerializable
{
	private CredentialSelectorType m_type;

	private byte[] m_data;

	public CredentialSelectorType Type
	{
		get
		{
			return m_type;
		}
		set
		{
			m_type = value;
		}
	}

	public CredentialSelector()
	{
		m_type = CredentialSelectorType.InvalidSelector;
	}

	public bool IsComplete()
	{
		if (CredentialSelectorType.InvalidSelector != m_type && m_data != null)
		{
			return m_data.Length > 0;
		}
		return false;
	}

	public string GetStringWithoutNullTerminator()
	{
		if (m_data == null)
		{
			return null;
		}
		string @string = Encoding.Unicode.GetString(m_data);
		return @string.Substring(0, @string.Length - 1);
	}

	public byte[] GetBytes()
	{
		if (m_data == null)
		{
			return null;
		}
		byte[] array = new byte[m_data.Length];
		Array.Copy(m_data, 0, array, 0, m_data.Length);
		return array;
	}

	public void SetValue(string data)
	{
		m_data = Encoding.Unicode.GetBytes(data + "\0");
	}

	public void SetValue(byte[] data, int index, int length)
	{
		byte[] array = new byte[length];
		Array.Copy(data, index, array, 0, length);
		m_data = array;
	}

	public void Serialize(BinaryWriter writer)
	{
		writer.Write((int)m_type);
		Utility.SerializeBytes(writer, m_data);
	}

	public void Deserialize(BinaryReader reader)
	{
		m_type = (CredentialSelectorType)reader.ReadInt32();
		m_data = reader.ReadBytes(reader.ReadInt32());
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void WriteXml(XmlWriter writer)
	{
		switch (m_type)
		{
		case CredentialSelectorType.X509CertificateIssuerNameSelector:
			WriteX509CertificateIssuerNameSelector(writer);
			break;
		case CredentialSelectorType.X509CertificateIssuerSerialNoSelector:
			WriteX509CertificateIssuerSerialNoSelector(writer);
			break;
		case CredentialSelectorType.X509CertificateKeyHashSelector:
			WriteX509CertificateKeyHashSelector(writer);
			break;
		case CredentialSelectorType.UserNameSelector:
			WriteUserNameSelector(writer);
			break;
		case CredentialSelectorType.SelfIssuedCardIdSelector:
			WriteSelfIssuedCardIdSelector(writer);
			break;
		default:
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		case CredentialSelectorType.UserPrincipalNameSelector:
			WriteUserPrincipalNameSelector(writer);
			break;
		}
	}

	public void ReadXml(XmlReader reader)
	{
		switch (reader.LocalName)
		{
		case "Username":
			ReadUserNameSelector(reader);
			break;
		case "X509IssuerName":
			ReadX509IssuerNameSelector(reader);
			break;
		case "X509SerialNumber":
			ReadX509IssuerSerialNumberSelector(reader);
			break;
		case "KeyIdentifier":
			ReadX509KeyIdentifierSelector(reader);
			break;
		case "PrivatePersonalIdentifier":
			ReadSelfIssuedSelector(reader);
			break;
		default:
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		case "UserPrincipalName":
			ReadUserPrincipalNameSelector(reader);
			break;
		}
	}

	private void WriteUserNameSelector(XmlWriter writer)
	{
		writer.WriteStartElement("Username", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(GetStringWithoutNullTerminator());
		writer.WriteEndElement();
	}

	private void WriteUserPrincipalNameSelector(XmlWriter writer)
	{
		writer.WriteStartElement("UserPrincipalName", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteString(GetStringWithoutNullTerminator());
		writer.WriteEndElement();
	}

	private void WriteX509CertificateIssuerNameSelector(XmlWriter writer)
	{
		writer.WriteStartElement("X509IssuerName", "http://www.w3.org/2000/09/xmldsig#");
		string stringWithoutNullTerminator = GetStringWithoutNullTerminator();
		if (!string.IsNullOrEmpty(stringWithoutNullTerminator))
		{
			writer.WriteString(stringWithoutNullTerminator);
		}
		writer.WriteEndElement();
	}

	private void WriteX509CertificateIssuerSerialNoSelector(XmlWriter writer)
	{
		writer.WriteStartElement("X509SerialNumber", "http://www.w3.org/2000/09/xmldsig#");
		BigInt bigInt = new BigInt(GetBytes());
		writer.WriteString(bigInt.ToDecimal());
		writer.WriteEndElement();
	}

	private void WriteX509CertificateKeyHashSelector(XmlWriter writer)
	{
		writer.WriteStartElement("KeyIdentifier", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
		writer.WriteAttributeString("ValueType", null, "http://docs.oasis-open.org/wss/2004/xx/oasis-2004xx-wss-soap-message-security-1.1#ThumbprintSHA1");
		writer.WriteString(Convert.ToBase64String(GetBytes(), Base64FormattingOptions.None));
		writer.WriteEndElement();
	}

	private void WriteSelfIssuedCardIdSelector(XmlWriter writer)
	{
		writer.WriteStartElement("PrivatePersonalIdentifier", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		string stringWithoutNullTerminator = GetStringWithoutNullTerminator();
		if (!string.IsNullOrEmpty(stringWithoutNullTerminator))
		{
			writer.WriteString(stringWithoutNullTerminator);
		}
		writer.WriteEndElement();
	}

	private void ReadUserNameSelector(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional("Username" != reader.LocalName || "http://schemas.xmlsoap.org/ws/2005/05/identity" != reader.NamespaceURI, reader.LocalName);
		Type = CredentialSelectorType.UserNameSelector;
		string value = reader.ReadElementContentAsString().Trim();
		if (!string.IsNullOrEmpty(value))
		{
			SetValue(value);
		}
	}

	private void ReadUserPrincipalNameSelector(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional("UserPrincipalName" != reader.LocalName || "http://schemas.xmlsoap.org/ws/2005/05/identity" != reader.NamespaceURI, reader.LocalName);
		Type = CredentialSelectorType.UserPrincipalNameSelector;
	}

	private void ReadX509IssuerNameSelector(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional("X509IssuerName" != reader.LocalName || "http://www.w3.org/2000/09/xmldsig#" != reader.NamespaceURI, reader.LocalName);
		Type = CredentialSelectorType.X509CertificateIssuerNameSelector;
		string value = reader.ReadElementContentAsString().Trim();
		if (!string.IsNullOrEmpty(value))
		{
			SetValue(value);
		}
	}

	private void ReadX509IssuerSerialNumberSelector(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional("X509SerialNumber" != reader.LocalName || "http://www.w3.org/2000/09/xmldsig#" != reader.NamespaceURI, reader.LocalName);
		Type = CredentialSelectorType.X509CertificateIssuerSerialNoSelector;
		BigInt bigInt = new BigInt();
		string text = reader.ReadElementContentAsString().Trim();
		try
		{
			if (!string.IsNullOrEmpty(text))
			{
				bigInt.FromDecimal(text);
				byte[] array = bigInt.ToByteArray();
				SetValue(array, 0, array.Length);
			}
		}
		catch (FormatException)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidSerialNumber")));
		}
	}

	private void ReadX509KeyIdentifierSelector(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional("KeyIdentifier" != reader.LocalName || "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" != reader.NamespaceURI, reader.LocalName);
		Type = CredentialSelectorType.X509CertificateKeyHashSelector;
		string attribute = reader.GetAttribute("ValueType");
		if (string.IsNullOrEmpty(attribute))
		{
			attribute = reader.GetAttribute("ValueType", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd");
		}
		if ("http://docs.oasis-open.org/wss/oasis-wss-soap-message-security-1.1#ThumbprintSHA1" != attribute && "http://docs.oasis-open.org/wss/2004/xx/oasis-2004xx-wss-soap-message-security-1.1#ThumbprintSHA1" != attribute)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceUnsupportedKeyIdentifierType")));
		}
		try
		{
			MemoryStream memoryStream = Utility.ReadByteStreamFromBase64(reader);
			int num = Convert.ToInt32(memoryStream.Length);
			if (num > 0)
			{
				SetValue(memoryStream.GetBuffer(), 0, num);
			}
		}
		catch (FormatException)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidThumbPrintValue")));
		}
	}

	private void ReadSelfIssuedSelector(XmlReader reader)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional("PrivatePersonalIdentifier" != reader.LocalName || "http://schemas.xmlsoap.org/ws/2005/05/identity" != reader.NamespaceURI, reader.LocalName);
		Type = CredentialSelectorType.SelfIssuedCardIdSelector;
		string value = reader.ReadElementContentAsString().Trim();
		if (!string.IsNullOrEmpty(value))
		{
			SetValue(value);
		}
	}
}
