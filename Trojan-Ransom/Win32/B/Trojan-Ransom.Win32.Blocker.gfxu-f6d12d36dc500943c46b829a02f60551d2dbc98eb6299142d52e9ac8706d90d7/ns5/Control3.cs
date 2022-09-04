using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns4;

namespace ns5;

internal class Control3 : Control
{
	internal int int_0;

	private readonly object object_0;

	private readonly object object_1;

	internal readonly Timer timer_0;

	private float float_0;

	private float float_1;

	void Control.OnVisibleChanged(EventArgs e)
	{
		((Control)this).OnVisibleChanged(e);
		if (!((Component)this).DesignMode)
		{
			Class24.smethod_74(((Control)this).get_Visible(), this);
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
			if (object_0 != null)
			{
				((Image)object_0).Dispose();
			}
			((Component)(object)timer_0).Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (object_1 != null)
		{
			e.get_Graphics().DrawImage((Image)object_1, new Rectangle(0, 0, Convert.ToInt32(250f * float_0), Convert.ToInt32(42f * float_1)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
		}
		if (object_0 != null && int_0 > 0)
		{
			e.get_Graphics().SetClip(new Rectangle(Convert.ToInt32(46f * float_0), 0, Convert.ToInt32(165f * float_0), Convert.ToInt32(34f * float_1)));
			e.get_Graphics().DrawImage((Image)object_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
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
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Class42.hMqjKD0znI7T7();
		int_0 = 99;
		object_0 = Class24.smethod_10("data");
		object_1 = Class24.smethod_10("network");
		timer_0 = new Timer();
		float_0 = 1f;
		float_1 = 1f;
		((Control)this)._002Ector();
		timer_0.set_Interval(85);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)this).set_Size(new Size(250, 42));
		((Control)this).set_TabStop(false);
		((Control)this).SetStyle((ControlStyles)75794, true);
	}
}
