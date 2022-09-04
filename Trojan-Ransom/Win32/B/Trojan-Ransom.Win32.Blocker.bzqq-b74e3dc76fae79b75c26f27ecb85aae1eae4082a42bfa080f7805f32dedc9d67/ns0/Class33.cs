using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class33 : SoapHttpClientProtocol
{
	public Class33(string string_0)
	{
		try
		{
			try
			{
				Win32.smethod_11((WebClientProtocol)(object)this, Form0.smethod_1(string_0, "Reporting.asmx", 1009, 963), 808, 782);
				SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_4((WebClientProtocol)(object)this, 180000, 711, 733);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, string_0);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, this, string_0);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string method_0(string string_0, [XmlElement(DataType = "base64Binary")] byte[] byte_0, string string_1, string string_2, string string_3)
	{
		object[] array = default(object[]);
		string text = default(string);
		try
		{
			try
			{
				array = new object[5] { string_0, byte_0, string_1, string_2, string_3 };
				text = (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", array)[0];
				return text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException7(exception, array, this, string_0, byte_0, string_1, string_2, string_3);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException8(exception2, array, text, this, string_0, byte_0, string_1, string_2, string_3);
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
				num = 2;
				webRequest = ((SoapHttpClientProtocol)this).GetWebRequest(uri);
				httpWebRequest = webRequest as HttpWebRequest;
				if (httpWebRequest != null)
				{
					HeaderControl.smethod_2(Form0.smethod_3(httpWebRequest, 501, 386), bool_0: false, 193, 198);
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

	static Class33()
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

	internal static Encoding smethod_0(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					return Encoding.UTF8;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static Exception smethod_1(int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 115:
					return ProjectData.CreateProjectError(int_0);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, int_0, int_1, int_2);
			throw;
		}
	}

	internal static void smethod_2(Timer timer_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 88:
					timer_0.set_Enabled(bool_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, timer_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_3(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					return control_0.get_Width();
				case 91:
					return control_0.get_Height();
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_4(ref Rectangle rectangle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 99:
					return rectangle_0.Bottom;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, rectangle_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_5(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 48:
					return control_0.get_Width();
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}
}
