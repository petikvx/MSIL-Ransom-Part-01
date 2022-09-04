using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml;
using SmartAssembly.Shared;
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
					Bitmap val2 = (bitmap_0 = Class21.smethod_0("error16"));
					break;
				}
				case IconState.Warning:
				{
					Bitmap val = (bitmap_0 = Class21.smethod_0("warning16"));
					break;
				}
				}
				SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2((Control)(object)this, 803, 874);
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
	{
		get
		{
			return ((Control)label_0).get_Text();
		}
		set
		{
			AppNameFinder.smethod_3((Control)(object)label_0, value, 127, 6);
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
			SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_2((Control)(object)this, 644, 717);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (icon_0 != null)
			{
				icon_0.Dispose();
				Icon val = (icon_0 = null);
			}
			if (image_0 != null)
			{
				image_0.Dispose();
				Image val2 = (image_0 = null);
			}
			if (bitmap_0 != null)
			{
				((Image)bitmap_0).Dispose();
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
		Graphics obj = Class34.smethod_2(e, 344, 360);
		Pen controlDark = SystemPens.get_ControlDark();
		Size size_ = Class31.smethod_1((Control)(object)this, 869, 887);
		int num = UsageCounts.smethod_2(ref size_, 422, 422) - 2;
		int width = Class31.smethod_1((Control)(object)this, 316, 302).Width;
		Size size_2 = Class31.smethod_1((Control)(object)this, 370, 352);
		obj.DrawLine(controlDark, 0, num, width, UsageCounts.smethod_2(ref size_2, 625, 625) - 2);
		Graphics obj2 = Class34.smethod_2(e, 43, 27);
		Pen controlLightLight = SystemPens.get_ControlLightLight();
		Size size_3 = Class31.smethod_1((Control)(object)this, 464, 450);
		int num2 = UsageCounts.smethod_2(ref size_3, 654, 654) - 1;
		int width2 = Class31.smethod_1((Control)(object)this, 1015, 997).Width;
		Size size_4 = Class31.smethod_1((Control)(object)this, 1015, 997);
		obj2.DrawLine(controlLightLight, 0, num2, width2, UsageCounts.smethod_2(ref size_4, 458, 458) - 1);
		Rectangle rectangle = new Rectangle(Class31.smethod_1((Control)(object)this, 625, 611).Width - Convert.ToInt32(48f * float_0), Convert.ToInt32(11f * float_1), Convert.ToInt32(32f * float_0), Convert.ToInt32(32f * float_1));
		if (image_0 != null)
		{
			Class34.smethod_2(e, 866, 850).DrawImage(image_0, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
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
			((Control)label_0).set_Font(new Font(PoweredBy.smethod_3((Control)(object)this, 308, 293), (FontStyle)1));
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
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		Label val = (label_0 = new Label());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		try
		{
			Class23.smethod_4(label_0, (FlatStyle)3, 179, 209);
			((Control)label_0).set_Font(new Font(PoweredBy.smethod_3((Control)(object)this, 935, 950), (FontStyle)1));
		}
		catch
		{
		}
		SimpleZip.Class9.smethod_0((Control)(object)this, 361, 318).Add((Control)(object)label_0);
		((Control)this).set_BackColor(SystemColors.Window);
		((Control)this).set_TabStop(false);
		((Control)this).set_Dock((DockStyle)1);
		((Control)this).set_Height(58);
		((Control)this).SetStyle((ControlStyles)75794, true);
		Icon val2 = (icon_0 = Win32.GetApplicationIcon());
		((Control)this).OnResize(EventArgs.Empty);
	}

	public HeaderControl(string text)
		: this()
	{
		AppNameFinder.smethod_3((Control)(object)label_0, text, 653, 756);
	}

	[SecuritySafeCritical]
	static HeaderControl()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				symmetricAlgorithm_0.GenerateKey();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(PictureBox pictureBox_0, Image image_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 122:
				pictureBox_0.set_Image(image_1);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static MethodInfo smethod_2(Type type_0, string string_0, Type[] type_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 33:
				return type_0.GetMethod(string_0, type_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_3(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				return string_0.LastIndexOf(string_1);
			case 47:
				return string_0.IndexOf(string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(XmlWriter xmlWriter_0, string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				xmlWriter_0.WriteElementString(string_0, string_1);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_5(Type type_0, object object_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 100:
				return Enum.Format(type_0, object_0, string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_6(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return Assembly.Load(byte_0, byte_1, evidence_0);
			}
		}
	}
}
