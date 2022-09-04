using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ns3;
using ns9;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService1 : SoapHttpClientProtocol
{
	public ReportingService1(string string_0)
	{
		try
		{
			((WebClientProtocol)this).set_Url(string_0 + Class15.smethod_0(952390));
			((WebClientProtocol)this).set_Timeout(180000);
		}
		catch (Exception exception_)
		{
			Class38.smethod_2(exception_, this, string_0);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		object[] array = default(object[]);
		try
		{
			string text = Class15.smethod_0(952411);
			array = new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber };
			return (string)((SoapHttpClientProtocol)this).Invoke(text, array)[0];
		}
		catch (Exception exception_)
		{
			Class38.smethod_7(exception_, array, this, licenseID, data, email, appFriendlyName, buildFriendlyNumber);
			throw;
		}
	}
}
