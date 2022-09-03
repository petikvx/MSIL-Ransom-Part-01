using System;
using System.Threading;
using ns4;

namespace ns3;

internal abstract class Class22
{
	private sealed class Class24
	{
		public Class19 class19_0;

		public Class22 class22_0;

		public void method_0()
		{
			class22_0.method_4(class19_0);
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
				Class20.smethod_4(uint_0);
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
				Class20.smethod_6(string_0);
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
			Class24 @class = new Class24();
			@class.class22_0 = this;
			@class.class19_0 = Class20.smethod_8();
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
		Class19 @class = Class20.smethod_9();
		if (!@class.method_2())
		{
			Class12 class2 = new Class12(@class);
			class2.method_1(method_5);
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class20.smethod_10();
			}
		}
	}

	protected abstract void vmethod_0(Class12 class12_0);

	protected abstract bool vmethod_1();

	private void method_4(Class19 class19_0)
	{
		Class12 @class = new Class12(class19_0);
		@class.method_1(method_5);
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class18.smethod_0();
	}

	private void method_5(object sender, EventArgs0 e)
	{
		delegate0_0?.Invoke(sender, e);
	}
}
