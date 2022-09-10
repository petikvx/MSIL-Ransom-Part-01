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
					if (!YF8dHZviA93CU1rnStm())
					{
						switch (5)
						{
						case 1:
						case 4:
							goto end_IL_0003;
						case 3:
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

	void Control.OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			while (true)
			{
				if (((Component)this).DesignMode)
				{
					goto IL_00a5;
				}
				goto IL_00bc;
				IL_00bc:
				if (image_0 != null)
				{
					goto IL_004a;
				}
				goto IL_0098;
				IL_0098:
				if (!bool_0)
				{
					((Control)label_0).set_Text(string.Empty);
					if (QCkAV3vlZUC3HkW9uwA())
					{
						switch (7)
						{
						case 2:
						case 6:
							goto IL_00a5;
						case 0:
							continue;
						case 5:
							goto end_IL_00c6;
						case 1:
						case 4:
							goto IL_00d9;
						case 7:
							return;
						}
					}
					goto IL_004a;
				}
				goto IL_00d9;
				IL_00a5:
				image_0 = (Image)(object)Class58.smethod_55("current");
				bool_0 = true;
				goto IL_00bc;
				IL_004a:
				if (bool_1)
				{
					e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
				}
				goto IL_0098;
				IL_00d9:
				((Control)label_0).set_Text((string_0.Length > 0) ? (((Control)this).get_Text() + " (" + string_0 + ")") : ((Control)this).get_Text());
				return;
				continue;
				end_IL_00c6:
				break;
			}
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

	internal static bool QCkAV3vlZUC3HkW9uwA()
	{
		return true;
	}

	internal static bool YF8dHZviA93CU1rnStm()
	{
		return false;
	}
}
