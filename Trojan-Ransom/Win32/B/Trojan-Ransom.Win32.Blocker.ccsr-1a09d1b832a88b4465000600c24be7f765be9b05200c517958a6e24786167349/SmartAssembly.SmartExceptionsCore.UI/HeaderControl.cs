using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class HeaderControl : Control
{
	internal Label label_0;

	internal Image image_0;

	internal Icon icon_0;

	internal Bitmap bitmap_0;

	internal IconState iconState_0;

	internal float float_0;

	internal float float_1;

	public IconState IconState
	{
		get
		{
			return iconState_0;
		}
		set
		{
			if (iconState_0 != value)
			{
				IconState iconState = (iconState_0 = value);
				switch (iconState_0)
				{
				default:
				{
					Bitmap val3 = (bitmap_0 = null);
					break;
				}
				case IconState.Error:
				{
					Bitmap val2 = (bitmap_0 = Class19.smethod_0("error16"));
					break;
				}
				case IconState.Warning:
				{
					Bitmap val = (bitmap_0 = Class19.smethod_0("warning16"));
					break;
				}
				}
				((Control)this).Refresh();
			}
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	public override string Text
	{
		get
		{
			return SendingReportFeedbackEventArgs1.smethod_0((Control)(object)label_0, 507, 484);
		}
		set
		{
			Class24.smethod_0((Control)(object)label_0, value, 129, 140);
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
			Image val = (image_0 = value);
			((Control)this).Refresh();
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (icon_0 != null)
			{
				Attribute0.smethod_0(icon_0, 654, 761);
				Icon val = (icon_0 = null);
			}
			if (image_0 != null)
			{
				UnhandledExceptionHandlerWithUI.smethod_1(image_0, 183, 167);
				Image val2 = (image_0 = null);
			}
			if (bitmap_0 != null)
			{
				UnhandledExceptionHandlerWithUI.smethod_1((Image)(object)bitmap_0, 624, 608);
				Bitmap val3 = (bitmap_0 = null);
			}
		}
		((Control)this).Dispose(disposing);
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)label_0).SetBounds(Convert.ToInt32(13f * float_0), Convert.ToInt32(15f * float_1), ((Control)this).get_Width() - Convert.ToInt32(69f * float_0), ((Control)this).get_Height() - Convert.ToInt32(18f * float_1));
		((Control)this).OnResize(e);
	}

	protected override void ScaleCore(float dx, float dy)
	{
		float num = (float_0 = dx);
		float num2 = (float_1 = dy);
		((Control)this).ScaleCore(dx, dy);
		((Control)this).OnResize(EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		Pen pen_ = Form1.smethod_1(227, 230);
		Size size_ = Attribute0.smethod_1((Control)(object)this, 83, 73);
		int int_ = smethod_1(ref size_, 396, 400) - 2;
		Size size_2 = Attribute0.smethod_1((Control)(object)this, 626, 616);
		int int_2 = smethod_3(ref size_2, 471, 395);
		Size size_3 = Attribute0.smethod_1((Control)(object)this, 956, 934);
		PoweredBy.smethod_3(graphics, pen_, 0, int_, int_2, smethod_1(ref size_3, 215, 203) - 2, 896, 1023);
		Graphics graphics2 = e.get_Graphics();
		Pen controlLightLight = SystemPens.get_ControlLightLight();
		Size size_4 = Attribute0.smethod_1((Control)(object)this, 342, 332);
		int int_3 = smethod_1(ref size_4, 548, 568) - 1;
		Size size_5 = Attribute0.smethod_1((Control)(object)this, 265, 275);
		int int_4 = smethod_3(ref size_5, 405, 457);
		Size size_6 = Attribute0.smethod_1((Control)(object)this, 681, 691);
		PoweredBy.smethod_3(graphics2, controlLightLight, 0, int_3, int_4, smethod_1(ref size_6, 786, 782) - 1, 448, 447);
		Size size_7 = Attribute0.smethod_1((Control)(object)this, 992, 1018);
		Rectangle rectangle = new Rectangle(smethod_3(ref size_7, 60, 96) - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		try
		{
			((Control)label_0).set_Font(new Font(Class25.smethod_1((Control)(object)this, 969, 906), (FontStyle)1));
			((Control)this).OnFontChanged(e);
		}
		catch
		{
		}
	}

	public HeaderControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		Label val = (label_0 = new Label());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		try
		{
			label_0.set_FlatStyle((FlatStyle)3);
			((Control)label_0).set_Font(new Font(Class25.smethod_1((Control)(object)this, 759, 692), (FontStyle)1));
		}
		catch
		{
		}
		PoweredBy.smethod_2((Control)(object)this, 993, 926).Add((Control)(object)label_0);
		Class21.smethod_3((Control)(object)this, UsageReportSender.smethod_4(655, 738), 216, 201);
		ConfirmFeatureUsageReportingForm.smethod_0((Control)(object)this, bool_0: false, 863, 811);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		Icon val2 = (icon_0 = Win32.GetApplicationIcon());
		((Control)this).OnResize(EventArgs.Empty);
	}

	public HeaderControl(string text)
		: this()
	{
		Class24.smethod_0((Control)(object)label_0, text, 678, 683);
	}

	static HeaderControl()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static object smethod_0(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				return RuntimeHelpers.GetObjectValue(object_0);
			}
		}
	}

	internal static int smethod_1(ref Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				return size_0.Height;
			}
		}
	}

	internal static DateTime smethod_2(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				return DateTime.Now;
			}
		}
	}

	internal static int smethod_3(ref Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 92:
				return size_0.Width;
			}
		}
	}
}
