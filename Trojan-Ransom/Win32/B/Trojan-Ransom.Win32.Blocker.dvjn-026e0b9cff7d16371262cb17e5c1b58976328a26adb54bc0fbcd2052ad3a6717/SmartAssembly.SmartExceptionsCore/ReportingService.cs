using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

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
				((WebClientProtocol)this).set_Url(serverUrl + "Reporting.asmx");
				while (true)
				{
					((WebClientProtocol)this).set_Timeout(180000);
					if (!edekOnGA7yXpBCQwMBv())
					{
						switch (5)
						{
						case 1:
						case 4:
							goto end_IL_0003;
						case 0:
						case 2:
							goto end_IL_0039;
						case 5:
							return;
						}
						continue;
					}
					return;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_0039:
				break;
			}
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
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

	internal static bool hgYeGTGeJ0hyPxxLXTd()
	{
		return true;
	}

	internal static bool edekOnGA7yXpBCQwMBv()
	{
		return false;
	}
}
