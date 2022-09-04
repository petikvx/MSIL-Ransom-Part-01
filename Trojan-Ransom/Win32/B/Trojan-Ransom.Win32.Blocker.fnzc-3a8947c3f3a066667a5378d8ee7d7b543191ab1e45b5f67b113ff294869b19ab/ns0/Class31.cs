using System;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Security;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class31 : SoapHttpClientProtocol
{
	public Class31()
	{
		try
		{
			((WebClientProtocol)this).set_Url(Class35.smethod_8(Class33.string_0, "UploadReportLogin.asmx", 38, 72));
			((WebClientProtocol)this).set_Timeout(30000);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array, this, string_0);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, webRequest, httpWebRequest, this, uri);
			throw;
		}
	}

	[SecuritySafeCritical]
	static Class31()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Array array_0, int int_0, Array array_1, int int_1, int int_2, int int_3, int int_4)
	{
		while (true)
		{
			switch (int_4 ^ int_3)
			{
			case 49:
				Buffer.BlockCopy(array_0, int_0, array_1, int_1, int_2);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Size smethod_1(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return control_0.get_ClientSize();
			}
		}
	}

	[SecuritySafeCritical]
	internal static FieldInfo smethod_2(Type type_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return type_0.GetField(string_0);
			}
		}
	}
}
