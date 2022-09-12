using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns6;

namespace ns7;

internal sealed class Control0 : Control
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
		float_0 = dx;
		float_1 = dy;
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			image_0 = (Image)(object)Class3.smethod_65("current");
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

	public Control0(string string_1)
		: this()
	{
		((Control)this).set_Text(" " + string_1);
	}

	void Control.Dispose(bool disposing)
	{
		if (disposing)
		{
			if (image_0 != null)
			{
				image_0.Dispose();
			}
			((Component)(object)timer_0).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool_1 = !bool_1;
		((Control)this).Refresh();
	}
}
