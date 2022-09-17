using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using _0023ab;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverUrl)
	{
		((WebClientProtocol)this).set_Url(serverUrl + _00239._00237(107393516));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(_00239._00237(107393527), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
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
}
