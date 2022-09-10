using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;

namespace ns0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class Class30 : SoapHttpClientProtocol
{
	public Class30(string string_0)
	{
		try
		{
			((WebClientProtocol)this).set_Url(string_0 + Strings.Get(3956));
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
			string text = Strings.Get(3977);
			array = new object[5] { string_0, byte_0, string_1, string_2, string_3 };
			return (string)((SoapHttpClientProtocol)this).Invoke(text, array)[0];
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
}
