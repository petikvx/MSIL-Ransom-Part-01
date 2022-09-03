using System;
using System.Diagnostics;
using System.Text;
using RAccPass;

namespace ___codefort;

internal sealed class Class2 : Class1
{
	private static Process process_0;

	public static bool smethod_4()
	{
		frmMain.Process_0 = Process.GetProcessesByName(Encoding.Unicode.GetString(Convert.FromBase64String("VABpAGIAaQBhAA==")));
		return frmMain.Process_0.Length > 0 && !frmMain.Process_0[0].HasExited && frmMain.Process_0[0].Handle != IntPtr.Zero && !string.IsNullOrEmpty(frmMain.Process_0[0].MainWindowTitle) && frmMain.String_0 == Class1.smethod_3(frmMain.Process_0[0].MainModule!.BaseAddress.ToInt32() + 5934365, (IntPtr)4);
	}

	static Class2()
	{
		Class3.smethod_0();
		process_0 = new Process();
	}
}
