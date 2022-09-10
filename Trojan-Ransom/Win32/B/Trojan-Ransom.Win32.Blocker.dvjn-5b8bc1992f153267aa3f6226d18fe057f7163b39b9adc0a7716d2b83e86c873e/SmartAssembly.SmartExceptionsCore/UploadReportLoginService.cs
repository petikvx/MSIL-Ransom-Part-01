using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using ns11;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		while (true)
		{
			((SoapHttpClientProtocol)this)._002Ector();
			if (qbmd38v058C5ZXIrVSm())
			{
			}
			switch (4)
			{
			case 0:
				continue;
			case 5:
				return;
			}
			((WebClientProtocol)this).set_Url(Class56.string_0 + "UploadReportLogin.asmx");
			((WebClientProtocol)this).set_Timeout(30000);
			return;
		}
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

	internal static bool f0cdvYv7gRp0Z1fwEtD()
	{
		return true;
	}

	internal static bool qbmd38v058C5ZXIrVSm()
	{
		return false;
	}
}
