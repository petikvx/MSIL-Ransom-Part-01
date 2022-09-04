using System.Web.Services;
using System.Web.Services.Protocols;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		Class2.l4t8M9wzGUypc();
		((SoapHttpClientProtocol)this)._002Ector();
		((WebClientProtocol)this).set_Url(WebServicesClient.UploadReportServer + "UploadReportLogin.asmx");
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { licenseID })[0];
	}
}
