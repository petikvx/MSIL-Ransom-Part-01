using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class WaitSendingReportControl : Control
{
	internal int int_0 = 99;

	internal Bitmap bitmap_0;

	internal Bitmap bitmap_1;

	internal Timer timer_0;

	internal float float_0;

	internal float float_1;

	protected override void OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			method_0(((Control)this).get_Visible());
		}
	}

	private void method_0(bool bool_0)
	{
		timer_0.set_Enabled(bool_0);
		int_0 = 0;
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		float num = (float_0 = dx);
		float num2 = (float_1 = dy);
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (bitmap_0 != null)
			{
				UnhandledExceptionHandlerWithUI.smethod_1((Image)(object)bitmap_0, 262, 278);
			}
			Class30.smethod_2((Component)(object)timer_0, 257, 284);
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (bitmap_1 != null)
		{
			e.get_Graphics().DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
		}
		if (bitmap_0 != null && int_0 > 0)
		{
			Class33.smethod_9(e.get_Graphics(), new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)), 1002, 1014);
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		int_0 += 11;
		if (int_0 > 198)
		{
			int_0 = 0;
		}
		((Control)this).Refresh();
	}

	public WaitSendingReportControl()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		Bitmap val = (bitmap_0 = Class19.smethod_0("data"));
		Bitmap val2 = (bitmap_1 = Class19.smethod_0("network"));
		Timer val3 = (timer_0 = new Timer());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		timer_0.set_Interval(85);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		Class30.smethod_5((Control)(object)this, new Size(250, 42), 992, 937);
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}

	static WaitSendingReportControl()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static string[] smethod_0(string string_0, char[] char_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 89:
				return string_0.Split(char_0);
			}
		}
	}

	internal static void smethod_1(Stream stream_0, byte byte_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 84:
				stream_0.WriteByte(byte_0);
				return;
			}
		}
	}

	internal static Exception smethod_2(int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 42:
				return ProjectData.CreateProjectError(int_1);
			}
		}
	}

	internal static void smethod_3(Thread thread_0, object object_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 59:
				thread_0.Start(object_0);
				return;
			}
		}
	}

	internal static string smethod_4(object object_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 75:
				return object_0.ToString();
			}
		}
	}
}
