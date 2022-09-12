using System;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using _0005;
using _0006;
using _000E;

namespace SmartAssembly.SmartExceptionsCore;

[WebServiceBinding(Name = "LoginServiceSoap", Namespace = "http://www.smartassembly.com/webservices/UploadReportLogin/")]
internal sealed class UploadReportLoginService1 : SoapHttpClientProtocol
{
	public UploadReportLoginService1()
	{
		try
		{
			_ = _0006._0008._0001;
			((WebClientProtocol)this).set_Url(_0006._0008._0001 + _000E._0003._0001(107394419));
			((WebClientProtocol)this).set_Timeout(30000);
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex, (object)this);
			throw;
		}
	}

	[SoapDocumentMethod("http://www.smartassembly.com/webservices/UploadReportLogin/GetServerURL")]
	public string GetServerURL(string licenseID)
	{
		//IL_0027: Incompatible stack heights: 0 vs 2
		//IL_002e: Incompatible stack heights: 0 vs 1
		//IL_0031: Incompatible stack heights: 0 vs 4
		//IL_0038: Incompatible stack heights: 0 vs 1
		//IL_004a: Incompatible stack heights: 0 vs 1
		try
		{
			_ = _0081_0002._008C_0004;
			_000E._0003._0001(107394386);
			_ = new object[1];
			_ = 0;
			((object[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = (object)/*Error near IL_0019: Stack underflow*/;
			/*Error near IL_0038: Stack underflow*/((object)/*Error near IL_0038: Stack underflow*/, (string)/*Error near IL_0038: Stack underflow*/, (object[])/*Error near IL_0038: Stack underflow*/);
			string text = (string)((object[])/*Error near IL_001d: Stack underflow*/)[0];
		}
		catch (Exception ex)
		{
			_0005._0011._0001(ex, (object)this, (object)licenseID);
			throw;
		}
		return (string)/*Error near IL_0049: Stack underflow*/;
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
