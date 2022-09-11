using System;
using System.Drawing;
using System.Windows.Forms;

namespace ns10;

internal class Control1 : Control
{
	private Label label_0;

	internal Image image_0;

	private Icon icon_0;

	internal Bitmap bitmap_0;

	internal Enum2 enum2_0;

	private float float_0;

	private float float_1;

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

	void Control.Dispose(bool disposing)
	{
		int num = 6;
		if (Mm0hP1G8Hp7XcVN85IP())
		{
			while (true)
			{
				switch (num)
				{
				default:
					num = 1;
					if (Mm0hP1G8Hp7XcVN85IP())
					{
						continue;
					}
					goto case 1;
				case 6:
					if (disposing)
					{
						goto case 5;
					}
					goto IL_0099;
				case 5:
					if (icon_0 != null)
					{
						goto case 0;
					}
					goto IL_0065;
				case 0:
					icon_0.Dispose();
					goto case 1;
				case 1:
				case 3:
					icon_0 = null;
					goto IL_0065;
				case 2:
				case 4:
					break;
				case 7:
					return;
					IL_0065:
					if (image_0 != null)
					{
						image_0.Dispose();
						image_0 = null;
					}
					if (bitmap_0 != null)
					{
						((Image)bitmap_0).Dispose();
						break;
					}
					goto IL_0099;
				}
				break;
			}
		}
		bitmap_0 = null;
		goto IL_0099;
		IL_0099:
		((Control)this).Dispose(disposing);
	}

	void Control.OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(13f * float_0), Convert.ToInt32(15f * float_1), ((Control)this).get_Width() - Convert.ToInt32(69f * float_0), ((Control)this).get_Height() - Convert.ToInt32(18f * float_1));
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
					if (Mm0hP1G8Hp7XcVN85IP())
					{
						switch (5)
						{
						case 1:
						case 4:
							goto end_IL_0003;
						case 0:
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
		Rectangle rectangle = default(Rectangle);
		while (true)
		{
			((Control)this).OnPaint(e);
			if (!i89ewTGRdc29BgZEME1())
			{
				switch (6)
				{
				case 1:
					break;
				case 6:
					goto IL_003f;
				case 2:
				case 5:
					goto IL_0123;
				default:
					goto IL_015f;
				case 0:
				case 4:
					goto IL_0167;
				case 7:
					return;
				}
				continue;
			}
			goto IL_003f;
			IL_0167:
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(rectangle.Right - Convert.ToInt32(12f * float_0), rectangle.Bottom - Convert.ToInt32(12f * float_1), Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
			break;
			IL_003f:
			e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
			e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
			rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
			if (image_0 != null)
			{
				goto IL_0123;
			}
			if (icon_0 != null)
			{
				e.get_Graphics().DrawIcon(icon_0, rectangle);
				goto IL_015f;
			}
			break;
			IL_0123:
			e.get_Graphics().DrawImage(image_0, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
			break;
			IL_015f:
			if (bitmap_0 == null)
			{
				break;
			}
			goto IL_0167;
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		while (true)
		{
			label_0 = new Label();
			while (true)
			{
				float_0 = 1f;
				float_1 = 1f;
				if (i89ewTGRdc29BgZEME1())
				{
				}
				switch (6)
				{
				case 5:
					continue;
				case 4:
					break;
				case 2:
				case 6:
					((Control)this)._002Ector();
					goto default;
				default:
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
					goto case 1;
				case 1:
					((Control)this).SetStyle((ControlStyles)75794, true);
					icon_0 = Class17.smethod_38();
					((Control)this).OnResize(EventArgs.Empty);
					return;
				case 7:
					return;
				}
				break;
			}
		}
	}

	internal static bool Mm0hP1G8Hp7XcVN85IP()
	{
		return true;
	}

	internal static bool i89ewTGRdc29BgZEME1()
	{
		return false;
	}
}
