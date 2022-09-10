using System.Web.Services;
using System.Web.Services.Protocols;
using ns4;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
[GAttribute0(30)]
internal class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		((WebClientProtocol)this).set_Url("瑨灴⼺眯睷献慭瑲獡敳扭祬挮浯眯扥敳癲捩獥唯汰慯剤灥牯䱴杯湩愮浳");
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke("敇却牥敶啲䱒", new object[1] { licenseID })[0];
	}
}
