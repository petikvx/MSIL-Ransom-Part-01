using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverURL)
	{
		((WebClientProtocol)this).set_Url(serverURL + Class5.smethod_0(82504));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class5.smethod_0(82525), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}
}
