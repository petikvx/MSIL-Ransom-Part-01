using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.StringsEncoding;

namespace ns0;

internal sealed class Class22
{
	internal static readonly string string_0 = Strings.Get(4082);

	private string string_1;

	private string string_2;

	private IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	public void method_1(Delegate0 delegate0_0)
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
				string_2 = @class.method_0(string_1);
				if (string_2.Length == 0)
				{
					throw new ApplicationException(Strings.Get(3998));
				}
				if (string_2 == Strings.Get(4039))
				{
					string_2 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate0_0(Strings.Get(4048) + ex.Message);
				return;
			}
		}
		delegate0_0(string_2.StartsWith(Strings.Get(1539)) ? string_2 : Strings.Get(1481));
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate0 delegate0_0)
	{
		try
		{
			Class21 @class = new Class21(string_2);
			if (iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
			}
			delegate0_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
		}
		catch (Exception ex)
		{
			delegate0_0(Strings.Get(4065) + ex.Message);
		}
	}

	public Class22(string string_3)
	{
		string_1 = string_3;
	}
}
