using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
internal class Control3 : Control
{
	internal int int_0 = 99;

	private readonly Bitmap bitmap_0 = Class58.smethod_55("data");

	private readonly Bitmap bitmap_1 = Class58.smethod_55("network");

	internal readonly Timer timer_0 = new Timer();

	private float float_0 = 1f;

	private float float_1 = 1f;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Class58.smethod_134(((Control)this).get_Visible(), this);
		}
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		float_0 = dx;
		float_1 = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.Dispose(bool disposing)
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

	void Control.OnPaint(PaintEventArgs e)
	{
		if (!aZJSbevI4sxcFjl8TtQ())
		{
			switch (4)
			{
			case 0:
			case 4:
				break;
			case 1:
			case 5:
				goto IL_0039;
			case 3:
				goto IL_0041;
			default:
				goto IL_008a;
			case 6:
				return;
			}
		}
		((Control)this).OnPaint(e);
		goto IL_0039;
		IL_008a:
		if (bitmap_0 != null && int_0 > 0)
		{
			e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
		}
		return;
		IL_0041:
		e.get_Graphics().DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
		goto IL_008a;
		IL_0039:
		if (bitmap_1 != null)
		{
			goto IL_0041;
		}
		goto IL_008a;
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (db6n6ZvDis9GBBIsWUQ())
		{
			switch (4)
			{
			case 4:
				int_0 += 11;
				break;
			case 0:
			case 1:
				break;
			default:
				goto IL_004a;
			case 5:
				return;
			}
		}
		if (int_0 > 198)
		{
			goto IL_004a;
		}
		goto IL_0051;
		IL_004a:
		int_0 = 0;
		goto IL_0051;
		IL_0051:
		((Control)this).Refresh();
	}

	public Control3()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		timer_0.set_Interval(85);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}

	internal static bool db6n6ZvDis9GBBIsWUQ()
	{
		return true;
	}

	internal static bool aZJSbevI4sxcFjl8TtQ()
	{
		return false;
	}
}
