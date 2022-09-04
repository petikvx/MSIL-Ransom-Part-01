using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass19
{
	private EventHandler<GEventArgs1> eventHandler_0;

	private EventHandler<GEventArgs3> eventHandler_1;

	private EventHandler<GEventArgs3> eventHandler_2;

	private byte[] byte_0;

	private bool bool_0;

	[CompilerGenerated]
	private Socket socket_0;

	[CompilerGenerated]
	private static EventHandler<GEventArgs3> eventHandler_3;

	[CompilerGenerated]
	private static EventHandler<GEventArgs3> eventHandler_4;

	[CompilerGenerated]
	private static EventHandler<GEventArgs1> eventHandler_5;

	public event EventHandler<GEventArgs1> Event_0
	{
		add
		{
			EventHandler<GEventArgs1> eventHandler = eventHandler_0;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs1> eventHandler = eventHandler_0;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs3> Event_1
	{
		add
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_1;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_1;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<GEventArgs3> Event_2
	{
		add
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_2;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_2;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public Socket method_0()
	{
		return socket_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(Socket socket_1)
	{
		socket_0 = socket_1;
	}

	public GClass19(Socket socket_1, int int_0)
	{
		Class51.smethod_0();
		eventHandler_1 = delegate
		{
		};
		eventHandler_2 = delegate
		{
		};
		base._002Ector();
		method_1(socket_1);
		eventHandler_0 = delegate
		{
		};
		byte_0 = new byte[int_0];
	}

	private void method_2(IAsyncResult iasyncResult_0)
	{
		try
		{
			SocketError errorCode = SocketError.Success;
			int num = 0;
			if (((Socket)iasyncResult_0.AsyncState).Connected)
			{
				num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0, out errorCode);
			}
			if (num > 0 && errorCode == SocketError.Success)
			{
				GEventArgs3 e = new GEventArgs3(this, byte_0, num);
				eventHandler_1(this, e);
			}
			else
			{
				method_5();
			}
		}
		catch
		{
			method_5();
		}
	}

	public int method_3(byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			int num = method_0().Receive(byte_1, int_0, int_1, SocketFlags.None);
			if (num <= 0)
			{
				method_5();
				return -1;
			}
			return num;
		}
		catch
		{
			method_5();
			return -1;
		}
	}

	public void method_4()
	{
		method_0().BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_2, method_0());
	}

	public void method_5()
	{
		try
		{
			if (method_0() != null && method_0().Connected)
			{
				eventHandler_0(this, new GEventArgs1(this));
				method_0().Shutdown(SocketShutdown.Both);
				method_0().Close();
				method_1(null);
			}
			else
			{
				eventHandler_0(this, new GEventArgs1(this));
				method_10();
			}
		}
		catch
		{
		}
	}

	private void method_6(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndSend(iasyncResult_0);
			if (num < 0)
			{
				method_0().Shutdown(SocketShutdown.Both);
				method_0().Close();
			}
		}
		catch
		{
			method_5();
		}
	}

	public bool method_7(byte[] byte_1)
	{
		return method_9(byte_1, 0, byte_1.Length);
	}

	public void method_8(byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			if (method_0() != null && method_0().Connected)
			{
				GEventArgs3 gEventArgs = new GEventArgs3(this, byte_1, int_1);
				eventHandler_2(this, gEventArgs);
				method_0().BeginSend(gEventArgs.method_2(), gEventArgs.method_6(), gEventArgs.method_4(), SocketFlags.None, method_6, method_0());
			}
		}
		catch
		{
			method_5();
		}
	}

	public bool method_9(byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			if (method_0() != null)
			{
				if (method_0().Send(byte_1, int_0, int_1, SocketFlags.None) <= 0)
				{
					method_5();
					return false;
				}
				return true;
			}
			return false;
		}
		catch
		{
			method_5();
			return false;
		}
	}

	public void method_10()
	{
		vmethod_0(bool_1: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_0(bool bool_1)
	{
		if (!bool_0)
		{
			if (bool_1)
			{
				method_1(null);
				byte_0 = null;
				eventHandler_0 = null;
				eventHandler_1 = null;
				eventHandler_2 = null;
			}
			bool_0 = true;
		}
	}

	[CompilerGenerated]
	private static void smethod_0(object sender, GEventArgs3 e)
	{
	}

	[CompilerGenerated]
	private static void smethod_1(object sender, GEventArgs3 e)
	{
	}

	[CompilerGenerated]
	private static void smethod_2(object sender, GEventArgs1 e)
	{
	}
}
