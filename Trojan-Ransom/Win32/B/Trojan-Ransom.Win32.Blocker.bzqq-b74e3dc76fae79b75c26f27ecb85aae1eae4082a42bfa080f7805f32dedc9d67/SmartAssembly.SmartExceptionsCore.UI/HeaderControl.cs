using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Attributes;
using SmartAssembly.License;
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
			try
			{
				return iconState_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
		set
		{
			int num = default(int);
			IconState iconState = default(IconState);
			IconState iconState2 = default(IconState);
			Bitmap o3 = default(Bitmap);
			Bitmap o2 = default(Bitmap);
			Bitmap o = default(Bitmap);
			try
			{
				num = 9;
				if (iconState_0 != value)
				{
					num = 0;
					iconState = (iconState_0 = value);
					iconState2 = iconState_0;
					num = 4;
					switch (iconState2)
					{
					default:
						num = 11;
						num = 7;
						o3 = (bitmap_0 = null);
						num = 5;
						break;
					case IconState.Error:
						num = 3;
						o2 = (bitmap_0 = Class22.smethod_0("error16"));
						num = 5;
						break;
					case IconState.Warning:
						num = 10;
						o = (bitmap_0 = Class22.smethod_0("warning16"));
						num = 5;
						break;
					}
					FatalExceptionEventArgs.smethod_2((Control)(object)this, 450, 429);
				}
				else
				{
					num = 8;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException8(exception, iconState2, iconState, o2, o, o3, num, this, value);
				throw;
			}
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override string Text
	{
		get
		{
			try
			{
				return Class35.smethod_2((Control)(object)label_0, 802, 829);
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
		set
		{
			try
			{
				SmartAssembly.License.License.smethod_4((Control)(object)label_0, value, 692, 739);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, value);
				throw;
			}
		}
	}

	public Image Image
	{
		get
		{
			try
			{
				return image_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
		set
		{
			Image o = default(Image);
			try
			{
				o = (image_0 = value);
				FatalExceptionEventArgs.smethod_2((Control)(object)this, 19, 124);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, o, this, value);
				throw;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = default(int);
		Icon o = default(Icon);
		Image o2 = default(Image);
		Bitmap o3 = default(Bitmap);
		try
		{
			num = 1;
			if (disposing)
			{
				num = 4;
				if (icon_0 != null)
				{
					num = 9;
					AESCryptoIndirector.smethod_0(icon_0, 879, 887);
					o = (icon_0 = null);
					num = 7;
				}
				else
				{
					num = 7;
				}
				if (image_0 != null)
				{
					num = 8;
					FatalExceptionEventArgs.smethod_3(image_0, 267, 328);
					o2 = (image_0 = null);
					num = 6;
				}
				else
				{
					num = 6;
				}
				if (bitmap_0 != null)
				{
					num = 10;
					FatalExceptionEventArgs.smethod_3((Image)(object)bitmap_0, 48, 115);
					o3 = (bitmap_0 = null);
					num = 0;
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 0;
			}
			((Control)this).Dispose(disposing);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, o, o2, o3, num, this, disposing);
			throw;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		int num = default(int);
		try
		{
			num = 1;
			((Control)label_0).SetBounds(SmartAssembly.License.License.smethod_5(13f * float_0, 1004, 1016), SmartAssembly.License.License.smethod_5(15f * float_1, 831, 811), Class33.smethod_3((Control)(object)this, 324, 286) - SmartAssembly.License.License.smethod_5(69f * float_0, 829, 809), Class33.smethod_3((Control)(object)this, 309, 366) - Convert.ToInt32(18f * float_1));
			num = 3;
			((Control)this).OnResize(e);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, this, e);
			throw;
		}
	}

	protected override void ScaleCore(float dx, float dy)
	{
		int num = default(int);
		float num2 = default(float);
		float num3 = default(float);
		try
		{
			num = 1;
			num2 = (float_0 = dx);
			num3 = (float_1 = dy);
			num = 4;
			((Control)this).ScaleCore(dx, dy);
			((Control)this).OnResize(EventArgs.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num2, num3, num, this, dx, dy);
			throw;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		int num = default(int);
		Size size_ = default(Size);
		Size size_2 = default(Size);
		Size size_3 = default(Size);
		Size size_4 = default(Size);
		Size size_5 = default(Size);
		Size size_6 = default(Size);
		Size size_7 = default(Size);
		Rectangle rectangle = default(Rectangle);
		int num2 = default(int);
		try
		{
			num = 2;
			((Control)this).OnPaint(e);
			Graphics graphics_ = FeedbackControl.smethod_1(e, 867, 826);
			Pen pen_ = UsageCounts.smethod_4(377, 340);
			size_ = SimpleZip.Stream0.smethod_2((Control)(object)this, 786, 889);
			int int_ = ReportSender.smethod_1(ref size_, 174, 196) - 2;
			size_2 = SimpleZip.Stream0.smethod_2((Control)(object)this, 385, 490);
			int int_2 = SimpleZip.Class7.smethod_3(ref size_2, 28, 26);
			size_3 = SimpleZip.Stream0.smethod_2((Control)(object)this, 39, 76);
			UsageCounts.smethod_6(graphics_, pen_, 0, int_, int_2, ReportSender.smethod_1(ref size_3, 944, 986) - 2, 341, 320);
			num = 6;
			Graphics graphics_2 = FeedbackControl.smethod_1(e, 233, 176);
			Pen pen_2 = Class27.smethod_4(31, 38);
			size_4 = SimpleZip.Stream0.smethod_2((Control)(object)this, 483, 392);
			int int_3 = ReportSender.smethod_1(ref size_4, 610, 520) - 1;
			size_5 = SimpleZip.Stream0.smethod_2((Control)(object)this, 53, 94);
			int int_4 = SimpleZip.Class7.smethod_3(ref size_5, 711, 705);
			size_6 = SimpleZip.Stream0.smethod_2((Control)(object)this, 308, 351);
			UsageCounts.smethod_6(graphics_2, pen_2, 0, int_3, int_4, ReportSender.smethod_1(ref size_6, 921, 1011) - 1, 283, 270);
			num = 4;
			size_7 = SimpleZip.Stream0.smethod_2((Control)(object)this, 760, 659);
			rectangle = new Rectangle(SimpleZip.Class7.smethod_3(ref size_7, 959, 953) - SmartAssembly.License.License.smethod_5(48f * float_0, 783, 795), SmartAssembly.License.License.smethod_5(11f * float_1, 71, 83), SmartAssembly.License.License.smethod_5(32f * float_0, 260, 272), SmartAssembly.License.License.smethod_5(32f * float_1, 858, 846));
			num = 3;
			if (image_0 != null)
			{
				num = 0;
				FeedbackControl.smethod_1(e, 640, 729).DrawImage(image_0, rectangle, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
			}
			else if (icon_0 != null)
			{
				num2 = 1;
				e.get_Graphics().DrawIcon(icon_0, rectangle);
				if (bitmap_0 != null)
				{
					num2 = 6;
					e.get_Graphics().DrawImage((Image)(object)bitmap_0, new Rectangle(rectangle.Right - Convert.ToInt32(12f * float_0), rectangle.Bottom - Convert.ToInt32(12f * float_1), Convert.ToInt32(16f * float_0), Convert.ToInt32(16f * float_1)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
				}
				else
				{
					num2 = 5;
				}
			}
			else
			{
				num2 = 5;
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[12]
			{
				rectangle, size_, size_2, size_3, size_4, size_5, size_6, size_7, num, num2,
				this, e
			});
			throw;
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		int num = default(int);
		int num2 = default(int);
		try
		{
			try
			{
				num = 4;
				Class16.smethod_1((Control)(object)label_0, new Font(UnhandledExceptionHandlerWithUI.smethod_5((Control)(object)this, 539, 629), (FontStyle)1), 963, 1004);
				num = 0;
				((Control)this).OnFontChanged(e);
			}
			catch
			{
			}
			num2 = 1;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, num2, this, e);
			throw;
		}
	}

	public HeaderControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		Label o = (label_0 = new Label());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		Icon o2 = default(Icon);
		try
		{
			try
			{
				FeedbackControl.smethod_2(label_0, (FlatStyle)3, 739, 731);
				Class16.smethod_1((Control)(object)label_0, new Font(UnhandledExceptionHandlerWithUI.smethod_5((Control)(object)this, 367, 257), (FontStyle)1), 905, 934);
			}
			catch
			{
			}
			PoweredByAttribute1.smethod_3((Control)(object)this, 206, 244).Add((Control)(object)label_0);
			Win32.smethod_15((Control)(object)this, Form1.smethod_3(790, 818), 441, 491);
			Class2.smethod_11((Control)(object)this, bool_0: false, 372, 329);
			((Control)this).set_Dock((DockStyle)1);
			((Control)this).set_Height(58);
			((Control)this).SetStyle((ControlStyles)75794, true);
			o2 = (icon_0 = Win32.GetApplicationIcon());
			((Control)this).OnResize(EventArgs.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, o, num, num2, o2, this);
			throw;
		}
	}

	public HeaderControl(string text)
		: this()
	{
		try
		{
			SmartAssembly.License.License.smethod_4((Control)(object)label_0, text, 633, 558);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, text);
			throw;
		}
	}

	static HeaderControl()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static string smethod_0(object object_0, object object_1, object object_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					return string.Concat(object_0, object_1, object_2);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, object_0, object_1, object_2, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_1(char char_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 70:
					return Conversions.ToString(char_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, char_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(ServicePoint servicePoint_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 7:
					servicePoint_0.Expect100Continue = bool_0;
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, servicePoint_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(Graphics graphics_0, Rectangle rectangle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 111:
					graphics_0.SetClip(rectangle_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, graphics_0, rectangle_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_4(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return type_0.GetArrayRank();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}
}
