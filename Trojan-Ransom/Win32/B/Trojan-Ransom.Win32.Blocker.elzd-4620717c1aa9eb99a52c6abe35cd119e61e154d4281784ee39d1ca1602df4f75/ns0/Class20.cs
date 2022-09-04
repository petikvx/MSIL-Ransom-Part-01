using System;
using System.Net;
using System.Web.Services.Protocols;

namespace ns0;

internal sealed class Class20
{
	internal static readonly string string_0 = "http://sawebservice.red-gate.com/";

	private string string_1;

	internal string string_2;

	internal IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
	}

	public void method_1(Delegate0 delegate0_0)
	{
		if (string_1 == null)
		{
			try
			{
				Class18 @class = new Class18();
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				string_1 = @class.method_0(string_2);
				if (string_1.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (string_1 == "ditto")
				{
					string_1 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate0_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate0_0(string_1.StartsWith("ERR") ? string_1 : "OK");
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate0 delegate0_0)
	{
		try
		{
			Class19 @class = new Class19(string_1);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
			}
			delegate0_0(@class.method_0(string_2, byte_0, string_3, string_4, string_5));
		}
		catch (Exception ex)
		{
			delegate0_0("ERR 2002: " + ex.Message);
		}
	}

	public Class20(string string_3)
	{
		string text = (string_2 = string_3);
	}
}
