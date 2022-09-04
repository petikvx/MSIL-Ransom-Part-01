using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using ProwxkN4F4ab5Fc8FL;

namespace YQdkshYRTPnDUG0oU0n;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class U26uN4YXm6M4Y337HP6 : SoapHttpClientProtocol
{
	public U26uN4YXm6M4Y337HP6(string string_0)
	{
		while (true)
		{
			((SoapHttpClientProtocol)this)._002Ector();
			if (pnEj4U45C7i36njChve())
			{
				switch (2)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 2:
					goto IL_0033;
				default:
					goto end_IL_0001;
				case 5:
					return;
				}
				continue;
			}
			goto IL_0033;
			IL_0033:
			((WebClientProtocol)this).set_Url(string_0 + DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681816));
			break;
			continue;
			end_IL_0001:
			break;
		}
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(681837), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}

	internal static bool pnEj4U45C7i36njChve()
	{
		return true;
	}

	internal static bool WtPb4J42MHldN82Fg3G()
	{
		return false;
	}
}
