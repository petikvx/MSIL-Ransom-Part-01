using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using _0002;
using _000E;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService : SoapHttpClientProtocol
{
	public UploadReportLoginService()
	{
		_ = _0002._0007._0001;
		((WebClientProtocol)this).set_Url(_0002._0007._0001 + _000E._0003._0001(107394419));
		((WebClientProtocol)this).set_Timeout(30000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		//IL_0024: Incompatible stack heights: 0 vs 2
		//IL_002b: Incompatible stack heights: 0 vs 1
		//IL_002e: Incompatible stack heights: 0 vs 4
		//IL_0035: Incompatible stack heights: 0 vs 1
		_ = _0081_0002._008C_0004;
		_000E._0003._0001(107394386);
		_ = new object[1];
		_ = 0;
		((object[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = (object)/*Error near IL_0019: Stack underflow*/;
		/*Error near IL_0035: Stack underflow*/((object)/*Error near IL_0035: Stack underflow*/, (string)/*Error near IL_0035: Stack underflow*/, (object[])/*Error near IL_0035: Stack underflow*/);
		return (string)((object[])/*Error near IL_001d: Stack underflow*/)[0];
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		//IL_002d: Incompatible stack heights: 0 vs 2
		//IL_0030: Incompatible stack heights: 0 vs 1
		//IL_0033: Incompatible stack heights: 0 vs 1
		//IL_0036: Incompatible stack heights: 0 vs 1
		//IL_0039: Incompatible stack heights: 0 vs 3
		//IL_0040: Incompatible stack heights: 0 vs 1
		_ = _0082_0002._008D_0004;
		HttpWebRequest httpWebRequest = /*Error near IL_000e: Stack underflow*/((object)/*Error near IL_000e: Stack underflow*/, (Uri)/*Error near IL_000e: Stack underflow*/) as HttpWebRequest;
		if ((int)/*Error near IL_001a: Stack underflow*/ != 0)
		{
			_ = _0084_0002._007E_008F_0004;
			_ = _0083_0002._007E_008E_0004;
			/*Error near IL_0040: Stack underflow*/((object)/*Error near IL_0040: Stack underflow*/);
			/*Error near IL_0047: Stack underflow*/((object)/*Error near IL_0047: Stack underflow*/, false);
		}
		return (WebRequest)/*Error near IL_002c: Stack underflow*/;
	}
}
