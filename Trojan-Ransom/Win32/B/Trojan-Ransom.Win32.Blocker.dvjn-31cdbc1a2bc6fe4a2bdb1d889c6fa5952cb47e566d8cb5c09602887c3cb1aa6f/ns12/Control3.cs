using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
internal class Control3 : Control
{
	internal int int_0 = 99;

	private readonly Bitmap bitmap_0 = Class21.smethod_102("data");

	private readonly Bitmap bitmap_1 = Class21.smethod_102("network");

	internal readonly Timer timer_0 = new Timer();

	private float float_0 = 1f;

	private float float_1 = 1f;

	void Control.OnVisibleChanged(EventArgs e)
	{
		while (true)
		{
			((Control)this).OnVisibleChanged(e);
			while (true)
			{
				if (((Component)this).DesignMode)
				{
					return;
				}
				while (true)
				{
					Class21.smethod_12(this, ((Control)this).get_Visible());
					if (!KeeyCgXmhqRWlvHdu07())
					{
						break;
					}
					switch (5)
					{
					case 1:
					case 2:
						goto end_IL_0003;
					case 0:
					case 4:
						goto end_IL_003b;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_003b:
				break;
			}
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
		if (zjah1hXLh3O8ySitC8E())
		{
		}
		switch (2)
		{
		case 2:
			if (!disposing)
			{
				break;
			}
			goto case 1;
		case 1:
		case 4:
			if (bitmap_0 != null)
			{
				goto case 0;
			}
			goto IL_0045;
		case 0:
			((Image)bitmap_0).Dispose();
			goto IL_0045;
		case 6:
			return;
			IL_0045:
			((Component)(object)timer_0).Dispose();
			break;
		}
		((Control)this).Dispose(disposing);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			if (!zjah1hXLh3O8ySitC8E())
			{
				switch (0)
				{
				case 4:
					break;
				case 0:
					goto IL_0038;
				case 2:
				case 5:
					goto IL_0089;
				default:
					goto IL_00a0;
				case 6:
					return;
				}
				continue;
			}
			goto IL_0038;
			IL_0089:
			if (bitmap_0 == null || int_0 <= 0)
			{
				break;
			}
			goto IL_00a0;
			IL_0038:
			if (bitmap_1 != null)
			{
				e.get_Graphics().DrawImage((Image)(object)bitmap_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
			}
			goto IL_0089;
			IL_00a0:
			e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
			break;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		while (true)
		{
			int_0 += 11;
			if (zjah1hXLh3O8ySitC8E())
			{
			}
			switch (0)
			{
			case 4:
				continue;
			case 0:
			case 1:
				if (int_0 > 198)
				{
					int_0 = 0;
				}
				break;
			case 5:
				return;
			}
			break;
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

	internal static bool KeeyCgXmhqRWlvHdu07()
	{
		return true;
	}

	internal static bool zjah1hXLh3O8ySitC8E()
	{
		return false;
	}
}
