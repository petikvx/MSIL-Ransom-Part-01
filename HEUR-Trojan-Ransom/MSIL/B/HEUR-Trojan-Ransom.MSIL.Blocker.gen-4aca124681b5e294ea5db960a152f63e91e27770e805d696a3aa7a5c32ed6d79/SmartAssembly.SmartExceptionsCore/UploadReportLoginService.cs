using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns4;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService : SoapHttpClientProtocol
{
	[NonSerialized]
	internal static GetString getString_0;

	public UploadReportLoginService()
	{
		((WebClientProtocol)this).set_Url(Class36.string_0 + getString_0(107387993));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(getString_0(107387960), new object[1] { licenseID })[0];
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

	static UploadReportLoginService()
	{
		Strings.CreateGetStringDelegate(typeof(UploadReportLoginService));
	}
}
