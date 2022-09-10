using System.Runtime.CompilerServices;
using System.Web.Services;
using System.Web.Services.Protocols;
using EkIJjm7vjs8xMISmTn;
using NCDRxx4R49CZy0gNBsi;
using whIMhj4tJEjkpHtDJe7;

namespace phhDPt4r3RFhLjHBgju;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class B9BPuc4UBPhdX9Vdby2 : SoapHttpClientProtocol
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public B9BPuc4UBPhdX9Vdby2()
	{
		//Discarded unreachable code: IL_002d
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					((WebClientProtocol)this).set_Url(MIdYYE4f4APnt0t3Mj1.NLiHHojZ7n + teuVAA2ghHDQmtOkUp.dYB2ebULO8(48687));
					goto case 3;
				default:
					num2 = 5;
					if (SROZxYgmHxpggt52MqL())
					{
						continue;
					}
					goto case 0;
				case 0:
				case 2:
					QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
					num2 = 4;
					if (!mGMfpYgJM4HHjYGf9Cc())
					{
						continue;
					}
					goto case 3;
				case 3:
				case 5:
					((WebClientProtocol)this).set_Timeout(30000);
					num = 6;
					break;
				case 4:
					((SoapHttpClientProtocol)this)._002Ector();
					num = 1;
					break;
				case 6:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		return (string)((SoapHttpClientProtocol)this).Invoke(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48720), new object[1] { licenseID })[0];
	}

	internal static bool SROZxYgmHxpggt52MqL()
	{
		return true;
	}

	internal static bool mGMfpYgJM4HHjYGf9Cc()
	{
		return false;
	}
}
