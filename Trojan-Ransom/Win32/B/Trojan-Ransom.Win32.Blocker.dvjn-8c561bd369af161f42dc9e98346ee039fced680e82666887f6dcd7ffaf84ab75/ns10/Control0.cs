using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns7;

namespace ns10;

[DesignerCategory("Code")]
internal class Control0 : Control
{
	private readonly Label label_0;

	internal Image image_0;

	internal bool bool_0;

	internal readonly Timer timer_0;

	internal bool bool_1;

	internal string string_0;

	private float float_0;

	private float float_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
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
				IL_0041:
				float_1 = dy;
				while (true)
				{
					((Control)this).ScaleCore(dx, dy);
					((Control)this).OnResize(EventArgs.Empty);
					if (!URSNQCrH1AIb15NumHO())
					{
						break;
					}
					switch (5)
					{
					case 1:
					case 4:
						goto IL_0041;
					case 0:
						goto end_IL_0003;
					case 5:
						return;
					}
					continue;
					end_IL_0003:
					break;
				}
				break;
			}
		}
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		if (((Component)this).DesignMode)
		{
			image_0 = (Image)(object)Class33.smethod_112(Class14.smethod_0(2036));
			bool_0 = true;
		}
		if (image_0 != null && bool_1)
		{
			e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (bool_0)
		{
			((Control)label_0).set_Text((string_0.Length > 0) ? (((Control)this).get_Text() + Class14.smethod_0(6240) + string_0 + Class14.smethod_0(3240)) : ((Control)this).get_Text());
		}
		else
		{
			((Control)label_0).set_Text(string.Empty);
		}
	}

	public Control0()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		while (true)
		{
			label_0 = new Label();
			while (true)
			{
				timer_0 = new Timer();
				if (URSNQCrH1AIb15NumHO())
				{
					switch (6)
					{
					case 1:
					case 2:
						break;
					case 0:
					case 4:
						goto end_IL_0003;
					case 6:
						bool_1 = true;
						string_0 = string.Empty;
						float_0 = 1f;
						float_1 = 1f;
						goto default;
					default:
						((Control)this)._002Ector();
						timer_0.set_Interval(250);
						timer_0.add_Tick((EventHandler)timer_0_Tick);
						label_0.set_FlatStyle((FlatStyle)3);
						((Control)this).get_Controls().Add((Control)(object)label_0);
						((Control)this).SetStyle((ControlStyles)75794, true);
						goto IL_00cf;
					case 5:
						goto IL_00cf;
					case 7:
						return;
					}
					continue;
				}
				goto IL_00cf;
				IL_00cf:
				((Control)this).set_TabStop(false);
				return;
				continue;
				end_IL_0003:
				break;
			}
		}
	}

	public Control0(string text)
		: this()
	{
		((Control)this).set_Text(Class14.smethod_0(1175) + text);
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

	internal static bool URSNQCrH1AIb15NumHO()
	{
		return true;
	}

	internal static bool dtyGKrr9jU4Py1sBvDI()
	{
		return false;
	}
}
