using System;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService : SoapHttpClientProtocol
{
	[NonSerialized]
	internal static GetString getString_0;

	static ReportingService()
	{
		Strings.CreateGetStringDelegate(typeof(ReportingService));
	}

	public ReportingService(string string_0)
	{
		((WebClientProtocol)this).set_Url(string_0 + getString_0(3883));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(getString_0(3904), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}
}
