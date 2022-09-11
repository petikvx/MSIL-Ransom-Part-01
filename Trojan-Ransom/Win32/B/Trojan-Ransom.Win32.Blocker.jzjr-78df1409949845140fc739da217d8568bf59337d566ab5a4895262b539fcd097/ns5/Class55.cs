using System;
using System.Runtime.CompilerServices;
using System.Threading;
using ns2;
using ns7;
using ns8;
using ns9;

namespace ns5;

internal abstract class Class55
{
	[CompilerGenerated]
	private sealed class Class57
	{
		public Class52 class52_0;

		public Class55 class55_0;

		public void method_0()
		{
			class55_0.method_4(class52_0);
		}
	}

	private static bool bool_0;

	private Delegate4 delegate4_0;

	private static readonly object object_0 = new object();

	public event Delegate4 SendingReportFeedback
	{
		add
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate4 @delegate = delegate4_0;
			Delegate4 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate4 value2 = (Delegate4)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate4_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	protected void method_0(uint uint_0)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				Class53.smethod_5(uint_0);
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
				Class53.smethod_7(string_0);
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
			Class52 class52_0 = Class53.smethod_9();
			Thread thread = new Thread((ThreadStart)delegate
			{
				method_4(class52_0);
			});
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += method_3;
			bool_0 = true;
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class52 @class = Class53.smethod_10();
		if (!@class.IsEmpty)
		{
			Class44 class2 = new Class44(@class);
			class2.SendingReportFeedback += method_5;
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class53.smethod_11();
			}
		}
	}

	protected abstract void vmethod_0(Class44 class44_0);

	protected abstract bool vmethod_1();

	private void method_4(Class52 class52_0)
	{
		Class44 @class = new Class44(class52_0);
		@class.SendingReportFeedback += method_5;
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class51.smethod_0();
	}

	private void method_5(object sender, EventArgs4 e)
	{
		delegate4_0?.Invoke(sender, e);
	}
}
