using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass16
{
	private EventHandler<GEventArgs2> eventHandler_0;

	public GClass19 gclass19_0;

	private GClass15 gclass15_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private static EventHandler<GEventArgs2> eventHandler_1;

	public event EventHandler<GEventArgs2> Event_0
	{
		add
		{
			EventHandler<GEventArgs2> eventHandler = eventHandler_0;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler<GEventArgs2> eventHandler = eventHandler_0;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public GClass16(GClass19 gclass19_1)
	{
		Class51.smethod_0();
		eventHandler_0 = delegate
		{
		};
		base._002Ector();
		gclass19_0 = gclass19_1;
	}

	[SpecialName]
	public GClass15 method_2()
	{
		return gclass15_0;
	}

	public void method_3(int int_0, int int_1)
	{
		gclass19_0.Event_0 += method_4;
		List<GEnum3> list = Class47.smethod_0(this);
		if (list.Count <= 0)
		{
			gclass19_0.method_7(new byte[2] { 0, 255 });
			gclass19_0.method_5();
			return;
		}
		foreach (GClass9 item in GClass13.smethod_5(typeof(GClass9)))
		{
			if (item.imethod_0())
			{
				if (!list.Contains((GEnum3)2))
				{
					gclass19_0.method_7(new byte[2] { 5, 255 });
					gclass19_0.method_5();
					return;
				}
				GClass17 gClass2 = Class47.smethod_1(this);
				if (gClass2 == null)
				{
					gclass19_0.method_5();
					return;
				}
				GEnum2 gEnum = item.vmethod_0(gClass2);
				gclass19_0.method_7(new byte[2]
				{
					5,
					(byte)gEnum
				});
				switch (gEnum)
				{
				case (GEnum2)255:
					gclass19_0.method_5();
					return;
				case (GEnum2)0:
					method_1(bool_1: true);
					goto end_IL_00d3;
				}
			}
			continue;
			end_IL_00d3:
			break;
		}
		if (!method_0())
		{
			method_1(bool_1: true);
			gclass19_0.method_7(new byte[2] { 5, 0 });
		}
		GClass15 gClass3 = Class47.smethod_2(this);
		if (gClass3 == null)
		{
			gclass19_0.method_5();
			return;
		}
		gclass15_0 = new GClass15(gClass3.method_2(), gClass3.method_0(), gClass3.method_4(), gClass3.method_6());
		foreach (GClass5 item2 in GClass13.smethod_5(typeof(GClass5)))
		{
			if (item2.imethod_0() && !item2.vmethod_0(gclass15_0))
			{
				gClass3.method_9((GEnum7)1);
				gclass19_0.method_7(gClass3.method_11());
				gclass19_0.method_5();
				return;
			}
		}
		Class48 @class = new Class48(this, gClass3, gclass15_0, int_0, int_1);
		@class.method_0();
	}

	private void method_4(object sender, GEventArgs1 e)
	{
		eventHandler_0(this, new GEventArgs2(this));
	}

	[CompilerGenerated]
	private static void smethod_0(object sender, GEventArgs2 e)
	{
	}
}
