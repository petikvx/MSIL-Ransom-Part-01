using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns7;

namespace ns10;

[DesignerCategory("Code")]
internal class Control3 : Control
{
	internal int int_0 = 99;

	private readonly Bitmap bitmap_0 = Class42.smethod_48(Class14.smethod_0(2847));

	private readonly Bitmap bitmap_1 = Class42.smethod_48(Class14.smethod_0(2856));

	internal readonly Timer timer_0 = new Timer();

	private float float_0 = 1f;

	private float float_1 = 1f;

	void Control.OnVisibleChanged(EventArgs e)
	{
		if (!ImRsnZ4tB2DxNWuFAjn())
		{
			switch (4)
			{
			case 0:
			case 4:
				break;
			case 1:
				goto IL_0035;
			default:
				goto IL_003d;
			case 5:
				return;
			}
		}
		((Control)this).OnVisibleChanged(e);
		goto IL_0035;
		IL_003d:
		Class42.smethod_102(((Control)this).get_Visible(), this);
		return;
		IL_0035:
		if (((Component)this).DesignMode)
		{
			return;
		}
		goto IL_003d;
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

	public Control3()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		timer_0.set_Interval(85);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}

	internal static bool rWr7Hf4e3MCraacMj5S()
	{
		return true;
	}

	internal static bool ImRsnZ4tB2DxNWuFAjn()
	{
		return false;
	}
}
