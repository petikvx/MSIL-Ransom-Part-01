using System;
using System.Net;
using System.Security;
using System.Web.Services.Protocols;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class24
{
	internal static readonly string string_0;

	internal string string_1;

	internal string string_2;

	internal IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
	}

	public void method_1(Delegate0 delegate0_0)
	{
		if (string_2 == null)
		{
			try
			{
				Class22 @class = new Class22();
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				string text = (string_2 = @class.method_0(string_1));
				if (Class3.smethod_1(string_2, 272, 376) == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (UsageCounts.smethod_0(string_2, "ditto", 721, 715))
				{
					string text2 = (string_2 = string_0);
				}
			}
			catch (Exception exception_)
			{
				delegate0_0(Class35.smethod_8("ERR 2001: ", Class26.smethod_0(exception_, 753, 703), 943, 961));
				return;
			}
		}
		delegate0_0(string_2.StartsWith("ERR") ? string_2 : "OK");
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate0 delegate0_0)
	{
		try
		{
			Class23 @class = new Class23(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
			}
			delegate0_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception exception_)
		{
			delegate0_0("ERR 2002: " + Class26.smethod_0(exception_, 1020, 946));
		}
	}

	public Class24(string string_3)
	{
		string text = (string_1 = string_3);
	}

	[SecuritySafeCritical]
	static Class24()
	{
		Class32.smethod_1();
		string_0 = "http://sawebservice.red-gate.com/";
	}
}
