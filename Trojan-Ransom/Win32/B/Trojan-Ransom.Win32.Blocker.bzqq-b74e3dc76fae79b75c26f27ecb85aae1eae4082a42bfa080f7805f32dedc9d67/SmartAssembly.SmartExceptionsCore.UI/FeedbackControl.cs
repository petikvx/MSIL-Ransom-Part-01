using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class FeedbackControl : Control
{
	internal Label label_0;

	internal Image image_0;

	internal bool bool_0;

	internal Timer timer_0;

	internal bool bool_1;

	internal string string_0;

	internal float float_0;

	internal float float_1;

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[Browsable(true)]
	public override string Text
	{
		get
		{
			try
			{
				return ((Control)this).get_Text();
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
				((Control)this).set_Text(value);
				FatalExceptionEventArgs.smethod_2((Control)(object)this, 295, 328);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, value);
				throw;
			}
		}
	}

	public void Init()
	{
		int num = default(int);
		Image o = default(Image);
		bool flag = default(bool);
		string o2 = default(string);
		try
		{
			num = 3;
			Class33.smethod_2(timer_0, bool_0: false, 661, 717);
			o = (image_0 = null);
			num = 5;
			flag = false;
			bool_0 = false;
			o2 = (string_0 = string.Empty);
			num = 1;
			FatalExceptionEventArgs.smethod_2((Control)(object)this, 441, 470);
			((Control)this).set_Height(16);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, o, flag, o2, num, this);
			throw;
		}
	}

	public void Start()
	{
		int num = default(int);
		Image o = default(Image);
		bool flag = default(bool);
		try
		{
			num = 4;
			Class33.smethod_2(timer_0, bool_0: true, 372, 300);
			o = (image_0 = (Image)(object)Class22.smethod_0("current"));
			num = 0;
			flag = true;
			bool_0 = true;
			((Control)this).Refresh();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, o, flag, num, this);
			throw;
		}
	}

	public void Stop()
	{
		try
		{
			Stop(string.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	public void Stop(string errorMessage)
	{
		int num = default(int);
		string o = default(string);
		Image o2 = default(Image);
		bool flag = default(bool);
		bool flag2 = default(bool);
		try
		{
			num = 3;
			o = (string_0 = errorMessage);
			Class33.smethod_2(timer_0, bool_0: false, 633, 545);
			num = 7;
			o2 = (image_0 = (Image)(object)Class22.smethod_0((AppPathFinder.smethod_1(errorMessage, 419, 404) > 0) ? "error" : "ok"));
			flag = true;
			bool_1 = true;
			num = 0;
			flag2 = true;
			bool_0 = true;
			if (AppPathFinder.smethod_1(errorMessage, 236, 219) > 0)
			{
				((Control)this).set_Height(100);
			}
			((Control)this).Refresh();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, o, o2, flag, flag2, num, this, errorMessage);
			throw;
		}
	}

	protected override void OnResize(EventArgs e)
	{
		int num = default(int);
		try
		{
			num = 1;
			((Control)label_0).SetBounds(SmartAssembly.License.License.smethod_5(22f * float_0, 924, 904), SmartAssembly.License.License.smethod_5(float_1, 345, 333), Class33.smethod_3((Control)(object)this, 100, 62) - SmartAssembly.License.License.smethod_5(22f * float_0, 753, 741), ((Control)this).get_Height() - Convert.ToInt32(float_1));
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
		Image o = default(Image);
		bool flag = default(bool);
		try
		{
			num = 6;
			((Control)this).OnPaint(e);
			if (((Component)this).DesignMode)
			{
				num = 10;
				o = (image_0 = (Image)(object)Class22.smethod_0("current"));
				num = 9;
				flag = true;
				bool_0 = true;
				num = 4;
			}
			else
			{
				num = 4;
			}
			if (image_0 != null)
			{
				num = 3;
				if (bool_1)
				{
					num = 7;
					StackFrameHelper.smethod_1(smethod_1(e, 806, 895), image_0, new Rectangle(0, 0, SmartAssembly.License.License.smethod_5(16f * float_0, 74, 94), SmartAssembly.License.License.smethod_5(16f * float_1, 889, 877)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2, 118, 52);
				}
				else
				{
					num = 5;
				}
			}
			else
			{
				num = 5;
			}
			if (bool_0)
			{
				num = 0;
				((Control)label_0).set_Text((AppPathFinder.smethod_1(string_0, 268, 315) > 0) ? (((Control)this).get_Text() + " (" + string_0 + ")") : ((Control)this).get_Text());
			}
			else
			{
				((Control)label_0).set_Text(string.Empty);
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, o, flag, num, num2, this, e);
			throw;
		}
	}

	public FeedbackControl()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		Label o = (label_0 = new Label());
		Timer o2 = (timer_0 = new Timer());
		bool flag = true;
		bool_1 = true;
		string o3 = (string_0 = string.Empty);
		float num = (float_0 = 1f);
		float num2 = (float_1 = 1f);
		((Control)this)._002Ector();
		try
		{
			Class23.smethod_2(timer_0, 250, 326, 292);
			DoNotObfuscateTypeAttribute.smethod_3(timer_0, method_0, 145, 209);
			smethod_2(label_0, (FlatStyle)3, 852, 876);
			PoweredByAttribute1.smethod_3((Control)(object)this, 253, 199).Add((Control)(object)label_0);
			((Control)this).SetStyle((ControlStyles)75794, true);
			((Control)this).set_TabStop(false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, o, o2, flag, o3, num, num2, this);
			throw;
		}
	}

	public FeedbackControl(string text)
		: this()
	{
		try
		{
			((Control)this).set_Text(Form0.smethod_1(" ", text, 318, 268));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, text);
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
				if (image_0 != null)
				{
					num = 0;
					FatalExceptionEventArgs.smethod_3(image_0, 729, 666);
				}
				else
				{
					num = 5;
				}
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_4((Component)(object)timer_0, 315, 309);
			}
			else
			{
				num = 1;
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
		int num = default(int);
		bool flag = default(bool);
		try
		{
			num = 0;
			flag = (bool_1 = !bool_1);
			num = 3;
			FatalExceptionEventArgs.smethod_2((Control)(object)this, 287, 368);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, flag, num, this, sender, e);
			throw;
		}
	}

	static FeedbackControl()
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

	internal static void smethod_0(SerializationInfo serializationInfo_0, string string_1, object object_0, Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 77:
					serializationInfo_0.AddValue(string_1, object_0, type_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException8(exception, num, num2, serializationInfo_0, string_1, object_0, type_0, int_0, int_1);
			throw;
		}
	}

	internal static Graphics smethod_1(PaintEventArgs paintEventArgs_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 89:
					return paintEventArgs_0.get_Graphics();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, paintEventArgs_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Label label_1, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 56:
					label_1.set_FlatStyle(flatStyle_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, label_1, flatStyle_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(FileDialog fileDialog_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 90:
					fileDialog_0.set_Filter(string_1);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, fileDialog_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(WaitHandle waitHandle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					waitHandle_0.Close();
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, waitHandle_0, int_0, int_1);
			throw;
		}
	}
}
