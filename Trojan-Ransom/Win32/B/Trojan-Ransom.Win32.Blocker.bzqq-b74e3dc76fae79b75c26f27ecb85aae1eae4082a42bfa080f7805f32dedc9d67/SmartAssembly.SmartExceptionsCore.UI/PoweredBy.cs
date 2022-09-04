using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class PoweredBy : Control
{
	internal Label label_0;

	internal PictureBox pictureBox_0;

	internal ToolTip toolTip_0;

	internal float float_0;

	internal float float_1;

	protected override void OnResize(EventArgs e)
	{
		int num = default(int);
		try
		{
			num = 2;
			((Control)this).set_Size(new Size(SmartAssembly.License.License.smethod_5(112f * float_0, 887, 867), SmartAssembly.License.License.smethod_5(32f * float_1, 448, 468)));
			num = 1;
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
			num = 2;
			num2 = (float_0 = dx);
			num3 = (float_1 = dy);
			num = 1;
			((Control)this).ScaleCore(dx, dy);
			((Control)this).OnResize(EventArgs.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num2, num3, num, this, dx, dy);
			throw;
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = default(int);
		try
		{
			num = 7;
			if (disposing)
			{
				num = 6;
				if (toolTip_0 != null)
				{
					num = 0;
					SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4((Component)(object)toolTip_0, 715, 709);
				}
				else
				{
					num = 1;
				}
				if (pictureBox_0 != null)
				{
					num = 2;
					SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4((Component)(object)pictureBox_0, 792, 790);
				}
				else
				{
					num = 8;
				}
			}
			else
			{
				num = 8;
			}
			((Control)this).Dispose(disposing);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, this, disposing);
			throw;
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		try
		{
			try
			{
				DoNotObfuscateTypeAttribute.smethod_2("http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly", 377, 330);
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, sender, e);
			throw;
		}
	}

	public PoweredBy()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Label o = (label_0 = new Label());
		PictureBox o2 = (pictureBox_0 = new PictureBox());
		ToolTip o3 = (toolTip_0 = new ToolTip());
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		Control[] array = default(Control[]);
		try
		{
			UnhandledExceptionHandlerWithUI.smethod_2((Control)(object)this, 92, 79);
			FeedbackControl.smethod_2(label_0, (FlatStyle)3, 901, 957);
			Class21.smethod_1((Control)(object)label_0, new Point(0, 10), 644, 687);
			Class27.smethod_0((Control)(object)label_0, new Size(62, 24), 936, 926);
			SmartAssembly.License.License.smethod_4((Control)(object)label_0, "Powered by", 496, 423);
			PoweredByAttribute.smethod_2(pictureBox_0, (Image)(object)Class22.smethod_0("{logo}"), 111, 9);
			Class21.smethod_1((Control)(object)pictureBox_0, new Point(72, 0), 617, 578);
			Class27.smethod_0((Control)(object)pictureBox_0, new Size(32, 32), 911, 953);
			SendingReportFeedbackEventArgs1.smethod_6(pictureBox_0, (PictureBoxSizeMode)1, 310, 359);
			DESCryptoIndirector.smethod_2((Control)(object)label_0, method_0, 43, 69);
			DESCryptoIndirector.smethod_2((Control)(object)pictureBox_0, method_0, 223, 177);
			UsageReportSender.smethod_16((Control)(object)this, method_0, 752, 685);
			DoNotDistributeAttribute.smethod_4((Control)(object)this, SendingReportFeedbackEventArgs1.smethod_7(611, 520), 174, 253);
			Class2.smethod_11((Control)(object)this, bool_0: false, 738, 735);
			Class27.smethod_0((Control)(object)this, new Size(112, 32), 646, 689);
			ControlCollection obj = PoweredByAttribute1.smethod_3((Control)(object)this, 52, 14);
			array = (Control[])(object)new Control[2]
			{
				(Control)pictureBox_0,
				(Control)label_0
			};
			obj.AddRange(array);
			toolTip_0.SetToolTip((Control)(object)this, "Powered by SmartAssembly");
			toolTip_0.SetToolTip((Control)(object)label_0, "Powered by SmartAssembly");
			toolTip_0.SetToolTip((Control)(object)pictureBox_0, "Powered by SmartAssembly");
			((Control)this).ResumeLayout(true);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, array, o, o2, o3, num, num2, this);
			throw;
		}
	}

	static PoweredBy()
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

	internal static void smethod_0(Process process_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 97:
					process_0.Kill();
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, process_0, int_0, int_1);
			throw;
		}
	}

	internal static CultureInfo smethod_1(Thread thread_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					return thread_0.CurrentUICulture;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, thread_0, int_0, int_1);
			throw;
		}
	}

	internal static FieldInfo smethod_2(Type type_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 48:
					return type_0.GetField(string_0);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, type_0, string_0, int_0, int_1);
			throw;
		}
	}
}
