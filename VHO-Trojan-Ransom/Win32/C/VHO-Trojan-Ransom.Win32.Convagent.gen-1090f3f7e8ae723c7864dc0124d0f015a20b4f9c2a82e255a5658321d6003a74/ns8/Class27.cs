using System;
using System.Threading;
using ns7;
using ns9;

namespace ns8;

internal abstract class Class27
{
	private sealed class Class29
	{
		public Class24 class24_0;

		public Class27 class27_0;

		public void method_0()
		{
			class27_0.method_4(class24_0);
		}
	}

	private static bool bool_0;

	private Delegate0 delegate0_0;

	private static readonly object object_0 = new object();

	protected void method_0(uint uint_0)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				Class25.smethod_4(uint_0);
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
				Class25.smethod_6(string_0);
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
			Class29 @class = new Class29();
			@class.class27_0 = this;
			@class.class24_0 = Class25.smethod_8();
			Thread thread = new Thread(@class.method_0);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += method_3;
			bool_0 = true;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class24 @class = Class25.smethod_9();
		if (!@class.method_2())
		{
			Class17 class2 = new Class17(@class);
			class2.method_1(method_5);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class25.smethod_10();
			}
		}
	}

	protected abstract void vmethod_0(Class17 class17_0);

	protected abstract bool vmethod_1();

	private void method_4(Class24 class24_0)
	{
		Class17 @class = new Class17(class24_0);
		@class.method_1(method_5);
		if (vmethod_1())
		{
			vmethod_0(@class);
		}
		Class23.smethod_0();
	}

	private void method_5(object sender, EventArgs0 e)
	{
		delegate0_0?.Invoke(sender, e);
	}
}
