using System;
using System.Net;
using System.Security;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class32 : SoapHttpClientProtocol
{
	private static bool bool_0;

	public Class32(string string_0)
	{
		try
		{
			((WebClientProtocol)this).set_Url(Class35.smethod_8(string_0, "Reporting.asmx", 796, 882));
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
	static Class32()
	{
		smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(XmlWriter xmlWriter_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				xmlWriter_0.WriteStartElement(string_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1()
	{
		if (bool_0)
		{
			return;
		}
		lock (typeof(Class32))
		{
			if (!bool_0)
			{
				bool_0 = true;
				AppDomain.CurrentDomain.ResourceResolve += ReportSender.smethod_0;
			}
		}
	}
}
