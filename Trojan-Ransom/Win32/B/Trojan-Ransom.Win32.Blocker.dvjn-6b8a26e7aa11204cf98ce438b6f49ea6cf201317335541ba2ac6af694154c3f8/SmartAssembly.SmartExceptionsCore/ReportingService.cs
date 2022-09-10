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
		while (true)
		{
			((SoapHttpClientProtocol)this)._002Ector();
			while (true)
			{
				IL_0039:
				((WebClientProtocol)this).set_Url(serverUrl + Class14.smethod_0(3144));
				while (true)
				{
					((WebClientProtocol)this).set_Timeout(180000);
					if (IO60jh4bF11Asavy2qg())
					{
						break;
					}
					switch (5)
					{
					case 1:
					case 4:
						goto IL_0039;
					case 0:
					case 3:
						goto end_IL_0003;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				break;
			}
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class14.smethod_0(3165), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
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

	internal static bool J9ZJ7N47Gv0wUrVlCNG()
	{
		return true;
	}

	internal static bool IO60jh4bF11Asavy2qg()
	{
		return false;
	}
}
