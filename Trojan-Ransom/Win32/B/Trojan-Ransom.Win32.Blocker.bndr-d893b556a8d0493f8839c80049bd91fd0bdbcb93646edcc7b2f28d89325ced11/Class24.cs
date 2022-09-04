using System;
using System.Net;
using System.Web.Services.Protocols;

internal class Class24
{
	internal static readonly string string_0 = GClass4.smethod_0(1199);

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
				Class22 @class = new Class22();
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				string_2 = @class.method_0(string_1);
				if (string_2.Length == 0)
				{
					throw new ApplicationException(GClass4.smethod_0(1115));
				}
				if (string_2 == GClass4.smethod_0(1156))
				{
					string_2 = string_0;
				}
			}
			catch (Exception ex)
			{
				delegate0_0(GClass4.smethod_0(1165) + ex.Message);
				return;
			}
		}
		delegate0_0(string_2.StartsWith(GClass4.smethod_0(1018)) ? string_2 : GClass4.smethod_0(960));
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
		catch (Exception ex)
		{
			delegate0_0(GClass4.smethod_0(1182) + ex.Message);
		}
	}

	public Class24(string string_3)
	{
		string_1 = string_3;
	}
}
