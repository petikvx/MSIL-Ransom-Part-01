using System;
using System.Collections;
using System.Net;
using System.Security.Cryptography;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class23 : SoapHttpClientProtocol
{
	public Class23()
	{
		try
		{
			Win32.smethod_11((WebClientProtocol)(object)this, Form0.smethod_1(Class25.string_0, "UploadReportLogin.asmx", 610, 592), 921, 959);
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
			int num = default(int);
			StackFrameHelper.CreateException4(exception, array, num, this, string_0);
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
				Form0.smethod_3(httpWebRequest, 783, 888).Expect100Continue = false;
			}
			return webRequest;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException5(exception, webRequest, httpWebRequest, num, this, uri);
			throw;
		}
	}

	static Class23()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_0(AsymmetricAlgorithm asymmetricAlgorithm_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 85:
					asymmetricAlgorithm_0.FromXmlString(string_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, asymmetricAlgorithm_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static IDictionary smethod_1(Exception exception_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 117:
					return exception_0.Data;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, exception_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Timer timer_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 98:
					timer_0.set_Interval(int_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, timer_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static string smethod_3(ref byte byte_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 88:
					return byte_0.ToString(string_0);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, byte_0, string_0, int_0, int_1);
			throw;
		}
	}
}
