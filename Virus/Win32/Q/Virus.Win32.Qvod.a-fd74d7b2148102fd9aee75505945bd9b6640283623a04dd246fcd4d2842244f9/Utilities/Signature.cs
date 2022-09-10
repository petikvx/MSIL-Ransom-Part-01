using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Utilities;

internal class Signature
{
	public const string dsigPrefix = "dsig";

	public const string dsigUri = "http://www.w3.org/2000/09/xmldsig#";

	private const string pathToRsaKeyValue = "/dsig:KeyInfo/dsig:KeyValue/dsig:RSAKeyValue";

	private const string pathToX509Certificate = "/dsig:KeyInfo/dsig:X509Data/dsig:X509Certificate";

	private static X509Certificate2 GetX509CertificateFromKeyInfo(XmlElement element)
	{
		X509Certificate2 x509Certificate = null;
		try
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(element.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
			XmlNode xmlNode = element.SelectSingleNode("/dsig:KeyInfo/dsig:X509Data/dsig:X509Certificate", xmlNamespaceManager);
			string innerText = xmlNode.InnerText;
			byte[] rawData = Convert.FromBase64String(innerText);
			return new X509Certificate2(rawData);
		}
		catch (FormatException)
		{
			return null;
		}
		catch (NullReferenceException)
		{
			return null;
		}
		catch (ArgumentException)
		{
			return null;
		}
	}

	private static RSACryptoServiceProvider GetRsaFromKeyInfo(XmlElement element)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		try
		{
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(element.OwnerDocument.NameTable);
			xmlNamespaceManager.AddNamespace("dsig", "http://www.w3.org/2000/09/xmldsig#");
			XmlNode xmlNode = element.SelectSingleNode("/dsig:KeyInfo/dsig:KeyValue/dsig:RSAKeyValue", xmlNamespaceManager);
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(xmlNode.OuterXml);
			return rSACryptoServiceProvider;
		}
		catch (FormatException)
		{
			return null;
		}
		catch (NullReferenceException)
		{
			return null;
		}
		catch (ArgumentException)
		{
			return null;
		}
	}

	public static string GetPublicKeyXmlFromKeyInfo(XmlElement element)
	{
		string text = "";
		X509Certificate2 x509CertificateFromKeyInfo = GetX509CertificateFromKeyInfo(element);
		if (x509CertificateFromKeyInfo != null)
		{
			text = x509CertificateFromKeyInfo.PublicKey.Key.ToXmlString(includePrivateParameters: false);
		}
		else
		{
			RSACryptoServiceProvider rsaFromKeyInfo = GetRsaFromKeyInfo(element);
			if (rsaFromKeyInfo != null)
			{
				text = rsaFromKeyInfo.ToXmlString(includePrivateParameters: false);
			}
		}
		return "<KeyValue xmlns=\"http://www.w3.org/2000/09/xmldsig#\">" + text + "</KeyValue>";
	}
}
