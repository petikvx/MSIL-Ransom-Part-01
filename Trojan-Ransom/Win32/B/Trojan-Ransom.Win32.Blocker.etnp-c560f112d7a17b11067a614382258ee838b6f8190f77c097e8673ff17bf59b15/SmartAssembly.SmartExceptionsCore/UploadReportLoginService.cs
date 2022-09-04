using System.Web.Services;
using System.Web.Services.Protocols;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		((WebClientProtocol)this).set_Url(Class33.string_0 + Class5.smethod_0(82454));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class5.smethod_0(82487), new object[1] { licenseID })[0];
	}
}
