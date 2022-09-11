using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns10;

internal class Control0 : Control
{
	private readonly Label label_0 = new Label();

	internal Image image_0;

	internal bool bool_0;

	internal readonly Timer timer_0 = new Timer();

	internal bool bool_1 = true;

	internal string string_0 = string.Empty;

	private float float_0 = 1f;

	private float float_1 = 1f;

	string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			((Control)this).Refresh();
		}
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(22f * float_0), Convert.ToInt32(float_1), ((Control)this).get_Width() - Convert.ToInt32(22f * float_0), ((Control)this).get_Height() - Convert.ToInt32(float_1));
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
				while (true)
				{
					((Control)this).ScaleCore(dx, dy);
					((Control)this).OnResize(EventArgs.Empty);
					if (!BInqREGQ2CMNwb6KuIX())
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
						goto end_IL_0042;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				continue;
				end_IL_0042:
				break;
			}
		}
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			image_0 = (Image)(object)Class17.smethod_9("current");
			bool_0 = true;
		}
		if (image_0 != null && bool_1)
		{
			e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (bool_0)
		{
			((Control)label_0).set_Text((string_0.Length > 0) ? (((Control)this).get_Text() + " (" + string_0 + ")") : ((Control)this).get_Text());
		}
		else
		{
			((Control)label_0).set_Text(string.Empty);
		}
	}

	public Control0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		timer_0.set_Interval(250);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	void Control.Dispose(bool disposing)
	{
		while (disposing)
		{
			int num = 5;
			if (Gm01K8GjCXKUCmjkbmL())
			{
				return;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
				case 5:
					if (image_0 != null)
					{
						num = 3;
						if (BInqREGQ2CMNwb6KuIX())
						{
							continue;
						}
						goto case 2;
					}
					goto default;
				case 4:
					break;
				case 2:
				case 3:
					image_0.Dispose();
					goto default;
				default:
					((Component)(object)timer_0).Dispose();
					goto end_IL_0048;
				case 6:
					return;
				}
				break;
			}
			continue;
			end_IL_0048:
			break;
		}
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool_1 = !bool_1;
		((Control)this).Refresh();
	}

	internal static bool BInqREGQ2CMNwb6KuIX()
	{
		return true;
	}

	internal static bool Gm01K8GjCXKUCmjkbmL()
	{
		return false;
	}
}
