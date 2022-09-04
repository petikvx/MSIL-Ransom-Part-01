using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using ns4;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		Class42.hMqjKD0znI7T7();
		((SoapHttpClientProtocol)this)._002Ector();
		((WebClientProtocol)this).set_Url(Class37.string_0 + "UploadReportLogin.asmx");
		((WebClientProtocol)this).set_Timeout(30000);
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
}
