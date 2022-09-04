using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control1 : Control
{
	private Label label_0 = new Label();

	private Image image_0;

	private Icon icon_0;

	private Bitmap bitmap_0;

	private Enum1 enum1_0;

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
		icon_0 = Class34.smethod_5();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public Control1(string CO_)
		: this()
	{
		((Control)label_0).set_Text(CO_);
	}

	[SpecialName]
	public void method_0(Enum1 CO_)
	{
		do
		{
			if (enum1_0 == CO_)
			{
				continue;
			}
			enum1_0 = CO_;
			if (-1 == 0)
			{
				goto IL_0064;
			}
			switch (enum1_0)
			{
			case Enum1.const_1:
				break;
			case Enum1.const_2:
				goto IL_004a;
			default:
				goto IL_0064;
			}
			bitmap_0 = Class28.smethod_0(Class5.smethod_0(81896));
			goto IL_006e;
			IL_0064:
			if (0 == 0)
			{
				bitmap_0 = null;
			}
			goto IL_006e;
			IL_004a:
			if (false)
			{
				goto IL_0064;
			}
			bitmap_0 = Class28.smethod_0(Class5.smethod_0(81909));
			goto IL_006e;
			IL_006e:
			((Control)this).Refresh();
		}
		while (false);
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
		if (4 == 0)
		{
			return;
		}
		float_0 = x;
		if (6 == 0)
		{
			return;
		}
		float_1 = y;
		do
		{
			if (0 == 0)
			{
				((Control)this).ScaleCore(x, y);
			}
		}
		while (false);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Rectangle rectangle;
		if (6u != 0)
		{
			if (7u != 0)
			{
				((Control)this).OnPaint(e);
			}
			e.get_Graphics().DrawLine(SystemPens.get_ControlDark(), 0, ((Control)this).get_ClientSize().Height - 2, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 2);
			e.get_Graphics().DrawLine(SystemPens.get_ControlLightLight(), 0, ((Control)this).get_ClientSize().Height - 1, ((Control)this).get_ClientSize().Width, ((Control)this).get_ClientSize().Height - 1);
			rectangle = new Rectangle(((Control)this).get_ClientSize().Width - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
			if (image_0 != null)
			{
				e.get_Graphics().DrawImage(image_0, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
				return;
			}
			if (icon_0 == null)
			{
				return;
			}
		}
		e.get_Graphics().DrawIcon(icon_0, rectangle);
		if (bitmap_0 != null)
		{
			e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(rectangle.Right - Convert.ToInt32(12f * float_0), rectangle.Bottom - Convert.ToInt32(12f * float_1), Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		try
		{
			if (4u != 0)
			{
				((Control)label_0).set_Font(new Font(((Control)this).get_Font(), (FontStyle)1));
				if (0 == 0)
				{
					((Control)this).OnFontChanged(e);
				}
			}
		}
		catch
		{
		}
	}
}
