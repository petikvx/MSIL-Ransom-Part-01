using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
internal class Control3 : Control
{
	internal int int_0;

	private readonly Bitmap bitmap_0;

	private readonly Bitmap bitmap_1;

	internal readonly Timer timer_0;

	private float float_0;

	private float float_1;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Class56.smethod_50(this, ((Control)this).get_Visible());
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
		int num = 4;
		if (!gDNxdSpQgKjty0GN5Ex())
		{
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				if (!disposing)
				{
					break;
				}
				num = 5;
				if (!gDNxdSpQgKjty0GN5Ex())
				{
					continue;
				}
				goto case 1;
			case 1:
			case 5:
				if (bitmap_0 != null)
				{
					((Image)bitmap_0).Dispose();
				}
				goto case 0;
			case 0:
				((Component)(object)timer_0).Dispose();
				break;
			case 6:
				return;
			}
			break;
		}
		((Control)this).Dispose(disposing);
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
				while (true)
				{
					if (bitmap_0 == null || int_0 <= 0)
					{
						return;
					}
					while (true)
					{
						e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
						e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
						if (gDNxdSpQgKjty0GN5Ex())
						{
							break;
						}
						switch (6)
						{
						case 2:
						case 4:
							goto end_IL_0012;
						case 1:
							goto end_IL_00ee;
						case 0:
						case 3:
							goto end_IL_0146;
						case 6:
							return;
						}
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_00ee:
					break;
				}
				continue;
				end_IL_0146:
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		while (true)
		{
			int_0 = 99;
			int num = 4;
			if (!HaBGHVprLZI6u6SbFRd())
			{
				break;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 0;
					if (!gDNxdSpQgKjty0GN5Ex())
					{
						continue;
					}
					goto case 2;
				case 6:
					break;
				case 1:
				case 4:
					bitmap_0 = Class56.smethod_96("data");
					goto case 5;
				case 5:
					bitmap_1 = Class56.smethod_96("network");
					timer_0 = new Timer();
					float_0 = 1f;
					float_1 = 1f;
					goto case 0;
				case 0:
				case 3:
					((Control)this)._002Ector();
					goto case 2;
				case 2:
					timer_0.set_Interval(85);
					timer_0.add_Tick((EventHandler)timer_0_Tick);
					((Control)this).set_Size(new Size(250, 42));
					((Control)this).set_TabStop(false);
					((Control)this).SetStyle((ControlStyles)75794, true);
					return;
				case 7:
					return;
				}
				break;
			}
		}
	}

	internal static bool HaBGHVprLZI6u6SbFRd()
	{
		return true;
	}

	internal static bool gDNxdSpQgKjty0GN5Ex()
	{
		return false;
	}
}
