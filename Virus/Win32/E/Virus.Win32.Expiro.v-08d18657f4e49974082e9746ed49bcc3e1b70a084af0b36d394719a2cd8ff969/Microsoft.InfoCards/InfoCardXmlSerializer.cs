using System;
using System.Collections;
using System.IO;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Schema;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardXmlSerializer
{
	private InfoCard m_card;

	private X509Certificate2 m_issuer;

	private X509Certificate2Collection m_additionalIssuerCerts;

	private bool m_isIssuerChainTrusted;

	private bool m_checkSignature;

	private bool m_isDeserialized;

	private StoreConnection m_connection;

	public InfoCard Card
	{
		get
		{
			if (m_isDeserialized)
			{
				return m_card;
			}
			return null;
		}
	}

	public X509Certificate2 Issuer
	{
		get
		{
			if (m_isDeserialized)
			{
				return m_issuer;
			}
			return null;
		}
	}

	public X509Certificate2Collection AdditionalIssuerCerts => m_additionalIssuerCerts;

	public bool IsIssuerChainTrusted
	{
		get
		{
			InfoCardTrace.Assert(m_isDeserialized, "Card should be deserialized before checking this value", new object[0]);
			return m_isIssuerChainTrusted;
		}
	}

	public bool CheckSignature
	{
		set
		{
			m_checkSignature = value;
		}
	}

	public InfoCardXmlSerializer(StoreConnection connection)
	{
		m_connection = connection;
	}

	public void Deserialize(string filename)
	{
		try
		{
			m_card = new InfoCard();
			m_card.HashSalt = InfoCard.GenerateSalt();
			CreateCardFromXml(filename);
			m_card.IssuerIdentifierAsBytes = Convert.FromBase64String(Recipient.CertGetRecipientOrganizationIdHash(m_issuer, m_additionalIssuerCerts, m_isIssuerChainTrusted));
			m_isDeserialized = true;
		}
		catch (Exception ex)
		{
			if (InfoCardTrace.IsFatal(ex))
			{
				throw;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), ex));
		}
	}

	private void CreateCardFromXml(string filename)
	{
		try
		{
			using FileStream fileStream = File.OpenRead(filename);
			XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
			xmlReaderSettings.IgnoreWhitespace = false;
			xmlReaderSettings.IgnoreProcessingInstructions = false;
			xmlReaderSettings.IgnoreComments = true;
			using XmlReader reader = InfoCardSchemas.CreateReader((Stream)fileStream, xmlReaderSettings);
			RetrieveIssuerAndCheckSign(reader);
			fileStream.Seek(0L, SeekOrigin.Begin);
			xmlReaderSettings = InfoCardSchemas.CreateDefaultReaderSettings();
			xmlReaderSettings.IgnoreWhitespace = false;
			using XmlReader xmlReader = InfoCardSchemas.CreateReader((Stream)fileStream, xmlReaderSettings);
			while (xmlReader.Read())
			{
				if (xmlReader.LocalName == "InformationCard")
				{
					m_card.ReadXml(xmlReader);
					break;
				}
			}
			xmlReader.Read();
			if ("Signature" != xmlReader.LocalName || XmlNodeType.EndElement != xmlReader.NodeType)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
			}
		}
		catch (XmlSchemaValidationException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner));
		}
		catch (CryptographicException inner2)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner2));
		}
		catch (UnauthorizedAccessException inner3)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("ImportInaccesibleFile"), inner3));
		}
		catch (FileNotFoundException inner4)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("ImportFileNotFound"), inner4));
		}
		catch (IOException inner5)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile"), inner5));
		}
	}

	private void RetrieveIssuerAndCheckSign(XmlReader reader)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0319: Expected O, but got Unknown
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.PreserveWhitespace = true;
		xmlDocument.Load(reader);
		XmlNames.CreateNamespaceManager(xmlDocument.NameTable);
		if ("Signature" != xmlDocument.DocumentElement!.LocalName && "http://www.w3.org/2000/09/xmldsig#" == xmlDocument.DocumentElement!.NamespaceURI)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("SignatureNotVerified")));
		}
		SignedXml val = new SignedXml(xmlDocument);
		val.LoadXml(xmlDocument.DocumentElement);
		if (val.get_Signature() != null && val.get_Signature().get_ObjectList() != null && val.get_Signature().get_SignedInfo() != null && val.get_Signature().get_SignedInfo().get_References() != null && ((Reference)val.get_Signature().get_SignedInfo().get_References()[0]).get_TransformChain() != null)
		{
			if (val.get_Signature().get_ObjectList().Count == 1 && val.get_Signature().get_SignedInfo().get_References()
				.Count == 1 && ((Reference)val.get_Signature().get_SignedInfo().get_References()[0]).get_TransformChain().get_Count() == 1)
			{
				string algorithm = ((Reference)val.get_Signature().get_SignedInfo().get_References()[0]).get_TransformChain().get_Item(0).get_Algorithm();
				if (!(val.get_Signature().get_SignedInfo().get_SignatureMethod() != "http://www.w3.org/2000/09/xmldsig#rsa-sha1") && (!("http://www.w3.org/2001/10/xml-exc-c14n#" != algorithm) || !("http://www.w3.org/2001/10/xml-exc-c14n#WithComments" != algorithm)) && !("http://www.w3.org/2001/10/xml-exc-c14n#" != val.get_Signature().get_SignedInfo().get_CanonicalizationMethodObject()
					.get_Algorithm()) && !("http://www.w3.org/2000/09/xmldsig#sha1" != ((Reference)val.get_Signature().get_SignedInfo().get_References()[0]).get_DigestMethod()))
				{
					if (val.get_KeyInfo() == null)
					{
						throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("SignatureNotVerified")));
					}
					XmlNodeList childNodes = val.get_KeyInfo().GetXml().ChildNodes;
					KeyInfoX509Data val2 = new KeyInfoX509Data();
					foreach (XmlNode item in childNodes)
					{
						if ("http://www.w3.org/2000/09/xmldsig#" == item.NamespaceURI && "X509Data" == item.Name)
						{
							((KeyInfoClause)val2).LoadXml((XmlElement)item);
							break;
						}
					}
					ArrayList certificates = val2.get_Certificates();
					if (certificates != null && certificates.Count > 0)
					{
						m_issuer = (X509Certificate2)certificates[0];
						m_additionalIssuerCerts = new X509Certificate2Collection();
						for (int i = 1; i < certificates.Count; i++)
						{
							m_additionalIssuerCerts.Add((X509Certificate2)certificates[i]);
						}
						try
						{
							InfoCardX509Validator.ValidateChainOrPeer(m_issuer, m_additionalIssuerCerts, out m_isIssuerChainTrusted);
						}
						catch (SecurityTokenValidationException val3)
						{
							SecurityTokenValidationException val4 = val3;
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(((Exception)(object)val4).Message));
						}
						if (m_checkSignature && !val.CheckSignature(m_issuer, true))
						{
							throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("SignatureNotVerified")));
						}
						return;
					}
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("NoCertificateFoundInSignature")));
				}
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("SignatureNotVerified")));
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("SignatureNotVerified")));
		}
		throw InfoCardTrace.ThrowHelperError((Exception)(object)new IdentityValidationException(SR.GetString("SignatureNotVerified")));
	}
}
