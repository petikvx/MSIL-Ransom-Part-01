using System;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns3;
using ns4;
using ns9;

namespace ns1;

internal abstract class Class51
{
	[CompilerGenerated]
	private sealed class Class53
	{
		public Class48 class48_0;

		public Class51 class51_0;

		public void method_0()
		{
			class51_0.method_4(class48_0);
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

	protected void method_0(uint featureId)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				Class49.smethod_5(featureId);
			}
		}
		catch
		{
		}
	}

	protected void method_1(string featureName)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				Class49.smethod_7(featureName);
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
			Class48 class48_0 = Class49.smethod_9();
			Thread thread = new Thread((ThreadStart)delegate
			{
				method_4(class48_0);
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
		Class48 @class = Class49.smethod_10();
		if (!@class.IsEmpty)
		{
			Class40 class2 = new Class40(@class);
			class2.SendingReportFeedback += method_5;
			if (vmethod_1())
			{
				vmethod_0(class2);
				Class49.smethod_11();
			}
		}
	}

	protected abstract void vmethod_0(Class40 sender);

	protected abstract bool vmethod_1();

	private void method_4(Class48 usageCounts)
	{
		Class40 @class = new Class40(usageCounts);
		@class.SendingReportFeedback += method_5;
		if (vmethod_1())
		{
			Thread.CurrentThread.IsBackground = false;
			vmethod_0(@class);
		}
		Class47.smethod_0();
	}

	private void method_5(object sender, EventArgs4 e)
	{
		delegate4_0?.Invoke(sender, e);
	}
}
