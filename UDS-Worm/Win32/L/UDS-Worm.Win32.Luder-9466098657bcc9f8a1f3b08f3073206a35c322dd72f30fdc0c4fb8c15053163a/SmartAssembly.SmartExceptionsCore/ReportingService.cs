using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ns4;

namespace SmartAssembly.SmartExceptionsCore;

[GAttribute0(31)]
[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverURL)
	{
		((WebClientProtocol)this).set_Url(serverURL + "敒潰瑲湩\u2e67獡硭");
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("灕潬摡敒潰瑲", new object[2] { licenseID, data })[0];
	}
}
