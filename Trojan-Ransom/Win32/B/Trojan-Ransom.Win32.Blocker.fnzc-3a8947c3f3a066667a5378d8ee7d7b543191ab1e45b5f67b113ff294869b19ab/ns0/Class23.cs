using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class23 : SoapHttpClientProtocol
{
	public Class23(string string_0)
	{
		((WebClientProtocol)this).set_Url(Class35.smethod_8(string_0, "Reporting.asmx", 409, 503));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string method_0(string string_0, [XmlElement(DataType = "base64Binary")] byte[] byte_0, string string_1, string string_2, string string_3)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", new object[5] { string_0, byte_0, string_1, string_2, string_3 })[0];
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

	[SecuritySafeCritical]
	static Class23()
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
			case 54:
				Array.Copy(array_0, int_0, array_1, int_1, int_2);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 50:
				ProjectData.ClearProjectError();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 71:
				Console.WriteLine(string_0);
				return;
			case 72:
				File.Delete(string_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_3(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 103:
				return assemblyName_0.GetPublicKey();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(Label label_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 98:
				label_0.set_FlatStyle(flatStyle_0);
				return;
			}
		}
	}
}
