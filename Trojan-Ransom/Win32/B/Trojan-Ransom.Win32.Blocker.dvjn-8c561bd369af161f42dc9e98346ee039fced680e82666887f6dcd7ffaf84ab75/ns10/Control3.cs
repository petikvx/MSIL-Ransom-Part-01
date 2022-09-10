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

	private readonly Bitmap bitmap_0 = Class33.smethod_112(Class14.smethod_0(6556));

	private readonly Bitmap bitmap_1 = Class33.smethod_112(Class14.smethod_0(6565));

	internal readonly Timer timer_0 = new Timer();

	private float float_0 = 1f;

	private float float_1 = 1f;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Class33.smethod_64(this, ((Control)this).get_Visible());
		}
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)this).set_Size(new Size(Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)));
		((Control)this).OnResize(e);
	}

	void Control.ScaleCore(float dx, float dy)
	{
		int num = 4;
		if (!w4oML2rBCi4bMKx5Z3u())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 0:
			case 4:
				float_0 = dx;
				num = 3;
				if (G2DHHPrc1rlNoWE3Tp7())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				float_1 = dy;
				break;
			case 5:
				return;
			}
			break;
		}
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.Dispose(bool disposing)
	{
		if (!w4oML2rBCi4bMKx5Z3u())
		{
			switch (5)
			{
			case 5:
				break;
			case 4:
				goto IL_0035;
			case 1:
			case 2:
				goto IL_003d;
			default:
				goto IL_0053;
			case 6:
				return;
			}
		}
		if (disposing)
		{
			goto IL_0035;
		}
		goto IL_0053;
		IL_0053:
		((Control)this).Dispose(disposing);
		return;
		IL_0048:
		((Component)(object)timer_0).Dispose();
		goto IL_0053;
		IL_0035:
		if (bitmap_0 != null)
		{
			goto IL_003d;
		}
		goto IL_0048;
		IL_003d:
		((Image)bitmap_0).Dispose();
		goto IL_0048;
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			while (true)
			{
				if (bitmap_1 != null)
				{
					e.get_Graphics().DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
				}
				if (bitmap_0 == null)
				{
					return;
				}
				while (true)
				{
					if (int_0 <= 0)
					{
						return;
					}
					e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
					while (true)
					{
						e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
						if (!G2DHHPrc1rlNoWE3Tp7())
						{
							break;
						}
						switch (6)
						{
						case 3:
							goto end_IL_005a;
						case 1:
						case 4:
							goto end_IL_00f2;
						case 0:
						case 5:
							goto end_IL_014e;
						case 6:
							return;
						}
						continue;
						end_IL_005a:
						break;
					}
					continue;
					end_IL_00f2:
					break;
				}
				continue;
				end_IL_014e:
				break;
			}
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

	internal static bool G2DHHPrc1rlNoWE3Tp7()
	{
		return true;
	}

	internal static bool w4oML2rBCi4bMKx5Z3u()
	{
		return false;
	}
}
