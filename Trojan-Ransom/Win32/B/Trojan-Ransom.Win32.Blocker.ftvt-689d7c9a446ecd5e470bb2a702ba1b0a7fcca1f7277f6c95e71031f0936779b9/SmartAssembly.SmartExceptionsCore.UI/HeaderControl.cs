using System;
using System.Drawing;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace SmartAssembly.SmartExceptionsCore.UI;

public sealed class HeaderControl : Control
{
	[NonSerialized]
	internal static GetString getString_0;

	private Label label_0 = new Label();

	private Image image_0;

	private Icon icon_0;

	private Bitmap bitmap_0;

	private IconState iconState_0;

	private float float_0 = 1f;

	private float float_1 = 1f;

	public override string Text
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

	public IconState IconState
	{
		set
		{
			if (iconState_0 != value)
			{
				iconState_0 = value;
				switch (iconState_0)
				{
				default:
					bitmap_0 = null;
					break;
				case IconState.Error:
					bitmap_0 = Class12.smethod_0(getString_0(3229));
					break;
				case IconState.Warning:
					bitmap_0 = Class12.smethod_0(getString_0(3242));
					break;
				}
				((Control)this).Refresh();
			}
		}
	}

	static HeaderControl()
	{
		Strings.CreateGetStringDelegate(typeof(HeaderControl));
	}

	protected override void Dispose(bool disposing)
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

	protected override void OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(13f * float_0), Convert.ToInt32(15f * float_1), ((Control)this).get_Width() - Convert.ToInt32(69f * float_0), ((Control)this).get_Height() - Convert.ToInt32(18f * float_1));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float x, float y)
	{
		float_0 = x;
		float_1 = y;
		((Control)this).ScaleCore(x, y);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
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

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		try
		{
			((Control)label_0).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
			((Control)this).OnFontChanged(e);
		}
		catch
		{
		}
	}

	public HeaderControl()
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
		icon_0 = Win32.GetApplicationIcon();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public HeaderControl(string string_0)
		: this()
	{
		((Control)label_0).set_Text(string_0);
	}
}
