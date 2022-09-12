using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.X509;

namespace MySql.Data.Common;

internal class Ssl
{
	private MySqlConnectionStringBuilder _settings;

	private bool _treatCertificatesAsPemFormat;

	private static SslProtocols[] tlsProtocols = new SslProtocols[2]
	{
		SslProtocols.Tls12,
		SslProtocols.Tls11
	};

	private static Dictionary<string, SslProtocols> tlsConnectionRef = new Dictionary<string, SslProtocols>();

	private static Dictionary<string, int> tlsRetry = new Dictionary<string, int>();

	private static object thisLock = new object();

	public Ssl(MySqlConnectionStringBuilder settings)
	{
		_settings = settings;
		_treatCertificatesAsPemFormat = true;
	}

	public Ssl(string server, MySqlSslMode sslMode, string certificateFile, MySqlCertificateStoreLocation certificateStoreLocation, string certificatePassword, string certificateThumbprint, string sslCa, string sslCert, string sslKey)
	{
		_settings = new MySqlConnectionStringBuilder
		{
			Server = server,
			SslMode = sslMode,
			CertificateFile = certificateFile,
			CertificateStoreLocation = certificateStoreLocation,
			CertificatePassword = certificatePassword,
			CertificateThumbprint = certificateThumbprint,
			SslCa = sslCa,
			SslCert = sslCert,
			SslKey = sslKey
		};
		_treatCertificatesAsPemFormat = true;
	}

	private X509CertificateCollection GetPFXClientCertificates()
	{
		X509CertificateCollection x509CertificateCollection = new X509CertificateCollection();
		if (_settings.CertificateFile != null)
		{
			X509Certificate2 value = new X509Certificate2(_settings.CertificateFile, _settings.CertificatePassword);
			x509CertificateCollection.Add(value);
			return x509CertificateCollection;
		}
		if (_settings.CertificateStoreLocation == MySqlCertificateStoreLocation.None)
		{
			return x509CertificateCollection;
		}
		StoreLocation storeLocation = ((_settings.CertificateStoreLocation == MySqlCertificateStoreLocation.CurrentUser) ? StoreLocation.CurrentUser : StoreLocation.LocalMachine);
		X509Store x509Store = new X509Store(StoreName.My, storeLocation);
		x509Store.Open(OpenFlags.OpenExistingOnly);
		if (_settings.CertificateThumbprint == null)
		{
			x509CertificateCollection.AddRange(x509Store.Certificates);
			return x509CertificateCollection;
		}
		x509CertificateCollection.AddRange(x509Store.Certificates.Find(X509FindType.FindByThumbprint, _settings.CertificateThumbprint, validOnly: true));
		if (x509CertificateCollection.Count == 0)
		{
			throw new MySqlException("Certificate with Thumbprint " + _settings.CertificateThumbprint + " not found");
		}
		return x509CertificateCollection;
	}

	public MySqlStream StartSSL(ref Stream baseStream, Encoding encoding, string connectionString)
	{
		if (_settings.SslCa != null)
		{
			string certificateFileExtension = GetCertificateFileExtension(_settings.SslCa, toLowerCase: true);
			if (certificateFileExtension != null)
			{
				_treatCertificatesAsPemFormat = certificateFileExtension != "pfx";
			}
		}
		RemoteCertificateValidationCallback userCertificateValidationCallback = ServerCheckValidation;
		SslStream sslStream = new SslStream(baseStream, leaveInnerStreamOpen: false, userCertificateValidationCallback, null);
		X509CertificateCollection clientCertificates = (_treatCertificatesAsPemFormat ? new X509CertificateCollection() : GetPFXClientCertificates());
		string key = connectionString.GetHashCode().ToString();
		SslProtocols sslProtocols = SslProtocols.Tls;
		lock (thisLock)
		{
			if (tlsConnectionRef.ContainsKey(key))
			{
				sslProtocols = tlsConnectionRef[key];
			}
			else
			{
				if (!tlsRetry.ContainsKey(key))
				{
					tlsRetry[key] = 0;
				}
				for (int i = tlsRetry[key]; i < tlsProtocols.Length; i++)
				{
					sslProtocols |= tlsProtocols[i];
				}
			}
			try
			{
				sslStream.AuthenticateAsClientAsync(_settings.Server, clientCertificates, sslProtocols, checkCertificateRevocation: false).Wait();
				tlsConnectionRef[key] = sslProtocols;
				tlsRetry.Remove(key);
			}
			catch (AggregateException ex)
			{
				if (ex.GetBaseException() is IOException)
				{
					tlsConnectionRef.Remove(key);
					if (tlsRetry.ContainsKey(key))
					{
						if (tlsRetry[key] > tlsProtocols.Length)
						{
							throw new MySqlException(Resources.SslConnectionError, ex);
						}
						tlsRetry[key]++;
					}
				}
				throw ex.GetBaseException();
			}
		}
		baseStream = sslStream;
		return new MySqlStream(sslStream, encoding, compress: false)
		{
			SequenceByte = 2
		};
	}

	private bool ServerCheckValidation(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if (sslPolicyErrors == SslPolicyErrors.None)
		{
			return true;
		}
		if (_settings.SslMode != MySqlSslMode.Required && _settings.SslMode != MySqlSslMode.Preferred)
		{
			if (_treatCertificatesAsPemFormat)
			{
				if (_settings.SslMode >= MySqlSslMode.VerifyCA)
				{
					VerifyEmptyOrWhitespaceSslConnectionOption(_settings.SslCa, "SslCa");
					Org.BouncyCastle.X509.X509Certificate x509Certificate = ReadSslCertificate(_settings.SslCa);
					VerifyIssuer(x509Certificate, certificate);
					VerifyDates(x509Certificate);
					VerifyCAStatus(x509Certificate, expectedCAStatus: true);
					VerifySignature(x509Certificate, DotNetUtilities.FromX509Certificate(certificate));
				}
				if (_settings.SslMode == MySqlSslMode.VerifyFull)
				{
					VerifyEmptyOrWhitespaceSslConnectionOption(_settings.SslCert, "SslCert");
					Org.BouncyCastle.X509.X509Certificate certificate2 = ReadSslCertificate(_settings.SslCert);
					VerifyDates(certificate2);
					VerifyCAStatus(certificate2, expectedCAStatus: false);
					VerifyEmptyOrWhitespaceSslConnectionOption(_settings.SslKey, "SslKey");
					AsymmetricCipherKeyPair key = ReadKey(_settings.SslKey);
					VerifyKeyCorrespondsToCertificateKey(certificate2, key);
				}
				return true;
			}
			if (_settings.SslMode == MySqlSslMode.VerifyCA && sslPolicyErrors == SslPolicyErrors.RemoteCertificateNameMismatch)
			{
				return true;
			}
			return false;
		}
		return true;
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

	private string GetCertificateFileExtension(string filePath, bool toLowerCase)
	{
		if (filePath != null && File.Exists(filePath))
		{
			string extension = Path.GetExtension(filePath);
			extension = (string.IsNullOrEmpty(extension) ? null : extension.Substring(extension.IndexOf(".") + 1));
			if (!toLowerCase)
			{
				return extension;
			}
			return extension.ToLowerInvariant();
		}
		return null;
	}

	private Org.BouncyCastle.X509.X509Certificate ReadSslCertificate(string filePath)
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

	private AsymmetricCipherKeyPair ReadKey(string filePath)
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

	private void VerifyDates(Org.BouncyCastle.X509.X509Certificate certificate)
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

	private void VerifyCAStatus(Org.BouncyCastle.X509.X509Certificate certificate, bool expectedCAStatus)
	{
		int certificationPathLength = -1;
		bool? flag = IsCA(certificate, out certificationPathLength);
		if (flag == true && !expectedCAStatus)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.InvalidSslCertificate));
		}
		if ((flag == false || !flag.HasValue) && expectedCAStatus)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.SslCertificateIsNotCA));
		}
	}

	private void VerifySignature(Org.BouncyCastle.X509.X509Certificate certificate, Org.BouncyCastle.X509.X509Certificate serverCertificate)
	{
		VerifySignature(serverCertificate, certificate.GetPublicKey());
	}

	private void VerifySignatureUsingKey(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricCipherKeyPair key)
	{
		VerifySignature(certificate, key.Public);
	}

	private void VerifySignature(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricKeyParameter key)
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

	private void VerifyIdentity(SslPolicyErrors sslPolicyErrors)
	{
		if (sslPolicyErrors == SslPolicyErrors.RemoteCertificateNameMismatch)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.SslCertificateHostNameMismatch));
		}
	}

	private void VerifyIssuer(Org.BouncyCastle.X509.X509Certificate CACertificate, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate)
	{
		if (CACertificate.IssuerDN.ToString() != serverCertificate.Issuer)
		{
			throw new MySqlException(Resources.SslConnectionError, new Exception(Resources.SslCertificateCAMismatch));
		}
	}

	private void VerifyKeyCorrespondsToCertificateKey(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricCipherKeyPair key)
	{
		string text = certificate.GetPublicKey().ToString();
		if (!string.IsNullOrEmpty(text) && text != key.Public.ToString())
		{
			throw new InvalidKeyException();
		}
	}

	private bool? IsCA(Org.BouncyCastle.X509.X509Certificate certificate, out int certificationPathLength)
	{
		if (certificate.Version == 3)
		{
			certificationPathLength = certificate.GetBasicConstraints();
			return certificationPathLength != -1;
		}
		certificationPathLength = -1;
		return null;
	}

	private void VerifyEmptyOrWhitespaceSslConnectionOption(string connectionOption, string connectionOptionName)
	{
		if (string.IsNullOrWhiteSpace(connectionOption))
		{
			throw new MySqlException(Resources.SslConnectionError, new FileNotFoundException(string.Format(Resources.FilePathNotSet, connectionOptionName)));
		}
	}
}
