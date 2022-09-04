using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class22 : SoapHttpClientProtocol
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2004)]
	private struct Struct10
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[1002];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	public Class22()
	{
		try
		{
			((WebClientProtocol)this).set_Url(Class24.string_0 + "UploadReportLogin.asmx");
			((WebClientProtocol)this).set_Timeout(30000);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string method_0(string string_0)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[1] { string_0 };
			return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", array)[0];
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, array, this, string_0);
			throw;
		}
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		WebRequest webRequest = default(WebRequest);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		try
		{
			webRequest = ((SoapHttpClientProtocol)this).GetWebRequest(uri);
			httpWebRequest = webRequest as HttpWebRequest;
			if (httpWebRequest != null)
			{
				httpWebRequest.ServicePoint.Expect100Continue = false;
			}
			return webRequest;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException4(exception_, webRequest, httpWebRequest, this, uri);
			throw;
		}
	}

	static Class22()
	{
		char[] array = new char[8];
		array[2] = '⟫';
		array[5] = 'ᑷ';
		array[1] = '㛝';
		array[0] = 'क़';
		array[7] = '\u139c';
		array[6] = 'ߺ';
		array[4] = 'ᯚ';
		array[3] = '\u0ef5';
		array_2 = new string[64];
		array_0 = array;
	}
}
