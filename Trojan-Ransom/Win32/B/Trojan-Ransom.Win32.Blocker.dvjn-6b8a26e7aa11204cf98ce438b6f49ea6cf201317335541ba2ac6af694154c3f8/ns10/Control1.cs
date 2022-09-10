using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns7;

namespace ns10;

[DesignerCategory("Code")]
internal class Control1 : Control
{
	private Label label_0;

	private Image image_0;

	private Icon icon_0;

	private Bitmap bitmap_0;

	private Enum2 enum2_0;

	private float float_0;

	private float float_1;

	public Enum2 IconState
	{
		get
		{
			return enum2_0;
		}
		set
		{
			int num = 5;
			if (!APOli14vlaUq9FZlZ7O())
			{
				goto IL_001b;
			}
			goto IL_0080;
			IL_0080:
			switch (num)
			{
			case 0:
			case 5:
				if (enum2_0 == value)
				{
					return;
				}
				break;
			case 4:
				break;
			case 2:
				goto IL_0029;
			default:
				goto IL_006e;
			case 6:
				return;
			}
			goto IL_001b;
			IL_006e:
			((Control)this).Refresh();
			num = 6;
			if (wmec5v4o5sx8pP5Xhv3())
			{
				return;
			}
			goto IL_0080;
			IL_001b:
			enum2_0 = value;
			Enum2 @enum = enum2_0;
			goto IL_0029;
			IL_0029:
			switch (@enum)
			{
			default:
				bitmap_0 = null;
				break;
			case Enum2.const_1:
				bitmap_0 = Class42.smethod_48(Class14.smethod_0(2536));
				break;
			case Enum2.const_2:
				bitmap_0 = Class42.smethod_48(Class14.smethod_0(2549));
				break;
			}
			goto IL_006e;
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
			if (APOli14vlaUq9FZlZ7O())
			{
				switch (5)
				{
				case 1:
					break;
				case 5:
					goto IL_003e;
				case 0:
					goto IL_0051;
				default:
					goto IL_006b;
				case 4:
				case 6:
					goto IL_0085;
				case 7:
					return;
				}
				continue;
			}
			goto IL_0051;
			IL_0085:
			bitmap_0 = null;
			break;
			IL_006b:
			image_0 = null;
			goto IL_0072;
			IL_003e:
			if (icon_0 != null)
			{
				icon_0.Dispose();
				goto IL_0051;
			}
			goto IL_0058;
			IL_0072:
			if (bitmap_0 == null)
			{
				break;
			}
			((Image)bitmap_0).Dispose();
			goto IL_0085;
			IL_0051:
			icon_0 = null;
			goto IL_0058;
			IL_0058:
			if (image_0 != null)
			{
				image_0.Dispose();
				goto IL_006b;
			}
			goto IL_0072;
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
		while (true)
		{
			((Control)this).OnPaint(e);
			while (true)
			{
				e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
				e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
				while (true)
				{
					Rectangle rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
					if (image_0 == null)
					{
						if (icon_0 == null)
						{
							return;
						}
						e.get_Graphics().DrawIcon(icon_0, rectangle);
						if (wmec5v4o5sx8pP5Xhv3())
						{
						}
						switch (6)
						{
						default:
							return;
						case 2:
						case 3:
							break;
						case 1:
							goto end_IL_0059;
						case 5:
							goto end_IL_00c4;
						case 0:
							return;
						case 4:
						case 6:
							if (bitmap_0 != null)
							{
								e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(rectangle.Right - Convert.ToInt32(12f * float_0), rectangle.Bottom - Convert.ToInt32(12f * float_1), Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
							}
							return;
						case 7:
							return;
						}
						continue;
					}
					e.get_Graphics().DrawImage(image_0, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
					return;
					continue;
					end_IL_0059:
					break;
				}
				continue;
				end_IL_00c4:
				break;
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
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		while (true)
		{
			label_0 = new Label();
			int num = 2;
			if (!APOli14vlaUq9FZlZ7O())
			{
				break;
			}
			while (true)
			{
				switch (num)
				{
				default:
					num = 6;
					if (!wmec5v4o5sx8pP5Xhv3())
					{
						continue;
					}
					return;
				case 0:
				case 1:
					break;
				case 2:
					float_0 = 1f;
					float_1 = 1f;
					goto case 5;
				case 5:
					((Control)this)._002Ector();
					try
					{
						label_0.set_FlatStyle((FlatStyle)3);
						((Control)label_0).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
					}
					catch
					{
					}
					((Control)this).get_Controls().Add((Control)(object)label_0);
					goto case 3;
				case 3:
				case 6:
					((Control)this).set_BackColor(SystemColors.Window);
					goto end_IL_0036;
				case 4:
					goto end_IL_0036;
				case 7:
					return;
				}
				break;
			}
			continue;
			end_IL_0036:
			break;
		}
		((Control)this).set_TabStop(false);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		icon_0 = Class42.smethod_32();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public Control1(string text)
		: this()
	{
		((Control)label_0).set_Text(text);
	}

	internal static bool APOli14vlaUq9FZlZ7O()
	{
		return true;
	}

	internal static bool wmec5v4o5sx8pP5Xhv3()
	{
		return false;
	}
}
