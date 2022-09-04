using System.Web.Services;
using System.Web.Services.Protocols;
using ns6;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal class UploadReportLoginService2 : SoapHttpClientProtocol
{
	public UploadReportLoginService2()
	{
		((WebClientProtocol)this).set_Url(Class21.string_0 + "UploadReportLogin.asmx");
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("GetServerURL", new object[1] { licenseID })[0];
	}
}
