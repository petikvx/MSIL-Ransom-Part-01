using System;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.X509;

namespace MySql.Data.common;

internal static class SslPemCertificateValidator
{
	public static void ValidateCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate, MySqlBaseConnectionStringBuilder settings)
	{
		if (settings.SslMode >= MySqlSslMode.VerifyCA)
		{
			VerifyEmptyOrWhitespaceSslConnectionOption(settings.SslCa, "SslCa");
			Org.BouncyCastle.X509.X509Certificate x509Certificate = ReadSslCertificate(settings.SslCa);
			VerifyIssuer(x509Certificate, certificate);
			VerifyDates(x509Certificate);
			VerifyCAStatus(x509Certificate, expectedCAStatus: true);
			VerifySignature(x509Certificate, DotNetUtilities.FromX509Certificate(certificate));
		}
		if (settings.SslMode == MySqlSslMode.VerifyFull)
		{
			VerifyEmptyOrWhitespaceSslConnectionOption(settings.SslCert, "SslCert");
			Org.BouncyCastle.X509.X509Certificate certificate2 = ReadSslCertificate(settings.SslCert);
			VerifyDates(certificate2);
			VerifyCAStatus(certificate2, expectedCAStatus: false);
			VerifyEmptyOrWhitespaceSslConnectionOption(settings.SslKey, "SslKey");
			AsymmetricCipherKeyPair key = ReadKey(settings.SslKey);
			VerifyKeyCorrespondsToCertificateKey(certificate2, key);
		}
	}

	private static void VerifyEmptyOrWhitespaceSslConnectionOption(string connectionOption, string connectionOptionName)
	{
		if (string.IsNullOrWhiteSpace(connectionOption))
		{
			throw new MySqlException(Resources.SslConnectionError, new FileNotFoundException(string.Format(Resources.FilePathNotSet, connectionOptionName)));
		}
	}

	private static byte[] GetBuffer(string filePath)
	{
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath");
		}
		try
		{
			FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			byte[] array = new byte[fileStream.Length];
			for (int i = fileStream.Read(array, 0, array.Length); i < fileStream.Length; i += fileStream.Read(array, i, array.Length - i))
			{
			}
			fileStream.Close();
			return array;
		}
		catch (Exception)
		{
			throw new MySqlException(Resources.SslConnectionError, new FileNotFoundException(Resources.FileNotFound, filePath));
		}
	}

	private static Org.BouncyCastle.X509.X509Certificate ReadSslCertificate(string filePath)
	{
		PemReader pemReader = new PemReader(new StreamReader(new MemoryStream(GetBuffer(filePath))));
		try
		{
			return ((Org.BouncyCastle.X509.X509Certificate)pemReader.ReadObject()) ?? throw new InvalidCastException();
		}
		catch (InvalidCastException)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.FileIsNotACertificate));
		}
	}

	private static AsymmetricCipherKeyPair ReadKey(string filePath)
	{
		PemReader pemReader = new PemReader(new StreamReader(new MemoryStream(GetBuffer(filePath))));
		try
		{
			return ((AsymmetricCipherKeyPair)pemReader.ReadObject()) ?? throw new InvalidCastException();
		}
		catch (InvalidCastException)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.FileIsNotAKey));
		}
	}

	private static void VerifyDates(Org.BouncyCastle.X509.X509Certificate certificate)
	{
		try
		{
			certificate.CheckValidity();
		}
		catch (CertificateExpiredException ex)
		{
			throw new MySqlException(Resources.SslConnectionError, ex);
		}
		catch (CertificateNotYetValidException ex2)
		{
			throw new MySqlException(Resources.SslConnectionError, ex2);
		}
	}

	private static void VerifyCAStatus(Org.BouncyCastle.X509.X509Certificate certificate, bool expectedCAStatus)
	{
		int certificationPathLength;
		bool? flag = IsCA(certificate, out certificationPathLength);
		if (flag == true && !expectedCAStatus)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.InvalidSslCertificate));
		}
		if (expectedCAStatus && certificate.Version == 3 && (flag == false || !flag.HasValue))
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.SslCertificateIsNotCA));
		}
	}

	private static void VerifySignature(Org.BouncyCastle.X509.X509Certificate certificate, Org.BouncyCastle.X509.X509Certificate serverCertificate)
	{
		VerifySignature(serverCertificate, certificate.GetPublicKey());
	}

	private static void VerifySignatureUsingKey(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricCipherKeyPair key)
	{
		VerifySignature(certificate, key.Public);
	}

	private static void VerifySignature(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricKeyParameter key)
	{
		try
		{
			certificate.Verify(key);
		}
		catch (InvalidKeyException innerException)
		{
			throw new Exception(Resources.InvalidCertificateKey, innerException);
		}
		catch (SignatureException innerException2)
		{
			throw new Exception(Resources.InvalidSslCertificateSignature, innerException2);
		}
		catch (CertificateException innerException3)
		{
			throw new Exception(Resources.EncodingError, innerException3);
		}
		catch (Exception innerException4)
		{
			throw new Exception(Resources.InvalidSslCertificateSignatureGeneral, innerException4);
		}
	}

	private static void VerifyIdentity(SslPolicyErrors sslPolicyErrors)
	{
		if (sslPolicyErrors == SslPolicyErrors.RemoteCertificateNameMismatch)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.SslCertificateHostNameMismatch));
		}
	}

	private static void VerifyIssuer(Org.BouncyCastle.X509.X509Certificate CACertificate, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate)
	{
		if (new System.Security.Cryptography.X509Certificates.X509Certificate(CACertificate.GetEncoded()).Issuer != serverCertificate.Issuer)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.SslCertificateCAMismatch));
		}
	}

	private static void VerifyKeyCorrespondsToCertificateKey(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricCipherKeyPair key)
	{
		string text = certificate.GetPublicKey().ToString();
		if (!string.IsNullOrEmpty(text) && text != key.Public.ToString())
		{
			throw new InvalidKeyException();
		}
	}

	private static bool? IsCA(Org.BouncyCastle.X509.X509Certificate certificate, out int certificationPathLength)
	{
		if (certificate.Version == 3)
		{
			certificationPathLength = certificate.GetBasicConstraints();
			return certificationPathLength != -1;
		}
		certificationPathLength = -1;
		return null;
	}
}
