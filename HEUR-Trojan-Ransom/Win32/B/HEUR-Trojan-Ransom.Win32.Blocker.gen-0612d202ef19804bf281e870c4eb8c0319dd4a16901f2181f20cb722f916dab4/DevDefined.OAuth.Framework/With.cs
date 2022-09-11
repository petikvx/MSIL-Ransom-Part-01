using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace DevDefined.OAuth.Framework;

public static class With
{
	public static IDisposable NoCertificateValidation()
	{
		RemoteCertificateValidationCallback oldCallback = ServicePointManager.ServerCertificateValidationCallback;
		ServicePointManager.ServerCertificateValidationCallback = CertificateAlwaysValidCallback;
		return new DisposableAction(delegate
		{
			ServicePointManager.ServerCertificateValidationCallback = oldCallback;
		});
	}

	private static bool CertificateAlwaysValidCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}
}
