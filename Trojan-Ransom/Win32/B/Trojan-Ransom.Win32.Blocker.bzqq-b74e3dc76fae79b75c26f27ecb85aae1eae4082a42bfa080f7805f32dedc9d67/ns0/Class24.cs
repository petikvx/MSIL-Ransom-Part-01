using System;
using System.Net;
using System.Reflection;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class24 : SoapHttpClientProtocol
{
	public Class24(string string_0)
	{
		try
		{
			Win32.smethod_11((WebClientProtocol)(object)this, Form0.smethod_1(string_0, "Reporting.asmx", 106, 88), 789, 819);
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
			int num = default(int);
			StackFrameHelper.CreateException8(exception, array, num, this, string_0, byte_0, string_1, string_2, string_3);
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
				Form0.smethod_3(httpWebRequest, 511, 392).Expect100Continue = false;
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

	static Class24()
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

	internal static int smethod_0(ref DateTime dateTime_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 126:
					return dateTime_0.Minute;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, dateTime_0, int_0, int_1);
			throw;
		}
	}

	internal static Type smethod_1(FieldInfo fieldInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return fieldInfo_0.FieldType;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, fieldInfo_0, int_0, int_1);
			throw;
		}
	}
}
