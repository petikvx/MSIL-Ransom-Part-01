using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
using _0005;
using _000E;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "ReportingServiceSoap", Namespace = "http://www.smartassembly.com/webservices/Reporting/")]
internal sealed class ReportingService1 : SoapHttpClientProtocol
{
	public ReportingService1(string serverUrl)
	{
		try
		{
			((WebClientProtocol)this).set_Url(serverUrl + _000E._0003._0001(107394337));
			((WebClientProtocol)this).set_Timeout(180000);
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex, (object)this, (object)serverUrl);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/Reporting/UploadReport2")]
	public string UploadReport2(string licenseID, [XmlElement(DataType = "base64Binary")] byte[] data, string email, string appFriendlyName, string buildFriendlyNumber)
	{
		//IL_003b: Incompatible stack heights: 0 vs 2
		//IL_0042: Incompatible stack heights: 0 vs 1
		//IL_0045: Incompatible stack heights: 0 vs 4
		//IL_0048: Incompatible stack heights: 0 vs 3
		//IL_004b: Incompatible stack heights: 0 vs 3
		//IL_004f: Incompatible stack heights: 0 vs 3
		//IL_0053: Incompatible stack heights: 0 vs 3
		//IL_005a: Incompatible stack heights: 0 vs 1
		try
		{
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
			/*Error near IL_005a: Stack underflow*/((object)/*Error near IL_005a: Stack underflow*/, (string)/*Error near IL_005a: Stack underflow*/, (object[])/*Error near IL_005a: Stack underflow*/);
			return (string)((object[])/*Error near IL_0031: Stack underflow*/)[0];
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex, (object)this, (object)licenseID, (object)data, (object)email, (object)appFriendlyName, (object)buildFriendlyNumber);
			throw;
		}
	}

	protected override WebRequest GetWebRequest(Uri uri)
	{
		//IL_0033: Incompatible stack heights: 0 vs 2
		//IL_0036: Incompatible stack heights: 0 vs 1
		//IL_0039: Incompatible stack heights: 0 vs 1
		//IL_003c: Incompatible stack heights: 0 vs 1
		//IL_003f: Incompatible stack heights: 0 vs 3
		//IL_0046: Incompatible stack heights: 0 vs 1
		//IL_0060: Incompatible stack heights: 0 vs 1
		HttpWebRequest httpWebRequest = default(HttpWebRequest);
		try
		{
			do
			{
				_ = _0082_0002._008D_0004;
				httpWebRequest = /*Error near IL_000e: Stack underflow*/((object)/*Error near IL_000e: Stack underflow*/, (Uri)/*Error near IL_000e: Stack underflow*/) as HttpWebRequest;
				if ((int)/*Error near IL_001a: Stack underflow*/ != 0)
				{
					_ = _0084_0002._007E_008F_0004;
					_ = _0083_0002._007E_008E_0004;
					/*Error near IL_0046: Stack underflow*/((object)/*Error near IL_0046: Stack underflow*/);
					/*Error near IL_004d: Stack underflow*/((object)/*Error near IL_004d: Stack underflow*/, false);
				}
				WebRequest webRequest = (WebRequest)/*Error near IL_0050: Stack underflow*/;
			}
			while (5 == 0);
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex, (object)httpWebRequest, (object)this, (object)uri);
			throw;
		}
		return (WebRequest)/*Error near IL_005f: Stack underflow*/;
	}
}
