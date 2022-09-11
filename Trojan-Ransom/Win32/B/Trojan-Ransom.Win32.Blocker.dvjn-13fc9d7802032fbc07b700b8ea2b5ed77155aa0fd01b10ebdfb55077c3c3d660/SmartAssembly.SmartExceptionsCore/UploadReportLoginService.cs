using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using ns11;

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
				((WebClientProtocol)this).set_Url(Class57.string_0 + "UploadReportLogin.asmx");
				while (true)
				{
					((WebClientProtocol)this).set_Timeout(30000);
					if (!G1MWDipbbqYvai0A70v())
					{
						break;
					}
					switch (5)
					{
					case 1:
						goto end_IL_0003;
					case 0:
					case 4:
						goto end_IL_003a;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_003a:
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

	internal static bool G1MWDipbbqYvai0A70v()
	{
		return true;
	}

	internal static bool sIxXRVpMQ9cvbVYfh9R()
	{
		return false;
	}
}
