using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using ns9;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		while (true)
		{
			((SoapHttpClientProtocol)this)._002Ector();
			while (true)
			{
				((WebClientProtocol)this).set_Url(Class50.string_0 + "UploadReportLogin.asmx");
				((WebClientProtocol)this).set_Timeout(30000);
				if (!agcutgGkjyLFBocJiAV())
				{
					switch (5)
					{
					default:
						continue;
					case 0:
					case 2:
						break;
					case 5:
						return;
					}
				}
				break;
			}
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { licenseID })[0];
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		WebRequest webRequest = ((SoapHttpClientProtocol)this).GetWebRequest(uri);
		if (webRequest is HttpWebRequest httpWebRequest)
		{
			httpWebRequest.ServicePoint.Expect100Continue = false;
		}
		return webRequest;
	}

	internal static bool LthfnUGssS1wus7SB52()
	{
		return true;
	}

	internal static bool agcutgGkjyLFBocJiAV()
	{
		return false;
	}
}
