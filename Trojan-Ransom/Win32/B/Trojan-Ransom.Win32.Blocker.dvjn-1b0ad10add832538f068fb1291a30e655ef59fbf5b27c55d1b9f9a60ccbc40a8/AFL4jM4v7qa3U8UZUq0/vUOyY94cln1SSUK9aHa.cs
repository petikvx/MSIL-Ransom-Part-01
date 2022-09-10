using System.Runtime.CompilerServices;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using EkIJjm7vjs8xMISmTn;
using NCDRxx4R49CZy0gNBsi;

namespace AFL4jM4v7qa3U8UZUq0;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class vUOyY94cln1SSUK9aHa : SoapHttpClientProtocol
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public vUOyY94cln1SSUK9aHa(string _0020)
	{
		//Discarded unreachable code: IL_0052
		int num = 5;
		if (1 == 0)
		{
			goto IL_000c;
		}
		goto IL_005f;
		IL_005f:
		while (true)
		{
			switch (num)
			{
			case 1:
			case 4:
				break;
			case 0:
			case 3:
				goto IL_001e;
			case 2:
				((WebClientProtocol)this).set_Url(_0020 + teuVAA2ghHDQmtOkUp.dYB2ebULO8(48737));
				goto IL_001e;
			default:
				num = 0;
				if (true)
				{
					continue;
				}
				goto case 5;
			case 5:
				QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
				num = 4;
				if (vUxHBagYSVKvJB2jvMA())
				{
					continue;
				}
				return;
			case 6:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_001e:
		((WebClientProtocol)this).set_Timeout(180000);
		int num2 = 6;
		num = num2;
		goto IL_005f;
		IL_000c:
		((SoapHttpClientProtocol)this)._002Ector();
		num = 2;
		if (false)
		{
			goto IL_001e;
		}
		goto IL_005f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48758), new object[5] { licenseID, data, email, appFriendlyName, buildFriendlyNumber })[0];
	}

	internal static bool vUxHBagYSVKvJB2jvMA()
	{
		return true;
	}

	internal static bool dUIwqUgbUCcnp7GW9Bq()
	{
		return false;
	}
}
