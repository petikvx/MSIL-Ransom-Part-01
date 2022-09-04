using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class25
{
	internal static readonly string string_0;

	internal string string_1;

	internal string string_2;

	internal IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		IWebProxy o = default(IWebProxy);
		try
		{
			o = (iwebProxy_0 = iwebProxy_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, this, iwebProxy_1);
			throw;
		}
	}

	public void method_1(Delegate7 delegate7_0)
	{
		int num = default(int);
		Class23 @class = default(Class23);
		string o = default(string);
		string o2 = default(string);
		Exception ex2 = default(Exception);
		int num2 = default(int);
		try
		{
			if (string_2 == null)
			{
				try
				{
					num = 8;
					@class = new Class23();
					if (iwebProxy_0 != null)
					{
						num = 7;
						Class17.smethod_12((HttpWebClientProtocol)(object)@class, iwebProxy_0, 62, 92);
					}
					else
					{
						num = 6;
					}
					o = (string_2 = @class.method_0(string_1));
					num = 9;
					if (AppPathFinder.smethod_1(string_2, 448, 503) == 0)
					{
						num = 5;
						throw new ApplicationException("Cannot connect to webservice");
					}
					num = 10;
					if (Class2.smethod_9(string_2, "ditto", 731, 641))
					{
						num = 11;
						o2 = (string_2 = string_0);
						num = 1;
					}
					else
					{
						num = 1;
					}
				}
				catch (Exception ex)
				{
					ex2 = ex;
					delegate7_0(Form0.smethod_1("ERR 2001: ", UsageReportSender.smethod_12(ex2, 515, 575), 131, 177));
					return;
				}
			}
			num2 = 4;
			delegate7_0(string_2.StartsWith("ERR") ? string_2 : "OK");
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, @class, ex2, o, o2, num, num2, this, delegate7_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate7 delegate7_0)
	{
		int num = default(int);
		Class24 @class = default(Class24);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				num = 4;
				@class = new Class24(string_2);
				if (iwebProxy_0 != null)
				{
					Class17.smethod_12((HttpWebClientProtocol)(object)@class, iwebProxy_0, 32, 66);
				}
				delegate7_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				delegate7_0("ERR 2002: " + UsageReportSender.smethod_12(ex2, 47, 19));
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, @class, ex2, num, this, byte_0, string_3, string_4, string_5, delegate7_0);
			throw;
		}
	}

	public Class25(string string_3)
	{
		string o = default(string);
		try
		{
			o = (string_1 = string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, o, this, string_3);
			throw;
		}
	}

	static Class25()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			string_0 = "http://sawebservice.red-gate.com/";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
