using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class31 : SoapHttpClientProtocol
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 23421)]
	private struct Struct33
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	public Class31()
	{
		((WebClientProtocol)this).set_Url(Class33.string_0 + "UploadReportLogin.asmx");
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
