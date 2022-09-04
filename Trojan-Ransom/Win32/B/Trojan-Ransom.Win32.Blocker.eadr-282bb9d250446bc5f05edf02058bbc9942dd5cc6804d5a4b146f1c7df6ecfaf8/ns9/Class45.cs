using System;
using System.Threading;
using ns7;

namespace ns9;

internal abstract class Class45
{
	private sealed class Class47
	{
		public Class42 class42_0;

		public Class45 class45_0;

		public void method_0()
		{
			class45_0.method_4(class42_0);
		}
	}

	private static bool bool_0;

	private Delegate3 delegate3_0;

	private static readonly object object_0 = new object();

	protected void method_0(uint uint_0)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				Class43.smethod_4(uint_0);
			}
		}
		catch
		{
		}
	}

	protected void method_1(string string_0)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				Class43.smethod_6(string_0);
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		if (!bool_0)
		{
			Class47 @class = new Class47();
			@class.class45_0 = this;
			@class.class42_0 = Class43.smethod_8();
			Thread thread = new Thread(@class.method_0);
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += method_3;
			bool_0 = true;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class42 @class = Class43.smethod_9();
		if (!@class.method_2())
		{
			Class35 class2 = new Class35(@class);
			class2.method_1(method_5);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class43.smethod_10();
			}
		}
	}

	protected abstract void vmethod_0(Class35 class35_0);

	protected abstract bool vmethod_1();

	private void method_4(Class42 class42_0)
	{
		Class35 @class = new Class35(class42_0);
		@class.method_1(method_5);
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class41.smethod_0();
	}

	private void method_5(object sender, EventArgs4 e)
	{
		delegate3_0?.Invoke(sender, e);
	}
}
