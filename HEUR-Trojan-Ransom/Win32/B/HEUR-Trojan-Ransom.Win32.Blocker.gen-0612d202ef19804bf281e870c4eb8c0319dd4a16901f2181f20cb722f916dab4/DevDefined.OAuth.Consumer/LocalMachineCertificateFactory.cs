using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace DevDefined.OAuth.Consumer;

public class LocalMachineCertificateFactory : ICertificateFactory
{
	private readonly string _certificateSubject;

	private readonly X509FindType _findType;

	public LocalMachineCertificateFactory(string certificateSubject, X509FindType findType)
	{
		_certificateSubject = certificateSubject;
		_findType = findType;
		ServicePointManager.ServerCertificateValidationCallback = RemoteCertificateValidationCallback;
	}

	public X509Certificate2 CreateCertificate()
	{
		X509Certificate2Collection certificateCollection = GetCertificateCollection();
		if (certificateCollection.Count <= 0)
		{
			return null;
		}
		return certificateCollection[0];
	}

	public int GetMatchingCertificateCount()
	{
		return GetCertificateCollection().Count;
	}

	public bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	private X509Certificate2Collection GetCertificateCollection()
	{
		X509Store x509Store = new X509Store("My", StoreLocation.LocalMachine);
		x509Store.Open(OpenFlags.OpenExistingOnly);
		X509Certificate2Collection result = x509Store.Certificates.Find(_findType, _certificateSubject, validOnly: false);
		x509Store.Close();
		return result;
	}
}
