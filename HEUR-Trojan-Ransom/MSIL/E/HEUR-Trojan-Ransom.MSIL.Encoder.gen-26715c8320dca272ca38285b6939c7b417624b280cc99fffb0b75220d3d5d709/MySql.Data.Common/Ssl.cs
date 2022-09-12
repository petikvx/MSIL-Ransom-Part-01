using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data.common;

namespace MySql.Data.Common;

internal class Ssl
{
	private MySqlConnectionStringBuilder _settings;

	private bool _treatCertificatesAsPemFormat;

	private static SslProtocols[] tlsProtocols = new SslProtocols[3]
	{
		SslProtocols.Tls12,
		SslProtocols.Tls11,
		SslProtocols.Tls
	};

	private static Dictionary<string, SslProtocols> tlsConnectionRef = new Dictionary<string, SslProtocols>();

	private static Dictionary<string, int> tlsRetry = new Dictionary<string, int>();

	private static object thisLock = new object();

	public Ssl(MySqlConnectionStringBuilder settings)
	{
		_settings = settings;
		_treatCertificatesAsPemFormat = true;
	}

	public Ssl(string server, MySqlSslMode sslMode, string certificateFile, MySqlCertificateStoreLocation certificateStoreLocation, string certificatePassword, string certificateThumbprint, string sslCa, string sslCert, string sslKey, string tlsVersion)
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
			SslKey = sslKey,
			TlsVersion = tlsVersion
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
		SslProtocols sslProtocols = SslProtocols.None;
		if (_settings.TlsVersion != null)
		{
			if (_settings.TlsVersion.Equals("Tls13", StringComparison.OrdinalIgnoreCase))
			{
				throw new NotSupportedException(Resources.Tlsv13NotSupported);
			}
			SslProtocols sslProtocols2 = (SslProtocols)Enum.Parse(typeof(SslProtocols), _settings.TlsVersion);
			List<SslProtocols> list = new List<SslProtocols>();
			if (sslProtocols2.HasFlag(SslProtocols.Tls12))
			{
				list.Add(SslProtocols.Tls12);
			}
			if (sslProtocols2.HasFlag(SslProtocols.Tls11))
			{
				list.Add(SslProtocols.Tls11);
			}
			if (sslProtocols2.HasFlag(SslProtocols.Tls))
			{
				list.Add(SslProtocols.Tls);
			}
			tlsProtocols = list.ToArray();
		}
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
				sslProtocols = ((sslProtocols == SslProtocols.None) ? SslProtocols.Tls : sslProtocols);
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

	private bool ServerCheckValidation(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if (sslPolicyErrors == SslPolicyErrors.None)
		{
			return true;
		}
		if (_settings.SslMode != MySqlSslMode.Required && _settings.SslMode != MySqlSslMode.Preferred)
		{
			if (_treatCertificatesAsPemFormat)
			{
				SslPemCertificateValidator.ValidateCertificate(certificate, _settings);
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
}
