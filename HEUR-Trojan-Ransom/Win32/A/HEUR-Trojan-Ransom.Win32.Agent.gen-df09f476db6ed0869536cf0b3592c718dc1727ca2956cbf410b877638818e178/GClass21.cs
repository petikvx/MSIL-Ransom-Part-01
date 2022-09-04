using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass21
{
	private TcpListener tcpListener_0;

	private bool bool_0;

	private EventHandler<GEventArgs1> eventHandler_0;

	private EventHandler<GEventArgs1> eventHandler_1;

	private EventHandler<GEventArgs3> eventHandler_2;

	private EventHandler<GEventArgs3> eventHandler_3;

	private ManualResetEvent manualResetEvent_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private static EventHandler<GEventArgs1> eventHandler_4;

	[CompilerGenerated]
	private static EventHandler<GEventArgs1> eventHandler_5;

	[CompilerGenerated]
	private static EventHandler<GEventArgs3> eventHandler_6;

	[CompilerGenerated]
	private static EventHandler<GEventArgs3> eventHandler_7;

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

	public event EventHandler<GEventArgs1> Event_1
	{
		add
		{
			EventHandler<GEventArgs1> eventHandler = eventHandler_1;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs1> eventHandler = eventHandler_1;
			EventHandler<GEventArgs1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs1> value2 = (EventHandler<GEventArgs1>)Delegate.Remove(eventHandler2, value);
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

	public event EventHandler<GEventArgs3> Event_3
	{
		add
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_3;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_3;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(int int_1)
	{
		int_0 = int_1;
	}

	public GClass21(IPAddress ipaddress_0, int int_1)
	{
		Class51.smethod_0();
		eventHandler_0 = delegate
		{
		};
		eventHandler_1 = delegate
		{
		};
		eventHandler_2 = delegate
		{
		};
		eventHandler_3 = delegate
		{
		};
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		base._002Ector();
		tcpListener_0 = new TcpListener(ipaddress_0, int_1);
	}

	private void method_2()
	{
		while (bool_0)
		{
			try
			{
				manualResetEvent_0.Reset();
				tcpListener_0.BeginAcceptSocket(method_3, tcpListener_0);
				manualResetEvent_0.WaitOne();
			}
			catch
			{
			}
		}
	}

	private void method_3(IAsyncResult iasyncResult_0)
	{
		try
		{
			TcpListener tcpListener = (TcpListener)iasyncResult_0.AsyncState;
			Socket socket_ = tcpListener.EndAcceptSocket(iasyncResult_0);
			manualResetEvent_0.Set();
			GClass19 gClass = new GClass19(socket_, method_0());
			gClass.Event_0 += eventHandler_1;
			gClass.Event_1 += eventHandler_2;
			gClass.Event_2 += eventHandler_3;
			eventHandler_0(this, new GEventArgs1(gClass));
		}
		catch
		{
		}
	}

	public void method_4()
	{
		if (!bool_0)
		{
			bool_0 = true;
			tcpListener_0.Start(10000);
			new Thread(method_2).Start();
		}
	}

	public void method_5()
	{
		if (bool_0)
		{
			bool_0 = false;
			tcpListener_0.Stop();
		}
	}

	[CompilerGenerated]
	private static void smethod_0(object sender, GEventArgs1 e)
	{
	}

	[CompilerGenerated]
	private static void smethod_1(object sender, GEventArgs1 e)
	{
	}

	[CompilerGenerated]
	private static void smethod_2(object sender, GEventArgs3 e)
	{
	}

	[CompilerGenerated]
	private static void smethod_3(object sender, GEventArgs3 e)
	{
	}
}
