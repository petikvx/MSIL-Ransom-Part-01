using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Br6xyAepjdpOk46TDk;

namespace w;

public class mgr
{
	private delegate bool hdNfenwIlfLvDYcorn(int hWnd, int lParam);

	private delegate bool Wh7xoa5ZiXwbC7BvZx(int hWnd, int lParam);

	private List<IntPtr> O5I4HUul7;

	private static mgr bYdJbi5JXLcwX26v1JG;

	[DllImport("user32.dll")]
	private static extern bool EnableWindow(IntPtr intptr_0, bool bool_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetClassNameA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SendMessageA(int int_0, int int_1, int int_2, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(int int_0, StringBuilder stringBuilder_0, int int_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowTextLength(int int_0);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumChildWindows(IntPtr intptr_0, hdNfenwIlfLvDYcorn hdNfenwIlfLvDYcorn_0, ref IntPtr intptr_1);

	private bool IXwva9Uhs(int int_0, int int_1)
	{
		return true;
	}

	public void protect()
	{
	}

	private IntPtr[] Qyampsfg2(IntPtr intptr_0)
	{
		return null;
	}

	static mgr()
	{
		ik4jejCk9EETtfSsdE.SEBjiQyS0a();
		ik4jejCk9EETtfSsdE.iv6j25Ilsr();
	}

	internal static void gBU4My5CCUyoHjoEasw()
	{
	}

	internal static void Bq1FkG5mh1JJN4YA2Cl()
	{
	}

	internal static bool Q0wqrJ5Yw1MDOyhFaOG()
	{
		return true;
	}

	internal static mgr UK27Pv5GEVWT4o1URcM()
	{
		return null;
	}

	internal static object brrwca592Klr6itmr9q(int int_0)
	{
		return null;
	}

	internal static object sMaSnp5uVcL673IEekJ(object object_0, IntPtr intptr_0)
	{
		return null;
	}

	internal static int xBKSfl5K0OYVPomUmQL(object object_0)
	{
		return 0;
	}

	internal static void Mr0QFZ5Woru0ofDfx7p(object object_0)
	{
	}

	internal static object PKdmRW5Qrib309JDYm1(object object_0)
	{
		return null;
	}
}
