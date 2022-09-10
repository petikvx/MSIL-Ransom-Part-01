using System;
using System.Net;
using System.Web.Services.Protocols;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;

namespace ns0;

internal sealed class Class31
{
	internal static readonly string string_0;

	private string string_1;

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
		Class29 @class = default(Class29);
		Exception ex2 = default(Exception);
		try
		{
			if (string_1 == null)
			{
				try
				{
					@class = new Class29();
					if (iwebProxy_0 != null)
					{
						((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
					}
					string_1 = @class.method_0(string_2);
					if (string_1.Length == 0)
					{
						throw new ApplicationException(Strings.Get(3998));
					}
					if (string_1 == Strings.Get(4039))
					{
						string_1 = string_0;
					}
				}
				catch (Exception ex)
				{
					ex2 = ex;
					delegate1_0(Strings.Get(4048) + ex2.Message);
					return;
				}
			}
			delegate1_0(string_1.StartsWith(Strings.Get(1539)) ? string_1 : Strings.Get(1481));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, @class, ex2, this, delegate1_0);
			throw;
		}
	}

	public void method_2(byte[] byte_0, string string_3, string string_4, string string_5, Delegate1 delegate1_0)
	{
		Class30 @class = default(Class30);
		Exception ex2 = default(Exception);
		try
		{
			try
			{
				@class = new Class30(string_1);
				if (iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)@class).set_Proxy(iwebProxy_0);
				}
				delegate1_0(@class.method_0(string_2, byte_0, string_3, string_4, string_5));
			}
			catch (Exception ex)
			{
				ex2 = ex;
				delegate1_0(Strings.Get(4065) + ex2.Message);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, @class, ex2, this, byte_0, string_3, string_4, string_5, delegate1_0);
			throw;
		}
	}

	public Class31(string string_3)
	{
		try
		{
			string text = (string_2 = string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, string_3);
			throw;
		}
	}

	static Class31()
	{
		try
		{
			string_0 = Strings.Get(4082);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
