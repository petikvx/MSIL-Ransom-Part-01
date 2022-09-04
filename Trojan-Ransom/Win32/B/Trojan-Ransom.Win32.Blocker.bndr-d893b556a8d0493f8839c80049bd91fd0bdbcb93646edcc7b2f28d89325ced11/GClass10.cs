using System;
using System.Threading;

public abstract class GClass10
{
	private sealed class Class29
	{
		public GClass8 gclass8_0;

		public GClass10 gclass10_0;

		public void method_0()
		{
			gclass10_0.method_4(gclass8_0);
		}
	}

	private static bool bool_0;

	private GDelegate0 gdelegate0_0;

	private static readonly object object_0 = new object();

	public event GDelegate0 SendingReportFeedback
	{
		add
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate0 value2 = (GDelegate0)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		remove
		{
			GDelegate0 gDelegate = gdelegate0_0;
			GDelegate0 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate0 value2 = (GDelegate0)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate0_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	protected void method_0(uint uint_0)
	{
		try
		{
			lock (object_0)
			{
				method_2();
				GClass9.smethod_4(uint_0);
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
				GClass9.smethod_6(string_0);
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
			@class.gclass10_0 = this;
			@class.gclass8_0 = GClass9.smethod_8();
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
		GClass8 gClass = GClass9.smethod_9();
		if (!gClass.IsEmpty)
		{
			GClass7 gClass2 = new GClass7(gClass);
			gClass2.SendingReportFeedback += method_5;
			if (CanReportUsage())
			{
				ReportUsage(gClass2);
				GClass9.smethod_10();
			}
		}
	}

	protected abstract void ReportUsage(GClass7 gclass7_0);

	protected abstract bool CanReportUsage();

	private void method_4(GClass8 gclass8_0)
	{
		GClass7 gClass = new GClass7(gclass8_0);
		gClass.SendingReportFeedback += method_5;
		if (CanReportUsage())
		{
			Thread.CurrentThread.IsBackground = false;
			ReportUsage(gClass);
		}
		Class26.smethod_0();
	}

	private void method_5(object sender, GEventArgs0 e)
	{
		gdelegate0_0?.Invoke(sender, e);
	}
}
