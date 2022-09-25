using System;
using System.Threading;
using ns2;
using ns4;

namespace ns3;

internal abstract class Class21
{
	private sealed class Class23
	{
		public Class18 class18_0;

		public Class21 class21_0;

		public void method_0()
		{
			class21_0.method_4(class18_0);
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
				Class19.smethod_4(uint_0);
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
				Class19.smethod_6(string_0);
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
			Class23 @class = new Class23();
			@class.class21_0 = this;
			@class.class18_0 = Class19.smethod_8();
			Thread thread = new Thread(@class.method_0);
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += method_3;
			bool_0 = true;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class18 @class = Class19.smethod_9();
		if (!@class.method_2())
		{
			Class11 class2 = new Class11(@class);
			class2.method_1(method_5);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class19.smethod_10();
			}
		}
	}

	protected abstract void vmethod_0(Class11 class11_0);

	protected abstract bool vmethod_1();

	private void method_4(Class18 class18_0)
	{
		Class11 @class = new Class11(class18_0);
		@class.method_1(method_5);
		if (vmethod_1())
		{
			vmethod_0(@class);
		}
		Class17.smethod_0();
	}

	private void method_5(object sender, EventArgs0 e)
	{
		delegate0_0?.Invoke(sender, e);
	}
}
