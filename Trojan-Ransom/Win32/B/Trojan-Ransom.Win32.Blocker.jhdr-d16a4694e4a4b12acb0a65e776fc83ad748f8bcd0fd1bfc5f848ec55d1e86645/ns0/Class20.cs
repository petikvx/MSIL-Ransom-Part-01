using System;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.StringsEncoding;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class20 : SoapHttpClientProtocol
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 144)]
	private struct Struct19
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[72];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	public Class20()
	{
		((WebClientProtocol)this).set_Url(Class22.string_0 + Strings.Get(3906));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string method_0(string string_0)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Strings.Get(3939), new object[1] { string_0 })[0];
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

	static Class20()
	{
		byte[] publicKeyToken;
		int num = (publicKeyToken = Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken()).Length;
		char[] array = new char[num];
		for (int i = 0; i < num; i++)
		{
			int num2 = i;
			int num3 = publicKeyToken[i] & 0xFF;
			array[num2] = (char)(num3 ^ (num3 << 5));
		}
		object_0 = array;
		array_1 = new string[4];
	}
}
