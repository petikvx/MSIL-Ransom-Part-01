using System;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using SmartAssembly.SmartUsageCore;
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
				((Image)bitmap_0).Dispose();
			}
			smethod_2((Component)(object)timer_0, 710, 684);
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (bitmap_1 != null)
		{
			Class34.smethod_2(e, 49, 1).DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
		}
		if (bitmap_0 != null && int_0 > 0)
		{
			Class34.smethod_2(e, 783, 831).SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
			Class34.smethod_2(e, 508, 460).DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		int_0 += 11;
		if (int_0 > 198)
		{
			int_0 = 0;
		}
		SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2((Control)(object)this, 348, 277);
	}

	public WaitSendingReportControl()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		Bitmap val = (bitmap_0 = Class21.smethod_0("data"));
		Bitmap val2 = (bitmap_1 = Class21.smethod_0("network"));
		Timer val3 = (timer_0 = new Timer());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		timer_0.set_Interval(85);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}

	[SecuritySafeCritical]
	static WaitSendingReportControl()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(SymmetricAlgorithm symmetricAlgorithm_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 73:
				symmetricAlgorithm_0.GenerateIV();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_1(string string_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 97:
				return string_0.ToLower();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Component component_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 106:
				component_0.Dispose();
				return;
			}
		}
	}
}
