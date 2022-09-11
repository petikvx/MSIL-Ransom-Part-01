using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10;

internal class Control3 : Control
{
	internal int int_0 = 99;

	private readonly Bitmap bitmap_0 = Class17.smethod_9("data");

	private readonly Bitmap bitmap_1 = Class17.smethod_9("network");

	internal readonly Timer timer_0 = new Timer();

	private float float_0 = 1f;

	private float float_1 = 1f;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Class17.smethod_170(((Control)this).get_Visible(), this);
		}
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		while (true)
		{
			float_0 = dx;
			while (true)
			{
				float_1 = dy;
				((Control)this).ScaleCore(dx, dy);
				while (true)
				{
					((Control)this).OnResize(EventArgs.Empty);
					if (vjLa0wG3DK7CoBkBjSJ())
					{
						switch (5)
						{
						case 1:
						case 3:
							goto end_IL_0003;
						case 0:
						case 4:
							goto end_IL_0039;
						case 5:
							return;
						}
						continue;
					}
					return;
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_0039:
				break;
			}
		}
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
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		timer_0.set_Interval(85);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}

	internal static bool vjLa0wG3DK7CoBkBjSJ()
	{
		return true;
	}

	internal static bool djyxAEGuqYmLOwTK0mc()
	{
		return false;
	}
}
