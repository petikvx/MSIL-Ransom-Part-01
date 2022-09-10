using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns12;

[DesignerCategory("Code")]
internal class Control1 : Control
{
	private Label label_0 = new Label();

	private Image image_0;

	private Icon icon_0;

	private Bitmap bitmap_0;

	private Enum5 enum5_0;

	private float float_0 = 1f;

	private float float_1 = 1f;

	public Enum5 IconState
	{
		get
		{
			return enum5_0;
		}
		set
		{
			Enum5 @enum = default(Enum5);
			while (enum5_0 != value)
			{
				int num = 3;
				if (jB8dxqXwV4cqp38cHpP())
				{
					break;
				}
				while (true)
				{
					switch (num)
					{
					case 2:
					case 5:
						@enum = enum5_0;
						goto case 4;
					case 4:
						switch (@enum)
						{
						default:
							bitmap_0 = null;
							break;
						case Enum5.const_1:
							bitmap_0 = Class21.smethod_102("error16");
							break;
						case Enum5.const_2:
							bitmap_0 = Class21.smethod_102("warning16");
							break;
						}
						((Control)this).Refresh();
						num = 6;
						if (qZvB57XVDoZwa9gs4TB())
						{
							continue;
						}
						break;
					case 1:
					case 3:
						enum5_0 = value;
						goto case 2;
					default:
						num = 4;
						if (qZvB57XVDoZwa9gs4TB())
						{
							continue;
						}
						goto case 4;
					case 0:
						break;
					case 6:
						return;
					}
					break;
				}
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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
			if (!jB8dxqXwV4cqp38cHpP())
			{
				switch (6)
				{
				case 0:
				case 4:
					break;
				case 1:
				case 6:
					if (icon_0 != null)
					{
						icon_0.Dispose();
						goto case 5;
					}
					goto IL_0058;
				case 5:
					icon_0 = null;
					goto IL_0058;
				default:
					goto IL_007a;
				case 3:
					goto IL_0085;
				case 7:
					return;
					IL_0058:
					if (image_0 != null)
					{
						image_0.Dispose();
						image_0 = null;
					}
					if (bitmap_0 == null)
					{
						goto end_IL_0036;
					}
					goto IL_007a;
				}
				continue;
			}
			goto IL_007a;
			IL_007a:
			((Image)bitmap_0).Dispose();
			goto IL_0085;
			IL_0085:
			bitmap_0 = null;
			break;
			continue;
			end_IL_0036:
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
		icon_0 = Class21.smethod_169();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public Control1(string text)
		: this()
	{
		((Control)label_0).set_Text(text);
	}

	internal static bool qZvB57XVDoZwa9gs4TB()
	{
		return true;
	}

	internal static bool jB8dxqXwV4cqp38cHpP()
	{
		return false;
	}
}
