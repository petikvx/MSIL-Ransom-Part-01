using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class20 : SoapHttpClientProtocol
{
	public Class20()
	{
		Class37.smethod_1((WebClientProtocol)(object)this, ReportSender.smethod_0(Class22.string_0, "UploadReportLogin.asmx", 189, 222), 582, 536);
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string method_0(string string_0)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { string_0 })[0];
	}

	static Class20()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static MethodInfo smethod_0(Type type_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return type_0.GetMethod(string_0);
			}
		}
	}

	internal static void smethod_1(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				symmetricAlgorithm_0.GenerateKey();
				return;
			}
		}
	}

	internal static Encoding smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return Encoding.UTF8;
			}
		}
	}

	internal static int smethod_3(int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 28:
				return Math.Min(int_0, int_1);
			}
		}
	}

	internal static string smethod_4(Encoding encoding_0, byte[] byte_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 35:
				return encoding_0.GetString(byte_0);
			}
		}
	}

	internal static MethodInfo smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 22:
				return assembly_0.EntryPoint;
			}
		}
	}

	internal static string smethod_6(Assembly assembly_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 54:
				return assembly_0.Location;
			}
		}
	}
}
