using System.Web.Services;
using System.Web.Services.Protocols;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class Class29 : SoapHttpClientProtocol
{
	public Class29()
	{
		Class52.KPUgGmhz2nAeI();
		((SoapHttpClientProtocol)this)._002Ector();
		((WebClientProtocol)this).set_Url(Class31.string_0 + "UploadReportLogin.asmx");
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { licenseID })[0];
	}
}
