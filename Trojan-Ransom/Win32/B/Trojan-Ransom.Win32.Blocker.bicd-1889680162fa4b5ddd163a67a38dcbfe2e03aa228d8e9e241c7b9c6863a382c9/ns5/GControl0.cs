using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns1;
using ns4;

namespace ns5;

[DesignerCategory("Code")]
public class GControl0 : Control
{
	internal Label label_0;

	internal Image image_0;

	internal bool bool_0;

	internal Timer timer_0;

	internal bool bool_1;

	internal string string_0;

	internal float float_0;

	internal float float_1;

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
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

	public void method_0()
	{
		timer_0.set_Enabled(false);
		Image val = (image_0 = null);
		bool_0 = false;
		string text = (string_0 = string.Empty);
		((Control)this).Refresh();
		((Control)this).set_Height(16);
	}

	public void method_1()
	{
		timer_0.set_Enabled(true);
		Image val = (image_0 = (Image)(object)Class23.smethod_0("current"));
		bool_0 = true;
		((Control)this).Refresh();
	}

	public void method_2()
	{
		method_3(string.Empty);
	}

	public void method_3(string string_1)
	{
		string text = (string_0 = string_1);
		timer_0.set_Enabled(false);
		Image val = (image_0 = (Image)(object)Class23.smethod_0((string_1.Length > 0) ? "error" : "ok"));
		bool_1 = true;
		bool_0 = true;
		if (string_1.Length > 0)
		{
			((Control)this).set_Height(100);
		}
		((Control)this).Refresh();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(22f * float_0), Convert.ToInt32(float_1), ((Control)this).get_Width() - Convert.ToInt32(22f * float_0), ((Control)this).get_Height() - Convert.ToInt32(float_1));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float x, float y)
	{
		float num = (float_0 = x);
		float num2 = (float_1 = y);
		((Control)this).ScaleCore(x, y);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			Image val = (image_0 = (Image)(object)Class23.smethod_0("current"));
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

	public GControl0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		Label val = (label_0 = new Label());
		Timer val2 = (timer_0 = new Timer());
		bool_1 = true;
		string text = (string_0 = string.Empty);
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		timer_0.set_Interval(250);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_TabStop(false);
	}

	public GControl0(string string_1)
		: this()
	{
		((Control)this).set_Text(" " + string_1);
	}

	protected override void Dispose(bool disposing)
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
		bool flag = (bool_1 = !bool_1);
		((Control)this).Refresh();
	}

	static GControl0()
	{
		GClass11.smethod_0();
	}
}
