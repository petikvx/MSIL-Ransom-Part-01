using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Cache;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using VerificareSiuiFarmacie.Properties;

namespace VerificareSiuiFarmacie.SiuiInsuredWS;

[DesignerCategory("code")]
[DebuggerStepThrough]
[WebServiceBinding(Namespace = "http://webservices.utils.svapnt.siveco.ro", Name = "SiuiInsuredWSSoapBinding")]
[GeneratedCode("System.Web.Services", "2.0.50727.3053")]
public class SiuiInsuredWSService : SoapHttpClientProtocol
{
	private SendOrPostCallback sendOrPostCallback_0;

	private bool bool_0;

	private X509Certificate2 x509Certificate2_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private getInsuredCompletedEventHandler getInsuredCompletedEventHandler_0;

	public X509Certificate2 CertificatSSL
	{
		get
		{
			return x509Certificate2_0;
		}
		set
		{
			x509Certificate2_0 = value;
		}
	}

	public string SessionId
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string WsUserName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public string WsPassword
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public string Url
	{
		get
		{
			return ((WebClientProtocol)this).get_Url();
		}
		set
		{
			if (method_1(((WebClientProtocol)this).get_Url()) && !bool_0 && !method_1(value))
			{
				((WebClientProtocol)this).set_UseDefaultCredentials(false);
			}
			((WebClientProtocol)this).set_Url(value);
		}
	}

	public bool UseDefaultCredentials
	{
		get
		{
			return ((WebClientProtocol)this).get_UseDefaultCredentials();
		}
		set
		{
			((WebClientProtocol)this).set_UseDefaultCredentials(value);
			bool_0 = true;
		}
	}

	public event getInsuredCompletedEventHandler getInsuredCompleted
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			getInsuredCompletedEventHandler_0 = (getInsuredCompletedEventHandler)Delegate.Combine(getInsuredCompletedEventHandler_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			getInsuredCompletedEventHandler_0 = (getInsuredCompletedEventHandler)Delegate.Remove(getInsuredCompletedEventHandler_0, value);
		}
	}

	public SiuiInsuredWSService()
	{
		Url = Settings.Default.VerificareSiuiFarmacie_SIUIInsuredWS_SiuiInsuredWSService;
		if (method_1(Url))
		{
			UseDefaultCredentials = true;
			bool_0 = false;
		}
		else
		{
			bool_0 = true;
		}
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)((SoapHttpClientProtocol)this).GetWebRequest(uri);
		httpWebRequest.Headers.Add("OSCP_RESPONSE", string_0);
		CredentialCache credentialCache = new CredentialCache();
		credentialCache.Add(uri, "Basic", new NetworkCredential(string_1, string_2));
		httpWebRequest.Credentials = credentialCache;
		httpWebRequest.ProtocolVersion = HttpVersion.Version10;
		httpWebRequest.KeepAlive = false;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.PreAuthenticate = true;
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		httpWebRequest.Proxy = WebRequest.GetSystemWebProxy();
		ServicePointManager.Expect100Continue = false;
		return httpWebRequest;
	}

	public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return true;
	}

	[SoapRpcMethod("", ResponseNamespace = "http://webservices.utils.svapnt.siveco.ro", RequestNamespace = "http://webservices.utils.svapnt.siveco.ro")]
	[return: SoapElement("getInsuredReturn")]
	public string getInsured(string pid, DateTime requestDate)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("getInsured", new object[2] { pid, requestDate });
		return (string)array[0];
	}

	public void getInsuredAsync(string pid, DateTime requestDate)
	{
		getInsuredAsync(pid, requestDate, null);
	}

	public void getInsuredAsync(string pid, DateTime requestDate, object userState)
	{
		if (sendOrPostCallback_0 == null)
		{
			sendOrPostCallback_0 = method_0;
		}
		((SoapHttpClientProtocol)this).InvokeAsync("getInsured", new object[2] { pid, requestDate }, sendOrPostCallback_0, userState);
	}

	private void method_0(object object_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (getInsuredCompletedEventHandler_0 != null)
		{
			InvokeCompletedEventArgs val = (InvokeCompletedEventArgs)object_0;
			getInsuredCompletedEventHandler_0(this, new getInsuredCompletedEventArgs(val.get_Results(), ((AsyncCompletedEventArgs)(object)val).Error, ((AsyncCompletedEventArgs)(object)val).Cancelled, ((AsyncCompletedEventArgs)(object)val).UserState));
		}
	}

	public void CancelAsync(object userState)
	{
		((HttpWebClientProtocol)this).CancelAsync(userState);
	}

	private bool method_1(string string_3)
	{
		if (string_3 == null || string_3 == string.Empty)
		{
			return false;
		}
		Uri uri = new Uri(string_3);
		if (uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		return false;
	}
}
