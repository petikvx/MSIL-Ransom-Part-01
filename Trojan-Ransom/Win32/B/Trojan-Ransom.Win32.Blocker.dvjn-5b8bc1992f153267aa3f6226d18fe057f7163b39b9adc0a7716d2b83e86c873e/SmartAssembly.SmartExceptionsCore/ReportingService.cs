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
		if (P1v1Jrv6BQXp8W7Um9f())
		{
		}
		switch (4)
		{
		case 4:
			((SoapHttpClientProtocol)this)._002Ector();
			goto case 0;
		case 0:
		case 1:
			((WebClientProtocol)this).set_Url(serverUrl + "Reporting.asmx");
			break;
		case 5:
			return;
		}
		((WebClientProtocol)this).set_Timeout(180000);
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

	internal static bool ddkymDvbguZdsLM1yRo()
	{
		return true;
	}

	internal static bool P1v1Jrv6BQXp8W7Um9f()
	{
		return false;
	}
}
