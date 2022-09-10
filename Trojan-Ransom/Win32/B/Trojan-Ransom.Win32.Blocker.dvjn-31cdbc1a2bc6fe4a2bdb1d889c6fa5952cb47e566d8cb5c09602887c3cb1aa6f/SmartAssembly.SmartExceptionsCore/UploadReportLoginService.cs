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
		((WebClientProtocol)this).set_Url(Class57.string_0 + "UploadReportLogin.asmx");
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { licenseID })[0];
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		WebRequest webRequest;
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		while (true)
		{
			webRequest = ((SoapHttpClientProtocol)this).GetWebRequest(uri);
			int num = 4;
			if (avhFRAX0PhgqPrEJXwn())
			{
				while (true)
				{
					switch (num)
					{
					default:
						num = 2;
						if (avhFRAX0PhgqPrEJXwn())
						{
							continue;
						}
						goto end_IL_002e;
					case 0:
					case 3:
						break;
					case 1:
					case 4:
						goto IL_0048;
					case 2:
						goto IL_0052;
					case 5:
						goto end_IL_002e;
					}
					break;
				}
				continue;
			}
			goto IL_0048;
			IL_0052:
			httpWebRequest.ServicePoint.Expect100Continue = false;
			break;
			IL_0048:
			httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest == null)
			{
				break;
			}
			goto IL_0052;
			continue;
			end_IL_002e:
			break;
		}
		return webRequest;
	}

	internal static bool avhFRAX0PhgqPrEJXwn()
	{
		return true;
	}

	internal static bool ygsEKYXeMlYKk75Xn2Q()
	{
		return false;
	}
}
