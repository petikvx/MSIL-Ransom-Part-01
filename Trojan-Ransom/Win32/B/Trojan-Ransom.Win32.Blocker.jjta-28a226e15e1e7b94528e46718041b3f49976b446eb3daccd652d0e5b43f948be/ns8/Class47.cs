using System;
using System.Threading;
using ns0;
using ns3;
using ns4;
using ns7;

namespace ns8;

internal abstract class Class47
{
	private sealed class Class49
	{
		public Class44 class44_0;

		public Class47 class47_0;

		public void method_0()
		{
			class47_0.method_4(class44_0);
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
				Class45.smethod_4(uint_0);
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
				Class45.smethod_6(string_0);
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
			Class49 @class = new Class49();
			@class.class47_0 = this;
			@class.class44_0 = Class45.smethod_8();
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
		Class44 @class = Class45.smethod_9();
		if (!@class.method_2())
		{
			Class37 class2 = new Class37(@class);
			class2.method_1(method_5);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class45.smethod_10();
			}
		}
	}

	protected abstract void vmethod_0(Class37 class37_0);

	protected abstract bool vmethod_1();

	private void method_4(Class44 class44_0)
	{
		Class37 @class = new Class37(class44_0);
		@class.method_1(method_5);
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class43.smethod_0();
	}

	private void method_5(object sender, EventArgs4 e)
	{
		delegate3_0?.Invoke(sender, e);
	}
}
