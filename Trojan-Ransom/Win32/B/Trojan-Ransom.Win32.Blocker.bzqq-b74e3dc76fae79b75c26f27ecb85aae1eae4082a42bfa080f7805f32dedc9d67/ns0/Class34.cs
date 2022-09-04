using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class34
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
			try
			{
				o = (iwebProxy_0 = iwebProxy_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, iwebProxy_1);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, this, iwebProxy_1);
			throw;
		}
	}

	public void method_1(Delegate8 delegate8_0)
	{
		int num = default(int);
		int num2 = default(int);
		Class32 @class = default(Class32);
		string o = default(string);
		string o2 = default(string);
		Exception ex2 = default(Exception);
		int num3 = default(int);
		int num4 = default(int);
		try
		{
			try
			{
				num = 0;
				if (string_2 == null)
				{
					try
					{
						num2 = 10;
						@class = new Class32();
						if (iwebProxy_0 != null)
						{
							num2 = 6;
							Class17.smethod_12((HttpWebClientProtocol)(object)@class, iwebProxy_0, 228, 134);
						}
						else
						{
							num2 = 11;
						}
						o = (string_2 = @class.method_0(string_1));
						num2 = 3;
						if (AppPathFinder.smethod_1(string_2, 621, 602) == 0)
						{
							num2 = 7;
							throw new ApplicationException("Cannot connect to webservice");
						}
						num2 = 8;
						if (Class2.smethod_9(string_2, "ditto", 218, 128))
						{
							num2 = 2;
							o2 = (string_2 = string_0);
							num2 = 1;
						}
						else
						{
							num2 = 1;
						}
					}
					catch (Exception ex)
					{
						ex2 = ex;
						delegate8_0(Form0.smethod_1("ERR 2001: ", UsageReportSender.smethod_12(ex2, 977, 1005), 252, 206));
						goto end_IL_0000;
					}
				}
				num3 = 1;
				delegate8_0(AppNameFinder.smethod_2(string_2, "ERR", 512, 583) ? string_2 : "OK");
				end_IL_0000:;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, @class, ex2, this, delegate8_0);
				throw;
			}
			num4 = 2;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException10(exception2, @class, ex2, o, o2, num, num2, num3, num4, this, delegate8_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate8 delegate8_0)
	{
		int num = default(int);
		Class33 @class = default(Class33);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				try
				{
					num = 3;
					@class = new Class33(string_2);
					if (iwebProxy_0 != null)
					{
						Class17.smethod_12((HttpWebClientProtocol)(object)@class, iwebProxy_0, 388, 486);
					}
					delegate8_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
				}
				catch (Exception ex)
				{
					ex2 = ex;
					delegate8_0(Form0.smethod_1("ERR 2002: ", UsageReportSender.smethod_12(ex2, 418, 414), 939, 921));
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, @class, ex2, this, byte_0, string_3, string_4, string_5, delegate8_0);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException9(exception2, @class, ex2, num, this, byte_0, string_3, string_4, string_5, delegate8_0);
			throw;
		}
	}

	public Class34(string string_3)
	{
		string o = default(string);
		try
		{
			try
			{
				o = (string_1 = string_3);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, string_3);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, this, string_3);
			throw;
		}
	}

	static Class34()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}
}
