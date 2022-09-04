using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class24
{
	internal static readonly string string_0;

	private string string_1;

	private string string_2;

	internal IWebProxy iwebProxy_0;

	public void method_0(IWebProxy iwebProxy_1)
	{
		try
		{
			IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, this, iwebProxy_1);
			throw;
		}
	}

	public void method_1(Delegate1 delegate1_0)
	{
		Class22 @class = default(Class22);
		Exception ex2 = default(Exception);
		try
		{
			if (string_2 == null)
			{
				try
				{
					@class = new Class22();
					if (iwebProxy_0 != null)
					{
						((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
					}
					string_2 = @class.method_0(string_1);
					if (string_2.Length == 0)
					{
						throw new ApplicationException("Cannot connect to webservice");
					}
					if (string_2 == "ditto")
					{
						string_2 = string_0;
					}
				}
				catch (Exception ex)
				{
					ex2 = ex;
					delegate1_0("ERR 2001: " + ex2.Message);
					return;
				}
			}
			delegate1_0(string_2.StartsWith("ERR") ? string_2 : "OK");
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException4(exception_, @class, ex2, this, delegate1_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate1 delegate1_0)
	{
		Class23 @class = default(Class23);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				@class = new Class23(string_2);
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				delegate1_0(@class.method_0(string_1, byte_0, string_3, string_4, string_5));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				delegate1_0("ERR 2002: " + ex2.Message);
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException8(exception_, @class, ex2, this, byte_0, string_3, string_4, string_5, delegate1_0);
			throw;
		}
	}

	public Class24(string string_3)
	{
		try
		{
			string_1 = string_3;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, this, string_3);
			throw;
		}
	}

	static Class24()
	{
		try
		{
			string_0 = "http://sawebservice.red-gate.com/";
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}
}
