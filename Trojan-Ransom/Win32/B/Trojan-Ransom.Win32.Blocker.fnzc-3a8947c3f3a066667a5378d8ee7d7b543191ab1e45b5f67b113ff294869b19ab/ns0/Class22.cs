using System;
using System.Net;
using System.Reflection;
using System.Security;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class22 : SoapHttpClientProtocol
{
	public Class22()
	{
		((WebClientProtocol)this).set_Url(Class35.smethod_8(Class24.string_0, "UploadReportLogin.asmx", 870, 776));
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

	[SecuritySafeCritical]
	static Class22()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static Type smethod_0(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				return assembly_0.GetType(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(ButtonBase buttonBase_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				buttonBase_0.set_Text(string_0);
				return;
			}
		}
	}
}
