using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using ns10;
using ns12;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		((WebClientProtocol)this).set_Url(Class58.string_0 + Class32.smethod_0(6963));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class32.smethod_0(6996), new object[1] { licenseID })[0];
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

	internal static bool LNoG4ERymMU1N9YbrBy()
	{
		return true;
	}

	internal static bool osAOPQRt41aeCGAVPx9()
	{
		return false;
	}
}
