using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns10;

namespace ns13;

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
		int num = 4;
		if (GSDbGiRhWuwr5o7uvDv())
		{
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					float_0 = dx;
					num = 2;
					if (!Ab6PGGR5XDMSbn0d7iD())
					{
					}
					continue;
				case 1:
				case 2:
					float_1 = dy;
					((Control)this).ScaleCore(dx, dy);
					break;
				case 5:
					return;
				}
				break;
			}
		}
		((Control)this).OnResize(EventArgs.Empty);
	}

	void Control.OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			((Control)this).OnPaint(e);
			while (true)
			{
				IL_0061:
				if (((Component)this).DesignMode)
				{
					image_0 = (Image)(object)Class12.smethod_91(Class32.smethod_0(3439));
					goto IL_0036;
				}
				goto IL_003d;
				IL_0036:
				bool_0 = true;
				goto IL_003d;
				IL_003d:
				while (true)
				{
					if (image_0 != null)
					{
						if (!Ab6PGGR5XDMSbn0d7iD())
						{
							switch (0)
							{
							case 6:
								break;
							default:
								continue;
							case 5:
								goto IL_0061;
							case 1:
								goto end_IL_0061;
							case 0:
							case 4:
								goto IL_007a;
							case 7:
								return;
							}
							break;
						}
						return;
					}
					goto IL_00c8;
					IL_007a:
					if (bool_1)
					{
						e.get_Graphics().DrawImage(image_0, new Rectangle(0, 0, Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
					}
					goto IL_00c8;
					IL_00c8:
					if (bool_0)
					{
						((Control)label_0).set_Text((string_0.Length > 0) ? (((Control)this).get_Text() + Class32.smethod_0(6400) + string_0 + Class32.smethod_0(4800)) : ((Control)this).get_Text());
					}
					else
					{
						((Control)label_0).set_Text(string.Empty);
					}
					return;
				}
				goto IL_0036;
				continue;
				end_IL_0061:
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
		((Control)this).set_Text(Class32.smethod_0(3233) + text);
	}

	void Control.Dispose(bool disposing)
	{
		while (disposing)
		{
			while (image_0 != null)
			{
				if (GSDbGiRhWuwr5o7uvDv())
				{
					switch (5)
					{
					case 1:
					case 3:
						break;
					case 0:
					case 4:
						goto IL_003c;
					case 5:
						image_0.Dispose();
						goto end_IL_0032;
					default:
						goto end_IL_0032;
					case 6:
						return;
					}
					continue;
				}
				break;
				continue;
				end_IL_0032:
				break;
			}
			((Component)(object)timer_0).Dispose();
			break;
			IL_003c:;
		}
		((Control)this).Dispose(disposing);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool_1 = !bool_1;
		((Control)this).Refresh();
	}

	internal static bool GSDbGiRhWuwr5o7uvDv()
	{
		return true;
	}

	internal static bool Ab6PGGR5XDMSbn0d7iD()
	{
		return false;
	}
}
