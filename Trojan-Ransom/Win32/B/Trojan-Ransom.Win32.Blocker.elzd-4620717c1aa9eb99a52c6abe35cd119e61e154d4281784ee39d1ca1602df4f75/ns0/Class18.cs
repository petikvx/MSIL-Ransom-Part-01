using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class18 : SoapHttpClientProtocol
{
	public Class18()
	{
		((WebClientProtocol)this).set_Url(Class20.string_0 + "UploadReportLogin.asmx");
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string method_0(string string_0)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { string_0 })[0];
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
