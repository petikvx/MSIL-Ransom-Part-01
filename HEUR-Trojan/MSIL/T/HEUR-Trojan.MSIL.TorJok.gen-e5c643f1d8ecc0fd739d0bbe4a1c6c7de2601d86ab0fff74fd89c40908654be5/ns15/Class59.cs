using System;
using System.Net.Sockets;
using ns10;
using ns12;
using ns5;

namespace ns15;

internal sealed class Class59 : Class57
{
	internal string string_0;

	internal string string_1;

	public Class59(Socket socket_1, string string_2, string string_3)
		: base(socket_1)
	{
		Class6.smethod_279(this, string_2);
		Class6.smethod_104(string_3, this);
	}

	public override void vmethod_0(Delegate6 delegate6_1)
	{
		delegate6_0 = delegate6_1;
		Class6.smethod_100((Class57)this).BeginSend(Class6.smethod_557(this), 0, 3 + Class6.smethod_156(this).Length + Class6.smethod_87(this).Length, SocketFlags.None, method_0, Class6.smethod_100((Class57)this));
	}

	private void method_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			Class6.smethod_100((Class57)this).EndSend(iasyncResult_0);
			byte_0 = new byte[2];
			Class6.smethod_100((Class57)this).BeginReceive(Class6.smethod_249((Class57)this), 0, 2, SocketFlags.None, method_1, Class6.smethod_100((Class57)this));
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
		}
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			int_0 = Class6.smethod_0((Class57)this) + Class6.smethod_100((Class57)this).EndReceive(iasyncResult_0);
			if (Class6.smethod_0((Class57)this) == Class6.smethod_249((Class57)this).Length)
			{
				if (Class6.smethod_249((Class57)this)[1] != 0)
				{
					throw new Exception0("Username/password combination not accepted.");
				}
				delegate6_0(null);
			}
			else
			{
				Class6.smethod_100((Class57)this).BeginReceive(Class6.smethod_249((Class57)this), Class6.smethod_0((Class57)this), Class6.smethod_249((Class57)this).Length - Class6.smethod_0((Class57)this), SocketFlags.None, method_1, Class6.smethod_100((Class57)this));
			}
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
		}
	}
}
