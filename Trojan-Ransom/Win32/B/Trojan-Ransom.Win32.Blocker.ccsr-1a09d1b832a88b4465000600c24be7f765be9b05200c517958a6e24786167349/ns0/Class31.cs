using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class31
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

	public void method_1(Delegate8 delegate8_0)
	{
		Class29 @class = default(Class29);
		Exception ex2 = default(Exception);
		try
		{
			if (string_2 == null)
			{
				try
				{
					@class = new Class29();
					if (iwebProxy_0 != null)
					{
						((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
					}
					string text = (string_2 = @class.method_0(string_1));
					if (PoweredBy.smethod_0(string_2, 207, 159) == 0)
					{
						throw new ApplicationException("Cannot connect to webservice");
					}
					if (string_2 == "ditto")
					{
						string text2 = (string_2 = string_0);
					}
				}
				catch (Exception ex)
				{
					ex2 = ex;
					delegate8_0(ReportSender.smethod_0("ERR 2001: ", AutoHeightLabel.smethod_1(ex2, 71, 62), 362, 265));
					return;
				}
			}
			delegate8_0(Win32.smethod_9(string_2, "ERR", 484, 508) ? string_2 : "OK");
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, @class, ex2, this, delegate8_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate8 delegate8_0)
	{
		Class30 @class = default(Class30);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				@class = new Class30(string_2);
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				delegate8_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				delegate8_0(ReportSender.smethod_0("ERR 2002: ", AutoHeightLabel.smethod_1(ex2, 501, 396), 610, 513));
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, @class, ex2, this, byte_0, string_3, string_4, string_5, delegate8_0);
			throw;
		}
	}

	public Class31(string string_3)
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

	static Class31()
	{
		DESCryptoIndirector.smethod_0();
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
