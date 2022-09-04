using System.Web.Services;
using System.Web.Services.Protocols;
using DnJ9w2YbLkixCnLn9Wn;
using ProwxkN4F4ab5Fc8FL;

namespace hVmeblYkSgCICUGqF6u;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class icVuMXYhmRPEKKjpqSK : SoapHttpClientProtocol
{
	public icVuMXYhmRPEKKjpqSK()
	{
		if (Flsx984PnIMTyfrLAtW())
		{
		}
		switch (2)
		{
		case 0:
		case 2:
			((SoapHttpClientProtocol)this)._002Ector();
			goto case 1;
		case 1:
		case 4:
			((WebClientProtocol)this).set_Url(HrPghwYWiu38dAc2w6r.KTfARHMNs5 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681766));
			break;
		case 5:
			return;
		}
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681799), new object[1] { licenseID })[0];
	}

	internal static bool cTtHrh4FwFp6AjyA8JU()
	{
		return true;
	}

	internal static bool Flsx984PnIMTyfrLAtW()
	{
		return false;
	}
}
