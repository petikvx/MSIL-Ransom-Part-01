using System;
using System.Net;
using System.Security;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class33
{
	internal static readonly string string_0;

	internal string string_1;

	internal string string_2;

	internal IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		try
		{
			IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, iwebProxy_1);
			throw;
		}
	}

	public void method_1(Delegate1 delegate1_0)
	{
		Class31 @class = default(Class31);
		Exception ex2 = default(Exception);
		try
		{
			if (string_2 == null)
			{
				try
				{
					@class = new Class31();
					if (iwebProxy_0 != null)
					{
						((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
					}
					string text = (string_2 = @class.method_0(string_1));
					if (Class3.smethod_1(string_2, 708, 684) == 0)
					{
						throw new ApplicationException("Cannot connect to webservice");
					}
					if (UsageCounts.smethod_0(string_2, "ditto", 486, 508))
					{
						string text2 = (string_2 = string_0);
					}
				}
				catch (Exception ex)
				{
					ex2 = ex;
					delegate1_0(Class35.smethod_8("ERR 2001: ", Class26.smethod_0(ex2, 876, 802), 586, 548));
					return;
				}
			}
			delegate1_0(UsageCounts.smethod_0(string_2, "ERR", 460, 471) ? string_2 : "OK");
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, @class, ex2, this, delegate1_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate1 delegate1_0)
	{
		Class32 @class = default(Class32);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				@class = new Class32(string_2);
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				delegate1_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				delegate1_0(Class35.smethod_8("ERR 2002: ", Class26.smethod_0(ex2, 469, 411), 746, 644));
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, @class, ex2, this, byte_0, string_3, string_4, string_5, delegate1_0);
			throw;
		}
	}

	public Class33(string string_3)
	{
		try
		{
			string text = (string_1 = string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, string_3);
			throw;
		}
	}

	[SecuritySafeCritical]
	static Class33()
	{
		Class32.smethod_1();
		try
		{
			string_0 = "http://sawebservice.red-gate.com/";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
