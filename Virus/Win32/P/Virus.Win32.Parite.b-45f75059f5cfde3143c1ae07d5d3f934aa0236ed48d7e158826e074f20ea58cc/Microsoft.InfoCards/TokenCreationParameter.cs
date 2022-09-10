using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class TokenCreationParameter : IXmlSerializable
{
	private TokenFactoryCredentialType m_credentialType;

	private EndpointAddress m_epr;

	private string m_hint;

	private Dictionary<CredentialSelectorType, CredentialSelector> m_selectorMap;

	public TokenFactoryCredentialType CredentialType
	{
		get
		{
			return m_credentialType;
		}
		set
		{
			m_credentialType = value;
		}
	}

	public EndpointAddress Epr
	{
		get
		{
			return m_epr;
		}
		set
		{
			m_epr = value;
		}
	}

	public Dictionary<CredentialSelectorType, CredentialSelector> CredentialSelectors => m_selectorMap;

	public TokenCreationParameter()
	{
		m_selectorMap = new Dictionary<CredentialSelectorType, CredentialSelector>();
	}

	public bool IsComplete()
	{
		if ((EndpointAddress)null == m_epr)
		{
			return false;
		}
		bool flag = true;
		if (m_credentialType == TokenFactoryCredentialType.X509CertificateCredential || m_credentialType == TokenFactoryCredentialType.SelfIssuedCredential)
		{
			flag = flag && m_selectorMap.Count > 0;
		}
		return flag;
	}

	public void ThrowIfNotComplete()
	{
		if (!IsComplete())
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SerializationIncompleteException(GetType()));
		}
	}

	public void Serialize(BinaryWriter writer)
	{
		ThrowIfNotComplete();
		writer.Write((int)m_credentialType);
		Utility.SerializeString(writer, m_hint);
		Utility.SerializeString(writer, CreateEprXmlString(m_epr));
		writer.Write(m_selectorMap.Count);
		if (m_selectorMap.Count <= 0)
		{
			return;
		}
		foreach (CredentialSelector value in m_selectorMap.Values)
		{
			value.Serialize(writer);
		}
	}

	public void Deserialize(BinaryReader reader)
	{
		TokenFactoryCredentialType credentialType = (TokenFactoryCredentialType)reader.ReadInt32();
		string hint = Utility.DeserializeString(reader);
		string value = Utility.DeserializeString(reader);
		EndpointAddress epr = CreateEprFromString(value);
		int num = reader.ReadInt32();
		Dictionary<CredentialSelectorType, CredentialSelector> dictionary = new Dictionary<CredentialSelectorType, CredentialSelector>();
		for (int i = 0; i < num; i++)
		{
			CredentialSelector credentialSelector = new CredentialSelector();
			credentialSelector.Deserialize(reader);
			dictionary.Add(credentialSelector.Type, credentialSelector);
		}
		m_credentialType = credentialType;
		m_epr = epr;
		m_selectorMap = dictionary;
		m_hint = hint;
		ThrowIfNotComplete();
	}

	private static EndpointAddress CreateEprFromString(string value)
	{
		using MemoryStream input = new MemoryStream(Encoding.UTF8.GetBytes(value));
		XmlDictionaryReader val = Utility.CreateReaderWithQuotas(input);
		try
		{
			return EndpointAddress.ReadFrom(val);
		}
		catch (InfoCardBaseException)
		{
			throw;
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidCredentialSelector"), ex));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static string CreateEprXmlString(EndpointAddress address)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using XmlWriter xmlWriter = new XmlTextWriter(memoryStream, Encoding.Unicode);
		address.WriteTo(AddressingVersion.get_WSAddressing10(), xmlWriter);
		xmlWriter.Flush();
		memoryStream.Flush();
		return Encoding.Unicode.GetString(memoryStream.GetBuffer(), 2, Convert.ToInt32(memoryStream.Length - 2L));
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void WriteXml(XmlWriter writer)
	{
		if (writer == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("writer");
		}
		InfoCardTrace.ThrowInvalidArgumentConditional(!IsComplete(), "IsComplete");
		writer.WriteStartElement("TokenService", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		m_epr.WriteTo(AddressingVersion.get_WSAddressing10(), writer);
		writer.WriteStartElement("UserCredential", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (!string.IsNullOrEmpty(m_hint))
		{
			writer.WriteStartElement("DisplayCredentialHint", "http://schemas.xmlsoap.org/ws/2005/05/identity");
			writer.WriteString(m_hint);
			writer.WriteEndElement();
		}
		switch (m_credentialType)
		{
		default:
			InfoCardTrace.ThrowInvalidArgumentConditional(true, "CredentialType");
			break;
		case TokenFactoryCredentialType.UserNamePasswordCredential:
			WriteUserNameCredential(writer);
			break;
		case TokenFactoryCredentialType.SelfIssuedCredential:
			WriteSelfIssuedCredential(writer);
			break;
		case TokenFactoryCredentialType.X509CertificateCredential:
			WriteX509CertificateCredential(writer);
			break;
		case TokenFactoryCredentialType.KerberosCredential:
			WriteKerberosCredential(writer);
			break;
		}
		writer.WriteEndElement();
		writer.WriteEndElement();
	}

	public void WriteUserNameCredential(XmlWriter writer)
	{
		writer.WriteStartElement("UsernamePasswordCredential", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (m_selectorMap.ContainsKey(CredentialSelectorType.UserNameSelector))
		{
			m_selectorMap[CredentialSelectorType.UserNameSelector].WriteXml(writer);
		}
		writer.WriteEndElement();
	}

	public void WriteKerberosCredential(XmlWriter writer)
	{
		writer.WriteStartElement("KerberosV5Credential", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		writer.WriteEndElement();
	}

	public void WriteSelfIssuedCredential(XmlWriter writer)
	{
		writer.WriteStartElement("SelfIssuedCredential", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (m_selectorMap.ContainsKey(CredentialSelectorType.SelfIssuedCardIdSelector))
		{
			m_selectorMap[CredentialSelectorType.SelfIssuedCardIdSelector].WriteXml(writer);
		}
		writer.WriteEndElement();
	}

	public void WriteX509CertificateCredential(XmlWriter writer)
	{
		writer.WriteStartElement("X509V3Credential", "http://schemas.xmlsoap.org/ws/2005/05/identity");
		if (m_selectorMap.ContainsKey(CredentialSelectorType.X509CertificateIssuerNameSelector) && m_selectorMap.ContainsKey(CredentialSelectorType.X509CertificateIssuerSerialNoSelector))
		{
			writer.WriteStartElement("X509Data", "http://www.w3.org/2000/09/xmldsig#");
			writer.WriteStartElement("X509IssuerSerial", "http://www.w3.org/2000/09/xmldsig#");
			m_selectorMap[CredentialSelectorType.X509CertificateIssuerNameSelector].WriteXml(writer);
			m_selectorMap[CredentialSelectorType.X509CertificateIssuerSerialNoSelector].WriteXml(writer);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}
		else if (m_selectorMap.ContainsKey(CredentialSelectorType.X509CertificateKeyHashSelector))
		{
			writer.WriteStartElement("X509Data", "http://www.w3.org/2000/09/xmldsig#");
			m_selectorMap[CredentialSelectorType.X509CertificateKeyHashSelector].WriteXml(writer);
			writer.WriteEndElement();
		}
		writer.WriteEndElement();
	}

	public void ReadXml(XmlReader reader)
	{
		if (!reader.IsStartElement("TokenService", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		}
		reader.ReadStartElement();
		if (reader.LocalName == "EndpointReference")
		{
			try
			{
				m_epr = EndpointAddress.ReadFrom(XmlDictionaryReader.CreateDictionaryReader(reader));
			}
			catch (InfoCardBaseException)
			{
				throw;
			}
			catch (Exception ex)
			{
				if (InfoCardTrace.IsFatal(ex))
				{
					throw;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidCredentialSelector"), ex));
			}
			if ((EndpointAddress)null != m_epr && (EndpointAddress)null == Utility.DeriveMexAddress(m_epr))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceEprDoesNotHaveValidMetadata")));
			}
			if (reader.LocalName == "UserCredential")
			{
				reader.ReadStartElement();
			}
			if (reader.LocalName == "DisplayCredentialHint")
			{
				m_hint = ReadDisplayCredentialHint(reader);
			}
			switch (reader.LocalName)
			{
			case "X509V3Credential":
				CredentialType = TokenFactoryCredentialType.X509CertificateCredential;
				ReadX509V3CredentialElement(reader);
				reader.ReadEndElement();
				break;
			case "SelfIssuedCredential":
			{
				CredentialType = TokenFactoryCredentialType.SelfIssuedCredential;
				reader.ReadStartElement();
				CredentialSelector credentialSelector2 = new CredentialSelector();
				credentialSelector2.ReadXml(reader);
				if (credentialSelector2.IsComplete())
				{
					CredentialSelectors.Add(credentialSelector2.Type, credentialSelector2);
				}
				reader.ReadEndElement();
				break;
			}
			case "KerberosV5Credential":
				CredentialType = TokenFactoryCredentialType.KerberosCredential;
				if (!reader.IsEmptyElement)
				{
					while (reader.Read() && (!(reader.LocalName == "KerberosV5Credential") || reader.NodeType != XmlNodeType.EndElement))
					{
						if (reader.LocalName == "UserPrincipalName")
						{
							CredentialSelector credentialSelector3 = new CredentialSelector();
							credentialSelector3.ReadXml(reader);
							if (credentialSelector3.IsComplete())
							{
								CredentialSelectors.Add(credentialSelector3.Type, credentialSelector3);
							}
							break;
						}
					}
				}
				else
				{
					reader.ReadStartElement();
				}
				break;
			case "UsernamePasswordCredential":
				CredentialType = TokenFactoryCredentialType.UserNamePasswordCredential;
				if (!reader.IsEmptyElement)
				{
					while (reader.Read() && (!(reader.LocalName == "UsernamePasswordCredential") || reader.NodeType != XmlNodeType.EndElement))
					{
						if (reader.LocalName == "Username")
						{
							CredentialSelector credentialSelector = new CredentialSelector();
							credentialSelector.ReadXml(reader);
							if (credentialSelector.IsComplete())
							{
								CredentialSelectors.Add(credentialSelector.Type, credentialSelector);
							}
							break;
						}
					}
				}
				else
				{
					reader.ReadStartElement();
				}
				break;
			default:
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("NoAuthenticationServicesInCard")));
			}
			reader.ReadEndElement();
			return;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidCredentialSelector")));
	}

	public string ReadDisplayCredentialHint(XmlReader reader)
	{
		if (!reader.IsStartElement("DisplayCredentialHint", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		}
		return reader.ReadElementContentAsString().Trim();
	}

	private void ReadX509V3CredentialElement(XmlReader reader)
	{
		if (!reader.IsStartElement("X509V3Credential", "http://schemas.xmlsoap.org/ws/2005/05/identity"))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new XmlException(SR.GetString("UnexpectedElement")));
		}
		reader.ReadStartElement();
		if (!("http://www.w3.org/2000/09/xmldsig#" == reader.NamespaceURI) || !("X509Data" == reader.LocalName))
		{
			return;
		}
		while (reader.Read())
		{
			if (!reader.IsStartElement("X509IssuerSerial", "http://www.w3.org/2000/09/xmldsig#"))
			{
				if (reader.IsStartElement("KeyIdentifier", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd"))
				{
					CredentialSelector credentialSelector = new CredentialSelector();
					credentialSelector.ReadXml(reader);
					if (credentialSelector.IsComplete())
					{
						CredentialSelectors.Add(credentialSelector.Type, credentialSelector);
					}
					break;
				}
				continue;
			}
			reader.ReadStartElement();
			CredentialSelector credentialSelector2 = new CredentialSelector();
			credentialSelector2.ReadXml(reader);
			CredentialSelector credentialSelector3 = new CredentialSelector();
			credentialSelector3.ReadXml(reader);
			if (credentialSelector3.IsComplete() && credentialSelector2.IsComplete())
			{
				CredentialSelectors.Add(credentialSelector2.Type, credentialSelector2);
				CredentialSelectors.Add(credentialSelector3.Type, credentialSelector3);
			}
			reader.ReadEndElement();
			break;
		}
		while (!("X509Data" == reader.LocalName) || !("http://www.w3.org/2000/09/xmldsig#" == reader.NamespaceURI) || XmlNodeType.EndElement != reader.NodeType)
		{
			if (!reader.Read())
			{
				return;
			}
		}
		reader.ReadEndElement();
	}
}
