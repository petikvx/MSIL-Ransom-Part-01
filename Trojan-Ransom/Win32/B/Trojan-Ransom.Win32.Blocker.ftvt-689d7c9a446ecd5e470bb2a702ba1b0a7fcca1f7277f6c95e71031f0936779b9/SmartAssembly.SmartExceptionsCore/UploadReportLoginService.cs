using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns3;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService : SoapHttpClientProtocol
{
	[NonSerialized]
	internal static GetString getString_0;

	static UploadReportLoginService()
	{
		Strings.CreateGetStringDelegate(typeof(UploadReportLoginService));
	}

	public UploadReportLoginService()
	{
		((WebClientProtocol)this).set_Url(Class13.string_0 + getString_0(3832));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(getString_0(3865), new object[1] { licenseID })[0];
	}
}
