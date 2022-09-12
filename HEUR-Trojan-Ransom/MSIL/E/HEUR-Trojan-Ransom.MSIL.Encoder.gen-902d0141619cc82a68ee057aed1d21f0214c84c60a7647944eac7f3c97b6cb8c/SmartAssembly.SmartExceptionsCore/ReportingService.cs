using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using _000E;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService : SoapHttpClientProtocol
{
	public ReportingService(string serverUrl)
	{
		((WebClientProtocol)this).set_Url(serverUrl + _000E._0003._0001(107394337));
		((WebClientProtocol)this).set_Timeout(180000);
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		//IL_0038: Incompatible stack heights: 0 vs 2
		//IL_003f: Incompatible stack heights: 0 vs 1
		//IL_0042: Incompatible stack heights: 0 vs 4
		//IL_0045: Incompatible stack heights: 0 vs 3
		//IL_0048: Incompatible stack heights: 0 vs 3
		//IL_004c: Incompatible stack heights: 0 vs 3
		//IL_0050: Incompatible stack heights: 0 vs 3
		//IL_0057: Incompatible stack heights: 0 vs 1
		_ = _0081_0002._008C_0004;
		_000E._0003._0001(107394316);
		_ = new object[5];
		_ = 0;
		((object[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = (object)/*Error near IL_0019: Stack underflow*/;
		/*Error near IL_0019: Stack underflow*/;
		_ = 1;
		((object[])/*Error near IL_001e: Stack underflow*/)[/*Error near IL_001e: Stack underflow*/] = (object)/*Error near IL_001e: Stack underflow*/;
		/*Error near IL_001e: Stack underflow*/;
		_ = 2;
		((object[])/*Error near IL_0023: Stack underflow*/)[/*Error near IL_0023: Stack underflow*/] = (object)/*Error near IL_0023: Stack underflow*/;
		/*Error near IL_0023: Stack underflow*/;
		_ = 3;
		((object[])/*Error near IL_0028: Stack underflow*/)[/*Error near IL_0028: Stack underflow*/] = (object)/*Error near IL_0028: Stack underflow*/;
		/*Error near IL_0028: Stack underflow*/;
		_ = 4;
		((object[])/*Error near IL_002d: Stack underflow*/)[/*Error near IL_002d: Stack underflow*/] = (object)/*Error near IL_002d: Stack underflow*/;
		/*Error near IL_0057: Stack underflow*/((object)/*Error near IL_0057: Stack underflow*/, (string)/*Error near IL_0057: Stack underflow*/, (object[])/*Error near IL_0057: Stack underflow*/);
		return (string)((object[])/*Error near IL_0031: Stack underflow*/)[0];
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
