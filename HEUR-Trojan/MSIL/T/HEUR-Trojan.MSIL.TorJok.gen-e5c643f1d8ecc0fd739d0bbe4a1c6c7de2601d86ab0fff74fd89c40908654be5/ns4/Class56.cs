using System;
using System.Net;
using System.Net.Sockets;
using ns10;
using ns12;
using ns14;
using ns15;
using ns3;
using ns5;

namespace ns4;

internal sealed class Class56 : Class54
{
	internal string string_1;

	internal byte[] byte_1;

	public Class56(Socket socket_1, string string_2, string string_3)
		: base(socket_1, string_2)
	{
		Class6.smethod_348(this, string_3);
	}

	public override Class52 vmethod_0(string string_2, int int_1, Delegate6 delegate6_1, IPEndPoint ipendPoint_0)
	{
		delegate6_0 = delegate6_1;
		byte_1 = Class6.smethod_403(string_2, int_1, this);
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
			Class6.smethod_595((Class54)this).BeginSend(new byte[4] { 5, 2, 0, 2 }, 0, 4, SocketFlags.None, method_1, Class6.smethod_595((Class54)this));
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
			Class6.smethod_595((Class54)this).EndSend(iasyncResult_0);
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			byte_0 = new byte[1024];
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
			int_0 = Class6.smethod_143((Class54)this) + Class6.smethod_595((Class54)this).EndReceive(iasyncResult_0);
			if (Class6.smethod_143((Class54)this) <= 0)
			{
				throw new SocketException();
			}
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			if (Class6.smethod_143((Class54)this) < 2)
			{
				Class6.smethod_595((Class54)this).BeginReceive(Class6.smethod_315((Class54)this), Class6.smethod_143((Class54)this), Class6.smethod_315((Class54)this).Length - Class6.smethod_143((Class54)this), SocketFlags.None, method_2, Class6.smethod_595((Class54)this));
				return;
			}
			Class57 @class;
			switch (Class6.smethod_315((Class54)this)[1])
			{
			default:
				delegate6_0(new SocketException());
				return;
			case 2:
				@class = new Class59(Class6.smethod_595((Class54)this), Class6.smethod_136((Class54)this), Class6.smethod_31(this));
				break;
			case 0:
				@class = new Class58(Class6.smethod_595((Class54)this));
				break;
			}
			@class.vmethod_0(method_3);
		}
		catch (Exception exception_2)
		{
			delegate6_0(exception_2);
		}
	}

	private void method_3(Exception exception_0)
	{
		if (exception_0 != null)
		{
			delegate6_0(exception_0);
			return;
		}
		try
		{
			Class6.smethod_595((Class54)this).BeginSend(Class6.smethod_576(this), 0, Class6.smethod_576(this).Length, SocketFlags.None, method_4, Class6.smethod_595((Class54)this));
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
		}
	}

	private void method_4(IAsyncResult iasyncResult_0)
	{
		try
		{
			Class6.smethod_595((Class54)this).EndSend(iasyncResult_0);
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			byte_0 = new byte[5];
			int_0 = 0;
			Class6.smethod_595((Class54)this).BeginReceive(Class6.smethod_315((Class54)this), 0, Class6.smethod_315((Class54)this).Length, SocketFlags.None, method_5, Class6.smethod_595((Class54)this));
		}
		catch (Exception exception_2)
		{
			delegate6_0(exception_2);
		}
	}

	private void method_5(IAsyncResult iasyncResult_0)
	{
		try
		{
			int_0 = Class6.smethod_143((Class54)this) + Class6.smethod_595((Class54)this).EndReceive(iasyncResult_0);
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			if (Class6.smethod_143((Class54)this) == Class6.smethod_315((Class54)this).Length)
			{
				Class6.smethod_558(this, Class6.smethod_315((Class54)this));
			}
			else
			{
				Class6.smethod_595((Class54)this).BeginReceive(Class6.smethod_315((Class54)this), Class6.smethod_143((Class54)this), Class6.smethod_315((Class54)this).Length - Class6.smethod_143((Class54)this), SocketFlags.None, method_5, Class6.smethod_595((Class54)this));
			}
		}
		catch (Exception exception_2)
		{
			delegate6_0(exception_2);
		}
	}

	internal void method_6(IAsyncResult iasyncResult_0)
	{
		try
		{
			int_0 = Class6.smethod_143((Class54)this) + Class6.smethod_595((Class54)this).EndReceive(iasyncResult_0);
		}
		catch (Exception exception_)
		{
			delegate6_0(exception_);
			return;
		}
		try
		{
			if (Class6.smethod_143((Class54)this) == Class6.smethod_315((Class54)this).Length)
			{
				delegate6_0(null);
			}
			else
			{
				Class6.smethod_595((Class54)this).BeginReceive(Class6.smethod_315((Class54)this), Class6.smethod_143((Class54)this), Class6.smethod_315((Class54)this).Length - Class6.smethod_143((Class54)this), SocketFlags.None, method_6, Class6.smethod_595((Class54)this));
			}
		}
		catch (Exception exception_2)
		{
			delegate6_0(exception_2);
		}
	}
}
