using System;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class32 : SoapHttpClientProtocol
{
	public Class32()
	{
		try
		{
			try
			{
				Win32.smethod_11((WebClientProtocol)(object)this, Form0.smethod_1(Class34.string_0, "UploadReportLogin.asmx", 403, 417), 724, 754);
				((WebClientProtocol)this).set_Timeout(30000);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, this);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string method_0(string string_0)
	{
		object[] array = default(object[]);
		string text = default(string);
		try
		{
			try
			{
				array = new object[1] { string_0 };
				text = (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", array)[0];
				return text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, array, this, string_0);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, array, text, this, string_0);
			throw;
		}
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		int num = default(int);
		WebRequest webRequest = default(WebRequest);
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		WebRequest webRequest2 = default(WebRequest);
		try
		{
			try
			{
				num = 5;
				webRequest = ((SoapHttpClientProtocol)this).GetWebRequest(uri);
				httpWebRequest = webRequest as HttpWebRequest;
				if (httpWebRequest != null)
				{
					HeaderControl.smethod_2(Form0.smethod_3(httpWebRequest, 121, 14), bool_0: false, 389, 386);
				}
				webRequest2 = webRequest;
				return webRequest2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, webRequest, httpWebRequest, this, uri);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException6(exception2, webRequest, httpWebRequest, webRequest2, num, this, uri);
			throw;
		}
	}

	static Class32()
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

	internal static string smethod_0(ResourceManager resourceManager_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					return resourceManager_0.GetString(string_0);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, resourceManager_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Thread thread_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 31:
					thread_0.IsBackground = bool_0;
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, thread_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_2(object object_0, object object_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 24:
					return object.ReferenceEquals(object_0, object_1);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, object_0, object_1, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_3(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 18:
					return fieldInfo_0.IsLiteral;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, fieldInfo_0, int_0, int_1);
			throw;
		}
	}
}
