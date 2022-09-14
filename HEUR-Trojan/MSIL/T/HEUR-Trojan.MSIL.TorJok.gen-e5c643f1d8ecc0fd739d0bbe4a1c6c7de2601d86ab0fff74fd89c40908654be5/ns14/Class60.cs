using System;
using System.Net;
using System.Net.Sockets;
using ns4;
using ns5;

namespace ns14;

internal abstract class Class60 : IDisposable
{
	private Delegate7 delegate7_0;

	internal Socket socket_0;

	internal Socket socket_1;

	internal byte[] byte_0 = new byte[4096];

	internal byte[] byte_1 = new byte[1024];

	public Class60(Socket socket_2, Delegate7 delegate7_1)
	{
		Class6.smethod_231(this, socket_2);
		delegate7_0 = delegate7_1;
	}

	public Class60()
	{
		Class6.smethod_231(this, (Socket)null);
		delegate7_0 = null;
	}

	void IDisposable.Dispose()
	{
		try
		{
			Class6.smethod_230(this).Shutdown(SocketShutdown.Both);
		}
		catch
		{
		}
		try
		{
			Class6.smethod_357(this).Shutdown(SocketShutdown.Both);
		}
		catch
		{
		}
		if (Class6.smethod_230(this) != null)
		{
			Class6.smethod_230(this).Close();
		}
		if (Class6.smethod_357(this) != null)
		{
			Class6.smethod_357(this).Close();
		}
		Class6.smethod_231(this, (Socket)null);
		Class6.smethod_603(this, (Socket)null);
		if (delegate7_0 != null)
		{
			delegate7_0(this);
		}
	}

	public override string ToString()
	{
		try
		{
			return "Incoming connection from " + ((IPEndPoint)Class6.smethod_357(this).RemoteEndPoint).Address.ToString();
		}
		catch
		{
			return "Client connection";
		}
	}

	public void method_0()
	{
		try
		{
			Class6.smethod_230(this).BeginReceive(Class6.smethod_547(this), 0, Class6.smethod_547(this).Length, SocketFlags.None, method_1, Class6.smethod_230(this));
			Class6.smethod_357(this).BeginReceive(Class6.smethod_285(this), 0, Class6.smethod_285(this).Length, SocketFlags.None, method_3, Class6.smethod_357(this));
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = Class6.smethod_230(this).EndReceive(iasyncResult_0);
			if (num <= 0)
			{
				System_002EIDisposable_002EDispose();
			}
			else
			{
				Class6.smethod_357(this).BeginSend(Class6.smethod_547(this), 0, num, SocketFlags.None, method_2, Class6.smethod_357(this));
			}
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected void method_2(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = Class6.smethod_357(this).EndSend(iasyncResult_0);
			if (num > 0)
			{
				Class6.smethod_230(this).BeginReceive(Class6.smethod_547(this), 0, Class6.smethod_547(this).Length, SocketFlags.None, method_1, Class6.smethod_230(this));
				return;
			}
		}
		catch
		{
		}
		System_002EIDisposable_002EDispose();
	}

	protected void method_3(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = Class6.smethod_357(this).EndReceive(iasyncResult_0);
			if (num <= 0)
			{
				System_002EIDisposable_002EDispose();
			}
			else
			{
				Class6.smethod_230(this).BeginSend(Class6.smethod_285(this), 0, num, SocketFlags.None, method_4, Class6.smethod_230(this));
			}
		}
		catch
		{
			System_002EIDisposable_002EDispose();
		}
	}

	protected void method_4(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = Class6.smethod_230(this).EndSend(iasyncResult_0);
			if (num > 0)
			{
				Class6.smethod_357(this).BeginReceive(Class6.smethod_285(this), 0, Class6.smethod_285(this).Length, SocketFlags.None, method_3, Class6.smethod_357(this));
				return;
			}
		}
		catch
		{
		}
		System_002EIDisposable_002EDispose();
	}

	public abstract void vmethod_0();
}
