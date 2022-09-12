using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService1 : SoapHttpClientProtocol
{
	[NonSerialized]
	internal static GetString getString_0;

	public ReportingService1(string serverUrl)
	{
		((WebClientProtocol)this).set_Url(serverUrl + getString_0(107388122));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(getString_0(107388101), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
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

	static ReportingService1()
	{
		Strings.CreateGetStringDelegate(typeof(ReportingService1));
	}
}
