using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml.Serialization;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class21 : SoapHttpClientProtocol
{
	public Class21(string string_0)
	{
		Class37.smethod_1((WebClientProtocol)(object)this, ReportSender.smethod_0(string_0, "Reporting.asmx", 407, 500), 766, 672);
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string method_0(string string_0, [XmlElement(DataType = "base64Binary")] byte[] byte_0, string string_1, string string_2, string string_3)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", new object[5] { string_0, byte_0, string_1, string_2, string_3 })[0];
	}

	static Class21()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static Stream smethod_0(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 91:
				return assembly_0.GetManifestResourceStream(string_0);
			}
		}
	}

	internal static byte[] smethod_1(RSACryptoServiceProvider rsacryptoServiceProvider_0, byte[] byte_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return rsacryptoServiceProvider_0.Encrypt(byte_0, bool_0);
			}
		}
	}

	internal static int smethod_2(ref Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 79:
				return color_0.ToArgb();
			}
		}
	}

	internal static void smethod_3(Control control_0, Color color_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				control_0.set_BackColor(color_0);
				return;
			}
		}
	}

	internal static PlatformID smethod_4(OperatingSystem operatingSystem_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				return operatingSystem_0.Platform;
			}
		}
	}
}
