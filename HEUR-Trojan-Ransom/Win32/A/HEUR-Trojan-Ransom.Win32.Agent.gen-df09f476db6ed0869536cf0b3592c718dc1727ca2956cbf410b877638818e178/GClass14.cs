using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass14
{
	public GClass21 gclass21_0;

	private Thread thread_0;

	public List<GClass16> list_0;

	public GClass20 gclass20_0;

	private EventHandler<GEventArgs3> eventHandler_0;

	private EventHandler<GEventArgs3> eventHandler_1;

	private bool bool_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private static EventHandler<GEventArgs3> eventHandler_2;

	[CompilerGenerated]
	private static EventHandler<GEventArgs3> eventHandler_3;

	public event EventHandler<GEventArgs3> Event_0
	{
		add
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_0;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs3> eventHandler = eventHandler_0;
			EventHandler<GEventArgs3> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs3> value2 = (EventHandler<GEventArgs3>)Delegate.Remove(eventHandler2, value);
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

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_1(int int_2)
	{
		int_0 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_2()
	{
		return int_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_3(int int_2)
	{
		int_1 = int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_4()
	{
		return bool_1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void method_5(bool bool_2)
	{
		bool_1 = bool_2;
	}

	public GClass14(IPAddress ipaddress_0, int int_2)
	{
		Class51.smethod_0();
		list_0 = new List<GClass16>();
		eventHandler_0 = delegate
		{
		};
		eventHandler_1 = delegate
		{
		};
		base._002Ector();
		method_1(1000);
		method_3(128);
		method_5(bool_2: false);
		gclass20_0 = new GClass20();
		gclass21_0 = new GClass21(ipaddress_0, int_2);
		gclass21_0.Event_0 += method_8;
	}

	public void method_6()
	{
		if (bool_0)
		{
			return;
		}
		GClass13.smethod_1(method_4());
		GClass13.smethod_2();
		gclass21_0.method_1(method_2());
		gclass21_0.method_4();
		bool_0 = true;
		thread_0 = new Thread((ThreadStart)delegate
		{
			while (bool_0)
			{
				if (list_0.Contains(null))
				{
					list_0.Remove(null);
				}
				gclass20_0.method_1(list_0.Count);
				Thread.Sleep(1000);
			}
		});
		thread_0.Start();
	}

	public void method_7()
	{
		if (bool_0)
		{
			gclass21_0.method_5();
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].gclass19_0.method_5();
			}
			list_0.Clear();
			bool_0 = false;
		}
	}

	private void method_8(object sender, GEventArgs1 e)
	{
		foreach (GClass4 item in GClass13.smethod_5(typeof(GClass4)))
		{
			if (!item.imethod_0())
			{
				continue;
			}
			try
			{
				if (!item.vmethod_0(e.method_0(), (IPEndPoint)e.method_0().method_0().RemoteEndPoint))
				{
					e.method_0().method_5();
					return;
				}
			}
			catch
			{
			}
		}
		GClass16 gClass2 = new GClass16(e.method_0());
		gClass2.gclass19_0.Event_1 += method_10;
		gClass2.gclass19_0.Event_2 += method_11;
		gClass2.Event_0 += method_9;
		list_0.Add(gClass2);
		gClass2.method_3(method_2(), method_0());
	}

	private void method_9(object sender, GEventArgs2 e)
	{
		e.method_0().Event_0 -= method_9;
		e.method_0().gclass19_0.Event_1 -= eventHandler_0;
		e.method_0().gclass19_0.Event_2 -= eventHandler_1;
		list_0.Remove(e.method_0());
	}

	private void method_10(object sender, GEventArgs3 e)
	{
		gclass20_0.method_2(e.method_4(), (GEnum9)0);
		gclass20_0.method_3((GEnum8)0);
		eventHandler_1(this, e);
	}

	private void method_11(object sender, GEventArgs3 e)
	{
		gclass20_0.method_2(e.method_4(), (GEnum9)1);
		gclass20_0.method_3((GEnum8)1);
		eventHandler_0(this, e);
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
	private void method_12()
	{
		while (bool_0)
		{
			if (list_0.Contains(null))
			{
				list_0.Remove(null);
			}
			gclass20_0.method_1(list_0.Count);
			Thread.Sleep(1000);
		}
	}
}
