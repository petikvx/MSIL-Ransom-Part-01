using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService1 : SoapHttpClientProtocol
{
	public ReportingService1(string serverUrl)
	{
		try
		{
			((WebClientProtocol)this).set_Url(serverUrl + "Reporting.asmx");
			((WebClientProtocol)this).set_Timeout(180000);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, serverUrl);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		object[] array = default(object[]);
		try
		{
			array = new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber };
			return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", array)[0];
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, array, this, licenseID, data, email, appFriendlyName, buildFriendlyNumber);
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
