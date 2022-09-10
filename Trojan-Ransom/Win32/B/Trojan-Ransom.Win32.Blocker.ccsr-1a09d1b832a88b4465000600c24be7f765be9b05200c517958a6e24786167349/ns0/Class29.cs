using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class29 : SoapHttpClientProtocol
{
	public Class29()
	{
		try
		{
			Class37.smethod_1((WebClientProtocol)(object)this, ReportSender.smethod_0(Class31.string_0, "UploadReportLogin.asmx", 745, 650), 23, 73);
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

	static Class29()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static char smethod_0(string string_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 91:
				return string_0[int_0];
			}
		}
	}

	internal static Process smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 78:
				return Process.Start(string_0);
			}
		}
	}

	internal static IntPtr smethod_2(Graphics graphics_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 119:
				return graphics_0.GetHdc();
			}
		}
	}

	internal static string smethod_3(ref ulong ulong_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 76:
				return ulong_0.ToString(string_0);
			}
		}
	}

	internal static StringBuilder smethod_4(StringBuilder stringBuilder_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 57:
				return stringBuilder_0.Append(string_0);
			}
		}
	}

	internal static void smethod_5(Stream stream_0, long long_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 19:
				stream_0.Position = long_0;
				return;
			}
		}
	}

	internal static bool smethod_6(object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return object.ReferenceEquals(object_0, object_1);
			}
		}
	}

	internal static int smethod_7(Array array_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return array_0.Rank;
			}
		}
	}
}
