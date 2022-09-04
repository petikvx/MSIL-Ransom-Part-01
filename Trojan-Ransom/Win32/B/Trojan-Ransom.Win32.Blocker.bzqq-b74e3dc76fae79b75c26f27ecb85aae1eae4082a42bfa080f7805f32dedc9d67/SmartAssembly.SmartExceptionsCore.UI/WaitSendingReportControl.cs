using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class WaitSendingReportControl : Control
{
	internal int int_0;

	internal Bitmap bitmap_0;

	internal Bitmap bitmap_1;

	internal Timer timer_0;

	internal float float_0;

	internal float float_1;

	protected override void OnVisibleChanged(EventArgs e)
	{
		int num = default(int);
		try
		{
			num = 5;
			((Control)this).OnVisibleChanged(e);
			if (!((Component)this).DesignMode)
			{
				method_0(PoweredByAttribute1.smethod_1((Control)(object)this, 114, 123));
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, this, e);
			throw;
		}
	}

	private void method_0(bool bool_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			num = 4;
			Class33.smethod_2(timer_0, bool_0, 78, 22);
			num2 = 0;
			int_0 = 0;
			num = 0;
			((Control)this).Refresh();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num2, num, this, bool_0);
			throw;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		int num = default(int);
		try
		{
			num = 3;
			((Control)this).set_Size(new Size(SmartAssembly.License.License.smethod_5(250f * float_0, 141, 153), SmartAssembly.License.License.smethod_5(42f * float_1, 618, 638)));
			num = 4;
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
			num = 4;
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
			num = 3;
			if (disposing)
			{
				num = 2;
				if (bitmap_0 != null)
				{
					num = 6;
					FatalExceptionEventArgs.smethod_3((Image)(object)bitmap_0, 403, 464);
				}
				else
				{
					num = 0;
				}
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4((Component)(object)timer_0, 87, 89);
			}
			else
			{
				num = 4;
			}
			((Control)this).Dispose(disposing);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, this, disposing);
			throw;
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		int num = default(int);
		try
		{
			num = 9;
			((Control)this).OnPaint(e);
			if (bitmap_1 != null)
			{
				num = 5;
				StackFrameHelper.smethod_1(FeedbackControl.smethod_1(e, 176, 233), (Image)(object)bitmap_1, new Rectangle(0, 0, SmartAssembly.License.License.smethod_5(250f * float_0, 413, 393), SmartAssembly.License.License.smethod_5(42f * float_1, 986, 974)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2, 816, 882);
			}
			else
			{
				num = 8;
			}
			if (bitmap_0 != null)
			{
				num = 4;
				if (int_0 > 0)
				{
					num = 3;
					HeaderControl.smethod_3(FeedbackControl.smethod_1(e, 441, 480), new Rectangle(SmartAssembly.License.License.smethod_5(46f * float_0, 540, 520), 0, SmartAssembly.License.License.smethod_5(165f * float_0, 202, 222), SmartAssembly.License.License.smethod_5(34f * float_1, 649, 669)), 273, 382);
					num = 0;
					FeedbackControl.smethod_1(e, 603, 514).DrawImage((Image)(object)bitmap_0, new Rectangle(Convert.ToInt32((float)(int_0 - 6) * float_0), Convert.ToInt32(16f * float_1), Convert.ToInt32(40f * float_0), Convert.ToInt32(12f * float_1)), 0, 0, 40, 12, (GraphicsUnit)2);
				}
				else
				{
					num = 7;
				}
			}
			else
			{
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, this, e);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 3;
			num2 = (int_0 += 11);
			num = 0;
			if (int_0 > 198)
			{
				num3 = 0;
				int_0 = 0;
				num = 6;
			}
			FatalExceptionEventArgs.smethod_2((Control)(object)this, 346, 309);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num2, num3, num, this, sender, e);
			throw;
		}
	}

	public WaitSendingReportControl()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		int num = 99;
		int_0 = 99;
		Bitmap o = (bitmap_0 = Class22.smethod_0("data"));
		Bitmap o2 = (bitmap_1 = Class22.smethod_0("network"));
		Timer o3 = (timer_0 = new Timer());
		float num2 = (float_0 = 1f);
		float num3 = (float_1 = 1f);
		((Control)this)._002Ector();
		try
		{
			Class23.smethod_2(timer_0, 85, 66, 32);
			DoNotObfuscateTypeAttribute.smethod_3(timer_0, method_1, 132, 196);
			Class27.smethod_0((Control)(object)this, new Size(250, 42), 3, 52);
			((Control)this).set_TabStop(false);
			((Control)this).SetStyle((ControlStyles)75794, true);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, o, o2, o3, num2, num3, this);
			throw;
		}
	}

	static WaitSendingReportControl()
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

	internal static void smethod_0(Control control_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 123:
					control_0.set_TabIndex(int_1);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static void smethod_1(Control control_0, AnchorStyles anchorStyles_0, int int_1, int int_2)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 27:
					control_0.set_Anchor(anchorStyles_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, anchorStyles_0, int_1, int_2);
			throw;
		}
	}

	internal static AssemblyName smethod_2(Assembly assembly_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 37:
					return assembly_0.GetName();
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_1, int_2);
			throw;
		}
	}

	internal static Delegate smethod_3(Delegate delegate_0, Delegate delegate_1, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 0:
					return Delegate.Combine(delegate_0, delegate_1);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, delegate_0, delegate_1, int_1, int_2);
			throw;
		}
	}

	internal static Type smethod_4(Exception exception_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 106:
					return exception_0.GetType();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, exception_0, int_1, int_2);
			throw;
		}
	}

	internal static void smethod_5(Form form_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 53:
					form_0.Close();
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, form_0, int_1, int_2);
			throw;
		}
	}

	internal static Version smethod_6(OperatingSystem operatingSystem_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 6:
					return operatingSystem_0.Version;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, operatingSystem_0, int_1, int_2);
			throw;
		}
	}

	internal static void smethod_7(Stream stream_0, byte[] byte_0, int int_1, int int_2, int int_3, int int_4)
	{
		try
		{
			while (true)
			{
				switch (int_4 ^ int_3)
				{
				case 80:
					stream_0.Write(byte_0, int_1, int_2);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, stream_0, byte_0, int_1, int_2, int_3, int_4);
			throw;
		}
	}
}
