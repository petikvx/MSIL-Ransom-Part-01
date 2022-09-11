using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
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

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
		float_0 = dx;
		float_1 = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		int num = 5;
		if (!SwS6sOpyG3ov9cejG39())
		{
		}
		while (true)
		{
			switch (num)
			{
			default:
				num = 0;
				if (!SwS6sOpyG3ov9cejG39())
				{
				}
				continue;
			case 5:
				((Control)this).OnPaint(e);
				goto case 1;
			case 1:
			case 2:
				if (((Component)this).DesignMode)
				{
					image_0 = (Image)(object)Class56.smethod_96("current");
					goto case 3;
				}
				goto case 0;
			case 3:
				bool_0 = true;
				goto case 0;
			case 0:
				if (image_0 != null && bool_1)
				{
					e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
				}
				break;
			case 4:
			case 6:
				break;
			case 7:
				return;
			}
			break;
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

	public Control0(string text)
		: this()
	{
		((Control)this).set_Text(" " + text);
	}

	void Control.Dispose(bool disposing)
	{
		if (!SwS6sOpyG3ov9cejG39())
		{
			switch (4)
			{
			case 0:
			case 4:
				if (disposing)
				{
					goto case 1;
				}
				goto IL_0053;
			case 1:
			case 3:
				if (image_0 != null)
				{
					break;
				}
				goto IL_0048;
			case 2:
				break;
			default:
				goto IL_0053;
			case 6:
				return;
			}
		}
		image_0.Dispose();
		goto IL_0048;
		IL_0048:
		((Component)(object)timer_0).Dispose();
		goto IL_0053;
		IL_0053:
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool_1 = !bool_1;
		((Control)this).Refresh();
	}

	internal static bool fgracgpvXHID47OVVgL()
	{
		return true;
	}

	internal static bool SwS6sOpyG3ov9cejG39()
	{
		return false;
	}
}
