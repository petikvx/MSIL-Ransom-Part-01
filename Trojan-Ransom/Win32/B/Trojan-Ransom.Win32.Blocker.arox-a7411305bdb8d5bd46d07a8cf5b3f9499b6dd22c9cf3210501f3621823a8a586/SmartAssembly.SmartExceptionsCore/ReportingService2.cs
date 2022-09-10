using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService2 : SoapHttpClientProtocol
{
	public ReportingService2(string serverURL)
	{
		((WebClientProtocol)this).set_Url(serverURL + "Reporting.asmx");
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}
}
