using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class Class28 : SoapHttpClientProtocol
{
	public Class28()
	{
		try
		{
			((WebClientProtocol)this).set_Url(Class30.string_0 + "UploadReportLogin.asmx");
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
