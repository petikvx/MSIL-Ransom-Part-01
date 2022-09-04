using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns4;

namespace ns5;

[DesignerCategory("Code")]
public class GControl3 : Control
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

	protected override void ScaleCore(float x, float y)
	{
		float num = (float_0 = x);
		float num2 = (float_1 = y);
		((Control)this).ScaleCore(x, y);
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
			((Component)(object)timer_0).Dispose();
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
			e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
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

	public GControl3()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		Bitmap val = (bitmap_0 = Class23.smethod_0("data"));
		Bitmap val2 = (bitmap_1 = Class23.smethod_0("network"));
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

	static GControl3()
	{
		GClass11.smethod_0();
	}
}
