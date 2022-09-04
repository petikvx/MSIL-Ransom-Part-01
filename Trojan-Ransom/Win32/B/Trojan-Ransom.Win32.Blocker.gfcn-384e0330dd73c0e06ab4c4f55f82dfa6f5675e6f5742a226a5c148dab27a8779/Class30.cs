using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal class Class30 : SoapHttpClientProtocol
{
	public Class30(string string_0)
	{
		Class52.KPUgGmhz2nAeI();
		((SoapHttpClientProtocol)this)._002Ector();
		((WebClientProtocol)this).set_Url(string_0 + "Reporting.asmx");
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("UploadReport2", new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}
}
