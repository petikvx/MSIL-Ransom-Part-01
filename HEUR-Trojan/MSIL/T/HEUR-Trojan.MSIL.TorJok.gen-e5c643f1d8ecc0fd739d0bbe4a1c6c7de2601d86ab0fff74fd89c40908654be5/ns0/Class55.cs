using System;
using System.Net;
using System.Net.Sockets;
using ns12;
using ns15;
using ns3;
using ns4;
using ns5;

namespace ns0;

internal sealed class Class55 : Class54
{
	public Class55(Socket socket_1, string string_1)
		: base(socket_1, string_1)
	{
	}

	public override Class52 vmethod_0(string string_1, int int_1, Delegate6 delegate6_1, IPEndPoint ipendPoint_0)
	{
		delegate6_0 = delegate6_1;
		byte_0 = Class6.smethod_377(string_1, int_1, this);
		Class6.smethod_595((Class54)this).BeginConnect(ipendPoint_0, method_0, Class6.smethod_595((Class54)this));
		class52_0 = new Class52();
		return Class6.smethod_134((Class54)this);
	}

	private void method_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			Class6.smethod_595((Class54)this).EndConnect(iasyncResult_0);
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			Class6.smethod_595((Class54)this).BeginSend(Class6.smethod_315((Class54)this), 0, Class6.smethod_315((Class54)this).Length, SocketFlags.None, method_1, Class6.smethod_595((Class54)this));
		}
		catch (Exception exception_2)
		{
			delegate6_0(exception_2);
		}
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			if (Class6.smethod_595((Class54)this).EndSend(iasyncResult_0) < Class6.smethod_315((Class54)this).Length)
			{
				delegate6_0(new SocketException());
				return;
			}
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			byte_0 = new byte[8];
			int_0 = 0;
			Class6.smethod_595((Class54)this).BeginReceive(Class6.smethod_315((Class54)this), 0, Class6.smethod_315((Class54)this).Length, SocketFlags.None, method_2, Class6.smethod_595((Class54)this));
		}
		catch (Exception exception_2)
		{
			delegate6_0(exception_2);
		}
	}

	private void method_2(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = Class6.smethod_595((Class54)this).EndReceive(iasyncResult_0);
			if (num <= 0)
			{
				delegate6_0(new SocketException());
				return;
			}
			int_0 = Class6.smethod_143((Class54)this) + num;
			if (Class6.smethod_143((Class54)this) == 8)
			{
				if (Class6.smethod_315((Class54)this)[1] == 90)
				{
					delegate6_0(null);
					return;
				}
				Class6.smethod_595((Class54)this).Close();
				delegate6_0(new Exception0("Negotiation failed."));
			}
			else
			{
				Class6.smethod_595((Class54)this).BeginReceive(Class6.smethod_315((Class54)this), Class6.smethod_143((Class54)this), Class6.smethod_315((Class54)this).Length - Class6.smethod_143((Class54)this), SocketFlags.None, method_2, Class6.smethod_595((Class54)this));
			}
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
		}
	}
}
