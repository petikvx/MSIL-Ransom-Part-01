using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Control1 : Control
{
	private Label label_0;

	private Image image_0;

	private Icon icon_0;

	private object object_0;

	private Enum1 enum1_0;

	private float float_0;

	private float float_1;

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

	[SpecialName]
	public void method_0(Enum1 enum1_1)
	{
		if (enum1_0 != enum1_1)
		{
			enum1_0 = enum1_1;
			switch (enum1_0)
			{
			default:
				object_0 = null;
				break;
			case (Enum1)1:
				object_0 = Class24.smethod_0("error16");
				break;
			case (Enum1)2:
				object_0 = Class24.smethod_0("warning16");
				break;
			}
			((Control)this).Refresh();
		}
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
			if (object_0 != null)
			{
				((Image)object_0).Dispose();
				object_0 = null;
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
			if (object_0 != null)
			{
				e.get_Graphics().DrawImage((Image)object_0, new Rectangle(rectangle.Right - Convert.ToInt32(12f * float_0), rectangle.Bottom - Convert.ToInt32(12f * float_1), Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
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

	public Control1()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Class52.KPUgGmhz2nAeI();
		label_0 = new Label();
		float_0 = 1f;
		float_1 = 1f;
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
		((Control)this).set_BackColor(SystemColors.Window);
		((Control)this).set_TabStop(false);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		icon_0 = Class32.smethod_5();
		((Control)this).OnResize(EventArgs.Empty);
	}

	public Control1(string string_0)
	{
		Class52.KPUgGmhz2nAeI();
		this._002Ector();
		((Control)label_0).set_Text(string_0);
	}
}
