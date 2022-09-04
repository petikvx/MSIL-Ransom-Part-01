using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using ns3;
using ns9;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService1 : SoapHttpClientProtocol
{
	public UploadReportLoginService1()
	{
		try
		{
			((WebClientProtocol)this).set_Url(Class52.string_0 + Class15.smethod_0(952340));
			((WebClientProtocol)this).set_Timeout(30000);
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, this);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		object[] array = default(object[]);
		try
		{
			string text = Class15.smethod_0(952373);
			array = new object[1] { licenseID };
			return (string)((SoapHttpClientProtocol)this).Invoke(text, array)[0];
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, array, this, licenseID);
			throw;
		}
	}
}
