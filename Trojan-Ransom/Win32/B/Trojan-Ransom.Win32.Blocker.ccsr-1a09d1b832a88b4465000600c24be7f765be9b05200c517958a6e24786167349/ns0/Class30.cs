using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class30 : SoapHttpClientProtocol
{
	public Class30(string string_0)
	{
		try
		{
			Class37.smethod_1((WebClientProtocol)(object)this, ReportSender.smethod_0(string_0, "Reporting.asmx", 855, 820), 643, 733);
			((WebClientProtocol)this).set_Timeout(180000);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, string_0);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string method_0(string string_0, [XmlElement(DataType = "base64Binary")] byte[] byte_0, string string_1, string string_2, string string_3)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[5] { string_0, byte_0, string_1, string_2, string_3 };
			return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", array)[0];
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, array, this, string_0, byte_0, string_1, string_2, string_3);
			throw;
		}
	}

	static Class30()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static IDictionary smethod_0(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				return exception_0.Data;
			}
		}
	}

	internal static void smethod_1(Label label_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 32:
				label_0.set_FlatStyle(flatStyle_0);
				return;
			}
		}
	}

	internal static void smethod_2(Component component_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				component_0.Dispose();
				return;
			}
		}
	}

	internal static AppDomain smethod_3(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return AppDomain.CurrentDomain;
			}
		}
	}

	internal static void smethod_4(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 93:
				ProjectData.SetProjectError(exception_0);
				return;
			}
		}
	}

	internal static void smethod_5(Control control_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				control_0.set_Size(size_0);
				return;
			}
		}
	}

	internal static int smethod_6(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return dateTime_0.Hour;
			}
		}
	}
}
