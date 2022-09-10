using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class29 : SoapHttpClientProtocol
{
	public Class29()
	{
		try
		{
			((WebClientProtocol)this).set_Url(Class31.string_0 + Strings.Get(3906));
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
			string text = Strings.Get(3939);
			array = new object[1] { string_0 };
			return (string)((SoapHttpClientProtocol)this).Invoke(text, array)[0];
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array, this, string_0);
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
