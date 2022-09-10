using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ns10;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverUrl)
	{
		while (true)
		{
			((SoapHttpClientProtocol)this)._002Ector();
			if (rZ66evRTKbs9TNwMEYE())
			{
				switch (4)
				{
				case 0:
				case 1:
					continue;
				case 4:
					((WebClientProtocol)this).set_Url(serverUrl + Class32.smethod_0(7013));
					break;
				case 5:
					return;
				}
				break;
			}
			return;
		}
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class32.smethod_0(7034), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
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

	internal static bool rZ66evRTKbs9TNwMEYE()
	{
		return true;
	}

	internal static bool om5QWYRbF2lZBGAIKX9()
	{
		return false;
	}
}
