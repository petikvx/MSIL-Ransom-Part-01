using System.Web.Services;
using System.Web.Services.Protocols;
using ns4;
using ns9;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		((WebClientProtocol)this).set_Url(Class42.string_0 + Class15.smethod_0(952340));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(Class15.smethod_0(952373), new object[1] { licenseID })[0];
	}
}
