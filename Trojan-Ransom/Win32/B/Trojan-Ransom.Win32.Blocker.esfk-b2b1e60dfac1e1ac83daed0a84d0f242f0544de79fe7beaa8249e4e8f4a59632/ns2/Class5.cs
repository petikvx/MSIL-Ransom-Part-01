using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns3;

namespace ns2;

internal class Class5
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct1
	{
		internal Timer timer_0;

		internal TextBox textBox_0;

		internal Button button_0;

		internal Label label_0;

		internal Label label_1;

		internal Label label_2;

		internal Label label_3;

		internal Panel panel_0;

		internal ProgressBar progressBar_0;
	}

	[STAThread]
	public static void Main(string[] args)
	{
		Class0.smethod_2(Class0.smethod_1(521225865, 8), 111, 100);
		Form0 form = new Form0();
		Class2.smethod_1((Control)(object)form, bool_0: false, 916, 937);
		Application.Run((Form)(object)form);
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Control control_0, Point point_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				control_0.set_Location(point_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(TextBox textBox_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 26:
				textBox_0.set_Text(string_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_2(Control control_0, int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 122:
				control_0.set_TabIndex(int_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(ContainerControl containerControl_0, SizeF sizeF_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 103:
				containerControl_0.set_AutoScaleDimensions(sizeF_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_4(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 103:
				ProjectData.SetProjectError(exception_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_5(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 63:
				return string_0 + string_1;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_6(Array array_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 101:
				Array.Reverse(array_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ILGenerator smethod_7(DynamicMethod dynamicMethod_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return dynamicMethod_0.GetILGenerator();
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_8(object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return RuntimeHelpers.GetObjectValue(object_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Process[] smethod_9(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 112:
				return Process.GetProcessesByName(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_10(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 82:
				return Application.get_StartupPath();
			case 83:
				return Application.get_ExecutablePath();
			}
		}
	}
}
