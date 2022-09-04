using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ns9;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string string_0)
	{
		((WebClientProtocol)this).set_Url(string_0 + Class15.smethod_0(952390));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class15.smethod_0(952411), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}
}
