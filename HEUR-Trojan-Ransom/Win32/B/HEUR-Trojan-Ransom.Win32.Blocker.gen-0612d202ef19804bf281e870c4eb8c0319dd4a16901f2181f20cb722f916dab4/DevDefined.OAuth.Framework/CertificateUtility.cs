using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using DevDefined.OAuth.KeyInterop;

namespace DevDefined.OAuth.Framework;

public static class CertificateUtility
{
	public static X509Certificate2 LoadCertificateFromStrings(string privateKey, string certificate)
	{
		AsnKeyParser asnKeyParser = new AsnKeyParser(Convert.FromBase64String(privateKey));
		RSAParameters parameters = asnKeyParser.ParseRSAPrivateKey();
		X509Certificate2 x509Certificate = new X509Certificate2(Encoding.ASCII.GetBytes(certificate));
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		x509Certificate.PrivateKey = rSACryptoServiceProvider;
		return x509Certificate;
	}
}
