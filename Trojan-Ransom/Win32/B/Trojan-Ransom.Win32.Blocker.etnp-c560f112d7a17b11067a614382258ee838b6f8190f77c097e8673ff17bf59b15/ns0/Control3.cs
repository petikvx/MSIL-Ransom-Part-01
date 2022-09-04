using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control3 : Control
{
	private int int_0 = 99;

	private readonly Bitmap bitmap_0 = Class28.smethod_0(Class5.smethod_0(82207));

	private readonly Bitmap bitmap_1 = Class28.smethod_0(Class5.smethod_0(82216));

	private readonly Timer timer_0 = new Timer();

	private float float_0 = 1f;

	private float float_1 = 1f;

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

	protected override void OnVisibleChanged(EventArgs e)
	{
		if (1 == 0)
		{
			goto IL_000f;
		}
		if (0 == 0)
		{
			((Control)this).OnVisibleChanged(e);
		}
		goto IL_0021;
		IL_001b:
		if (0 == 0 && 0 == 0)
		{
			return;
		}
		goto IL_0021;
		IL_0021:
		if (!((Component)this).DesignMode)
		{
			goto IL_000f;
		}
		goto IL_001b;
		IL_000f:
		method_0(((Control)this).get_Visible());
		goto IL_001b;
	}

	private void method_0(bool CO_)
	{
		timer_0.set_Enabled(CO_);
		int_0 = 0;
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		do
		{
			((Control)this).set_Size(new Size(Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)));
			if (0 == 0)
			{
				((Control)this).OnResize(e);
			}
		}
		while (7 == 0);
	}

	protected override void ScaleCore(float x, float y)
	{
		if (4 == 0)
		{
			return;
		}
		float_0 = x;
		if (6 == 0)
		{
			return;
		}
		float_1 = y;
		do
		{
			if (0 == 0)
			{
				((Control)this).ScaleCore(x, y);
			}
		}
		while (false);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		while (true)
		{
			if (disposing)
			{
				goto IL_0003;
			}
			goto IL_002a;
			IL_002a:
			((Control)this).Dispose(disposing);
			if (8u != 0)
			{
				break;
			}
			goto IL_001c;
			IL_001c:
			if (false)
			{
				goto IL_0003;
			}
			((Component)(object)timer_0).Dispose();
			goto IL_002a;
			IL_0003:
			if (bitmap_0 != null)
			{
				if ((2 == 0) ? true : false)
				{
					continue;
				}
				((Image)bitmap_0).Dispose();
			}
			goto IL_001c;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (0 == 0)
		{
			((Control)this).OnPaint(e);
		}
		while (true)
		{
			if (bitmap_1 != null)
			{
				e.get_Graphics().DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
			}
			if (bitmap_0 != null && int_0 > 0)
			{
				if (5u != 0)
				{
					e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
					e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
					break;
				}
				continue;
			}
			break;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int_0 += 11;
			if (int_0 > 198)
			{
				if (false)
				{
					goto IL_001e;
				}
				int_0 = 0;
			}
			goto IL_0021;
			IL_0021:
			((Control)this).Refresh();
			goto IL_001e;
			IL_001e:
			if (0 == 0)
			{
				if (0 == 0)
				{
					break;
				}
				continue;
			}
			goto IL_0021;
		}
	}
}
