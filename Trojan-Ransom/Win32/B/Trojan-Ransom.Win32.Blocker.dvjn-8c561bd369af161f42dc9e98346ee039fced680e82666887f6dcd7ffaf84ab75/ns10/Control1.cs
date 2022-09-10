using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns7;

namespace ns10;

[DesignerCategory("Code")]
internal class Control1 : Control
{
	private Label label_0 = new Label();

	private Image image_0;

	private Icon icon_0;

	private Bitmap bitmap_0;

	private Enum2 enum2_0;

	private float float_0 = 1f;

	private float float_1 = 1f;

	public Enum2 IconState
	{
		get
		{
			return enum2_0;
		}
		set
		{
			int num = 4;
			if (!fFuC4ArwbYLYqdHWJfs())
			{
				goto IL_000d;
			}
			goto IL_0033;
			IL_0033:
			Enum2 @enum = default(Enum2);
			switch (num)
			{
			case 1:
				break;
			case 0:
			case 4:
				goto IL_0028;
			case 2:
			case 5:
				switch (@enum)
				{
				default:
					bitmap_0 = null;
					break;
				case Enum2.const_1:
					bitmap_0 = Class33.smethod_112(Class14.smethod_0(6245));
					break;
				case Enum2.const_2:
					bitmap_0 = Class33.smethod_112(Class14.smethod_0(6258));
					break;
				}
				goto default;
			default:
				((Control)this).Refresh();
				return;
			case 6:
				return;
			}
			goto IL_000d;
			IL_0028:
			if (enum2_0 != value)
			{
				goto IL_000d;
			}
			return;
			IL_000d:
			enum2_0 = value;
			@enum = enum2_0;
			num = 5;
			if (!fFuC4ArwbYLYqdHWJfs())
			{
				goto IL_0028;
			}
			goto IL_0033;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	string Text
	{
		get
		{
			return ((Control)label_0).get_Text();
		}
		set
		{
			((Control)label_0).set_Text(value);
		}
	}

	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
			((Control)this).Refresh();
		}
	}

	void Control.Dispose(bool disposing)
	{
		while (disposing)
		{
			while (true)
			{
				if (icon_0 != null)
				{
					icon_0.Dispose();
					if (g1PWXmrQtHFnlRr28U0())
					{
					}
					switch (4)
					{
					case 1:
					case 6:
						break;
					case 0:
					case 3:
						goto end_IL_0041;
					case 4:
						goto IL_0050;
					default:
						goto IL_0079;
					case 2:
						goto IL_0084;
					case 7:
						return;
					}
					continue;
				}
				goto IL_0057;
				IL_0084:
				bitmap_0 = null;
				goto end_IL_004b;
				IL_0079:
				((Image)bitmap_0).Dispose();
				goto IL_0084;
				IL_0050:
				icon_0 = null;
				goto IL_0057;
				IL_0057:
				if (image_0 != null)
				{
					image_0.Dispose();
					image_0 = null;
				}
				if (bitmap_0 == null)
				{
					goto end_IL_004b;
				}
				goto IL_0079;
				continue;
				end_IL_0041:
				break;
			}
			continue;
			end_IL_004b:
			break;
		}
		((Control)this).Dispose(disposing);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(13f * float_0), Convert.ToInt32(15f * float_1), ((Control)this).get_Width() - Convert.ToInt32(69f * float_0), ((Control)this).get_Height() - Convert.ToInt32(18f * float_1));
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
		e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
		e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
		Rectangle rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
		if (image_0 != null)
		{
			e.get_Graphics().DrawImage(image_0, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
		}
		else if (icon_0 != null)
		{
			e.get_Graphics().DrawIcon(icon_0, rectangle);
			if (bitmap_0 != null)
			{
				e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(rectangle.Right - Convert.ToInt32(12f * float_0), rectangle.Bottom - Convert.ToInt32(12f * float_1), Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			}
		}
	}

	void Control.OnFontChanged(EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			((Control)label_0).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
			((Control)this).OnFontChanged(e);
		}
		catch
		{
		}
	}

	public Control1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		try
		{
			label_0.set_FlatStyle((FlatStyle)3);
			((Control)label_0).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
		}
		catch
		{
		}
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).set_BackColor(SystemColors.Window);
		((Control)this).set_TabStop(false);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		icon_0 = Class33.smethod_5();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public Control1(string text)
		: this()
	{
		((Control)label_0).set_Text(text);
	}

	internal static bool fFuC4ArwbYLYqdHWJfs()
	{
		return true;
	}

	internal static bool g1PWXmrQtHFnlRr28U0()
	{
		return false;
	}
}
