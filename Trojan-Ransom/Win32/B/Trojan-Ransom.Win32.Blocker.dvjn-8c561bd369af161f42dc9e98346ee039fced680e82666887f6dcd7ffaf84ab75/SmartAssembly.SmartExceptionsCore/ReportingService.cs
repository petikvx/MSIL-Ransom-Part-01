using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ns7;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverUrl)
	{
		((WebClientProtocol)this).set_Url(serverUrl + Class14.smethod_0(6853));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class14.smethod_0(6874), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		int num = 0;
		WebRequest webRequest = default(WebRequest);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		if (!LYss99rkgXFn3CDE0WI())
		{
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					if (sPguTvrhRPbSZgSTWWI())
					{
						continue;
					}
					goto case 0;
				case 0:
					webRequest = ((SoapHttpClientProtocol)this).GetWebRequest(uri);
					goto case 1;
				case 1:
				case 3:
					httpWebRequest = webRequest as HttpWebRequest;
					break;
				case 2:
				case 4:
					break;
				case 5:
					goto IL_0059;
				}
				break;
			}
		}
		if (httpWebRequest != null)
		{
			httpWebRequest.ServicePoint.Expect100Continue = false;
		}
		goto IL_0059;
		IL_0059:
		return webRequest;
	}

	internal static bool sPguTvrhRPbSZgSTWWI()
	{
		return true;
	}

	internal static bool LYss99rkgXFn3CDE0WI()
	{
		return false;
	}
}
