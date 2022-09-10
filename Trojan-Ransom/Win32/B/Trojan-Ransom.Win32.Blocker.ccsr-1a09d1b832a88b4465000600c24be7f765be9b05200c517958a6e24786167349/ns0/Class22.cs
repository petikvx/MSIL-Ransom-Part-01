using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class22
{
	internal static readonly string string_0;

	internal string string_1;

	internal string string_2;

	internal IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
	}

	public void method_1(Delegate7 delegate7_0)
	{
		if (string_2 == null)
		{
			try
			{
				Class20 @class = new Class20();
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				string text = (string_2 = @class.method_0(string_1));
				if (PoweredBy.smethod_0(string_2, 507, 427) == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (string_2 == "ditto")
				{
					string text2 = (string_2 = string_0);
				}
			}
			catch (Exception exception_)
			{
				delegate7_0(ReportSender.smethod_0("ERR 2001: ", AutoHeightLabel.smethod_1(exception_, 896, 1017), 112, 19));
				return;
			}
		}
		delegate7_0(string_2.StartsWith("ERR") ? string_2 : "OK");
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate7 delegate7_0)
	{
		try
		{
			Class21 @class = new Class21(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
			}
			delegate7_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception exception_)
		{
			delegate7_0("ERR 2002: " + AutoHeightLabel.smethod_1(exception_, 403, 490));
		}
	}

	public Class22(string string_3)
	{
		string text = (string_1 = string_3);
	}

	static Class22()
	{
		DESCryptoIndirector.smethod_0();
		string_0 = "http://sawebservice.red-gate.com/";
	}
}
