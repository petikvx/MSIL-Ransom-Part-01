using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns10;

namespace ns13;

[DesignerCategory("Code")]
internal class Control1 : Control
{
	private Label label_0;

	private Image image_0;

	private Icon icon_0;

	private Bitmap bitmap_0;

	private Enum5 enum5_0;

	private float float_0;

	private float float_1;

	public Enum5 IconState
	{
		get
		{
			return enum5_0;
		}
		set
		{
			if (enum5_0 != value)
			{
				enum5_0 = value;
				switch (enum5_0)
				{
				default:
					bitmap_0 = null;
					break;
				case Enum5.const_1:
					bitmap_0 = Class12.smethod_91(Class32.smethod_0(6405));
					break;
				case Enum5.const_2:
					bitmap_0 = Class12.smethod_91(Class32.smethod_0(6418));
					break;
				}
				((Control)this).Refresh();
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
		if (disposing)
		{
			if (icon_0 != null)
			{
				icon_0.Dispose();
				icon_0 = null;
			}
			if (image_0 != null)
			{
				image_0.Dispose();
				image_0 = null;
			}
			if (bitmap_0 != null)
			{
				((Image)bitmap_0).Dispose();
				bitmap_0 = null;
			}
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
		int num = 4;
		if (!oJnydKRPoKdNpBoL0qG())
		{
			while (true)
			{
				switch (num)
				{
				case 0:
				case 4:
					float_0 = dx;
					num = 2;
					if (oJnydKRPoKdNpBoL0qG())
					{
					}
					continue;
				default:
					num = 3;
					if (!oJnydKRPoKdNpBoL0qG())
					{
					}
					continue;
				case 1:
				case 2:
					float_1 = dy;
					((Control)this).ScaleCore(dx, dy);
					break;
				case 3:
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
		Rectangle rectangle = default(Rectangle);
		while (true)
		{
			((Control)this).OnPaint(e);
			if (RVXfdbRgKhMA2Zt9nWl())
			{
				switch (5)
				{
				case 3:
					continue;
				case 1:
				case 5:
					e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
					e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
					goto case 0;
				case 0:
					rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
					break;
				case 4:
				case 6:
					return;
				case 7:
					return;
				}
				break;
			}
			return;
		}
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		while (true)
		{
			label_0 = new Label();
			while (true)
			{
				float_0 = 1f;
				float_1 = 1f;
				((Control)this)._002Ector();
				if (!RVXfdbRgKhMA2Zt9nWl())
				{
					return;
				}
				switch (2)
				{
				case 1:
				case 6:
					continue;
				case 4:
					break;
				case 2:
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
					goto default;
				default:
					icon_0 = Class12.smethod_33();
					goto case 5;
				case 5:
					((Control)this).OnResize(EventArgs.Empty);
					return;
				case 7:
					return;
				}
				break;
			}
		}
	}

	public Control1(string text)
		: this()
	{
		((Control)label_0).set_Text(text);
	}

	internal static bool RVXfdbRgKhMA2Zt9nWl()
	{
		return true;
	}

	internal static bool oJnydKRPoKdNpBoL0qG()
	{
		return false;
	}
}
