using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace DevDefined.OAuth.Consumer;

public class LocalFileCertificateFactory : ICertificateFactory
{
	private readonly string _filename;

	private readonly string _password;

	public LocalFileCertificateFactory(string filename, string password)
	{
		_filename = filename;
		_password = password;
		if (!File.Exists(filename))
		{
			throw new FileNotFoundException("The certificate file could not be located on disk.", filename);
		}
		if (CreateCertificate() == null)
		{
			throw new ApplicationException("The certificate could not be loaded from disk.");
		}
	}

	public X509Certificate2 CreateCertificate()
	{
		if (!File.Exists(_filename))
		{
			return null;
		}
		try
		{
			return new X509Certificate2(_filename, _password);
		}
		catch (CryptographicException)
		{
			return null;
		}
	}

	public int GetMatchingCertificateCount()
	{
		if (CreateCertificate() == null)
		{
			return 0;
		}
		return 1;
	}
}
