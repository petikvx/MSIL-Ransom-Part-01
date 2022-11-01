using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace YullySpoofer;

internal class AdvanceSpoof
{
	public static void AdvanceSpoofFunction()
	{
		try
		{
			try
			{
				DeleteUSNJournal();
			}
			catch
			{
			}
			try
			{
				ModifyRegistry();
				HideSMBios();
			}
			catch
			{
			}
			try
			{
				DeleteVolumeShadowCopies();
			}
			catch
			{
			}
			try
			{
				ClearEventLogs();
			}
			catch
			{
			}
			try
			{
				BladeGroupBypass();
			}
			catch
			{
			}
			try
			{
				DeleteBackupCatalog();
				DeleteSystemBackups();
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	public static void BladeGroupBypass()
	{
		string[] array = new string[38]
		{
			"C:\\Program Files\\Blade Group", "C:\\Program Files\\Blade Group\\Config", "C:\\Program Files\\Blade Group\\Shadow Control Panel", "C:\\Program Files\\Blade Group\\ShadowActivities", "C:\\Program Files\\Blade Group\\ShadowDumpWindowsDriver", "C:\\Program Files\\Blade Group\\ShadowInstaller", "C:\\Program Files\\Blade Group\\ShadowInstallerClone", "C:\\Program Files\\Blade Group\\ShadowManager", "C:\\Program Files\\Blade Group\\ShadowNvidiaDriver", "C:\\Program Files\\Blade Group\\ShadowOperator",
			"C:\\Program Files\\Blade Group\\ShadowProcessator", "C:\\Program Files\\Blade Group\\ShadowServicesWatcher", "C:\\Program Files\\Blade Group\\ShadowStreamer", "C:\\Program Files\\Blade Group\\ShadowSystemWatcher", "C:\\Program Files\\Blade Group\\ShadowUsbOverIp", "C:\\Program Files\\Blade Group\\ShadowVirtualAudio", "C:\\Program Files\\Blade Group\\ShadowVirtualGamepad", "C:\\Program Files\\Blade Group\\ShadowVirtualHid", "C:\\Program Files\\Blade Group\\ShadowVirtualStorage", "C:\\Program Files (x86)\\Blade Group",
			"C:\\Program Files (x86)\\Blade Group\\Config", "C:\\Program Files (x86)\\Blade Group\\Shadow Control Panel", "C:\\Program Files (x86)\\Blade Group\\ShadowActivities", "C:\\Program Files (x86)\\Blade Group\\ShadowDumpWindowsDriver", "C:\\Program Files (x86)\\Blade Group\\ShadowInstaller", "C:\\Program Files (x86)\\Blade Group\\ShadowInstallerClone", "C:\\Program Files (x86)\\Blade Group\\ShadowManager", "C:\\Program Files (x86)\\Blade Group\\ShadowNvidiaDriver", "C:\\Program Files (x86)\\Blade Group\\ShadowOperator", "C:\\Program Files (x86)\\Blade Group\\ShadowProcessator",
			"C:\\Program Files (x86)\\Blade Group\\ShadowServicesWatcher", "C:\\Program Files (x86)\\Blade Group\\ShadowStreamer", "C:\\Program Files (x86)\\Blade Group\\ShadowSystemWatcher", "C:\\Program Files (x86)\\Blade Group\\ShadowUsbOverIp", "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualAudio", "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualGamepad", "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualHid", "C:\\Program Files (x86)\\Blade Group\\ShadowVirtualStorage"
		};
		foreach (string path in array)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
	}

	public static void ClearEventLogs()
	{
		EventLog[] eventLogs = EventLog.GetEventLogs();
		foreach (EventLog val in eventLogs)
		{
			val.Clear();
			((Component)(object)val).Dispose();
		}
	}

	public static void DeleteBackupCatalog()
	{
		Process process = new Process();
		process.StartInfo.FileName = "wbadmin.exe";
		process.StartInfo.Arguments = "delete catalog -quiet";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
	}

	public static void DeleteSystemBackups()
	{
		Process process = new Process();
		process.StartInfo.FileName = "wbadmin.exe";
		process.StartInfo.Arguments = "delete backup -keepversions:0 -quiet";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
		process.StartInfo.Arguments = "delete systemstatebackup -keepversions:0 -quiet";
		process.Start();
		process.WaitForExit();
	}

	public static void DeleteUSNJournal()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			Process process = new Process();
			process.StartInfo.FileName = "fsutil.exe";
			process.StartInfo.Arguments = "usn deletejournal /d /n " + driveInfo.Name.Replace("\\", "");
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			process.WaitForExit();
		}
	}

	public static void DeleteVolumeShadowCopies()
	{
		Process process = new Process();
		process.StartInfo.FileName = "vssadmin.exe";
		process.StartInfo.Arguments = "delete shadows /All /Quiet";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
		process.StartInfo.FileName = "vssadmin.exe";
		process.StartInfo.Arguments = "shadowcopy delete";
		process.Start();
		process.WaitForExit();
	}

	public static void DisableSystemBackups(bool istrue = true)
	{
		Process process = new Process();
		process.StartInfo.FileName = "wbadmin.exe";
		if (!istrue)
		{
			process.StartInfo.Arguments = "enable backup -quiet";
		}
		else
		{
			process.StartInfo.Arguments = "disable backup -quiet";
		}
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
	}

	public static string GenerateAnyAlphaString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijlkmnopqrstuvwxyz", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string GenerateLowerAlphaHexString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("abcdef", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string GenerateLowerAlphaString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("abcdefghijlkmnopqrstuvwxyz", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string GenerateRandomAlphanumericString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijlkmnopqrstuvwxyz0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string GenerateRandomNumericString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string GenerateUpperAlphaHexString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("ABCDEF", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string GenerateUpperAlphaString(int length = 10)
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	private static void HideSMBios()
	{
		RunAsProcess("reg add HKLM\\SYSTEM\\CurrentControlSet\\Control\\WMI\\Restrictions /F");
		RunAsProcess("reg add HKLM\\SYSTEM\\CurrentControlSet\\Control\\WMI\\Restrictions /v HideMachine /t REG_DWORD /d 1 /F");
		RunAsProcess("taskkill /F /IM WmiPrvSE.exe");
	}

	public static async void KillWMI()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName == "WmiPrvSE")
				{
					process.Kill();
				}
			}
			Process process2 = new Process();
			process2.StartInfo.FileName = "net.exe";
			process2.StartInfo.Arguments = "stop winmgmt /Y";
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.Start();
			await Task.Delay(4000);
			process2.Kill();
		}
		catch
		{
		}
	}

	public static void ModifyRegistry()
	{
		Registry.LocalMachine.DeleteSubKeyTree("Software\\NVIDIA Corporation");
		Registry.CurrentUser.DeleteSubKeyTree("Software\\NVIDIA Corporation");
		Registry.LocalMachine.DeleteSubKeyTree("SYSTEM\\MountedDevices");
		Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Dfrg\\Statistics");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi", writable: true);
		string[] subKeyNames = registryKey.GetSubKeyNames();
		foreach (string name in subKeyNames)
		{
			string[] subKeyNames2 = registryKey.OpenSubKey(name, writable: true)!.GetSubKeyNames();
			foreach (string name2 in subKeyNames2)
			{
				string[] subKeyNames3 = registryKey.OpenSubKey(name, writable: true)!.OpenSubKey(name2, writable: true)!.GetSubKeyNames();
				foreach (string name3 in subKeyNames3)
				{
					string[] subKeyNames4 = registryKey.OpenSubKey(name, writable: true)!.OpenSubKey(name2, writable: true)!.OpenSubKey(name3, writable: true)!.GetSubKeyNames();
					foreach (string text in subKeyNames4)
					{
						if (text.ToLower().Contains("logical unit id"))
						{
							RegistryKey registryKey2 = registryKey.OpenSubKey(name, writable: true)!.OpenSubKey(name2, writable: true)!.OpenSubKey(name3, writable: true)!.OpenSubKey(text, writable: true);
							object value = registryKey2.GetValue("DeviceIdentifierPage");
							if (value != null)
							{
								string @string = Encoding.UTF8.GetString((byte[])value);
								byte[] bytes = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(@string));
								registryKey2.SetValue("DeviceIdentifierPage", bytes);
							}
							object value2 = registryKey2.GetValue("Identifier");
							if (value2 != null)
							{
								registryKey2.SetValue("Identifier", StringRandomiseAround(value2.ToString()));
							}
							object value3 = registryKey2.GetValue("InquiryData");
							if (value3 != null)
							{
								string string2 = Encoding.UTF8.GetString((byte[])value3);
								byte[] bytes2 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string2));
								registryKey2.SetValue("InquiryData", bytes2);
							}
							object value4 = registryKey2.GetValue("SerialNumber");
							if (value4 != null)
							{
								registryKey2.SetValue("SerialNumber", StringRandomiseAround(value4.ToString()));
							}
						}
					}
				}
			}
		}
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController", writable: true);
		subKeyNames = registryKey3.GetSubKeyNames();
		foreach (string name4 in subKeyNames)
		{
			string[] subKeyNames2 = registryKey3.OpenSubKey(name4, writable: true)!.GetSubKeyNames();
			foreach (string name5 in subKeyNames2)
			{
				string[] subKeyNames3 = registryKey3.OpenSubKey(name4, writable: true)!.OpenSubKey(name5, writable: true)!.GetSubKeyNames();
				foreach (string name6 in subKeyNames3)
				{
					RegistryKey registryKey4 = registryKey3.OpenSubKey(name4, writable: true)!.OpenSubKey(name5, writable: true)!.OpenSubKey(name6, writable: true);
					object value5 = registryKey4.GetValue("Identifier");
					if (value5 != null)
					{
						registryKey4.SetValue("Identifier", StringRandomiseAround(value5.ToString()));
					}
				}
			}
		}
		RegistryKey registryKey5 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor", writable: true);
		subKeyNames = registryKey5.GetSubKeyNames();
		for (int i = 0; i < subKeyNames.Length; i++)
		{
			RegistryKey registryKey6 = registryKey5.OpenSubKey(subKeyNames[i], writable: true);
			object value6 = registryKey6.GetValue("Identifier");
			if (value6 != null)
			{
				registryKey6.SetValue("Identifier", StringRandomiseAround(value6.ToString()));
			}
			object value7 = registryKey6.GetValue("Component Information");
			if (value7 != null)
			{
				string string3 = Encoding.UTF8.GetString((byte[])value7);
				byte[] bytes3 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string3));
				registryKey6.SetValue("Component Information", bytes3);
			}
		}
		RegistryKey registryKey7 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_Processor", writable: true);
		object value8 = registryKey7.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey7.SetValue("Namespace", GenerateRandomAlphanumericString(6));
		}
		object value9 = registryKey7.GetValue("ExecutionMode");
		if (value9 != null)
		{
			registryKey7.SetValue("ExecutionMode", GenerateRandomAlphanumericString(2));
		}
		object value10 = registryKey7.GetValue("ProviderType");
		if (value10 != null)
		{
			registryKey7.SetValue("ProviderType", GenerateRandomAlphanumericString(2));
		}
		RegistryKey registryKey8 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_OperatingSystem", writable: true);
		value8 = registryKey8.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey8.SetValue("Namespace", GenerateRandomAlphanumericString(6));
		}
		value9 = registryKey8.GetValue("ExecutionMode");
		if (value9 != null)
		{
			registryKey8.SetValue("ExecutionMode", GenerateRandomAlphanumericString(2));
		}
		value10 = registryKey8.GetValue("ProviderType");
		if (value10 != null)
		{
			registryKey8.SetValue("ProviderType", GenerateRandomAlphanumericString(2));
		}
		RegistryKey registryKey9 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_BaseBoard", writable: true);
		value8 = registryKey9.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey9.SetValue("Namespace", GenerateRandomAlphanumericString(6));
		}
		value9 = registryKey9.GetValue("ExecutionMode");
		if (value9 != null)
		{
			registryKey9.SetValue("ExecutionMode", GenerateRandomAlphanumericString(2));
		}
		value10 = registryKey9.GetValue("ProviderType");
		if (value10 != null)
		{
			registryKey9.SetValue("ProviderType", GenerateRandomAlphanumericString(2));
		}
		RegistryKey registryKey10 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_BIOS", writable: true);
		value8 = registryKey10.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey10.SetValue("Namespace", GenerateRandomAlphanumericString(6));
		}
		value9 = registryKey10.GetValue("ExecutionMode");
		if (value9 != null)
		{
			registryKey10.SetValue("ExecutionMode", GenerateRandomAlphanumericString(2));
		}
		value10 = registryKey10.GetValue("ProviderType");
		if (value10 != null)
		{
			registryKey10.SetValue("ProviderType", GenerateRandomAlphanumericString(2));
		}
		RegistryKey registryKey11 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_DiskDrive", writable: true);
		value8 = registryKey11.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey11.SetValue("Namespace", GenerateRandomAlphanumericString(6));
		}
		value9 = registryKey11.GetValue("ExecutionMode");
		if (value9 != null)
		{
			registryKey11.SetValue("ExecutionMode", GenerateRandomAlphanumericString(2));
		}
		value10 = registryKey11.GetValue("ProviderType");
		if (value10 != null)
		{
			registryKey11.SetValue("ProviderType", GenerateRandomAlphanumericString(2));
		}
		RegistryKey registryKey12 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_VideoController", writable: true);
		value8 = registryKey12.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey12.SetValue("Namespace", GenerateRandomAlphanumericString(6));
		}
		value9 = registryKey12.GetValue("ExecutionMode");
		if (value9 != null)
		{
			registryKey12.SetValue("ExecutionMode", GenerateRandomAlphanumericString(2));
		}
		value10 = registryKey12.GetValue("ProviderType");
		if (value10 != null)
		{
			registryKey12.SetValue("ProviderType", GenerateRandomAlphanumericString(2));
		}
		RegistryKey registryKey13 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Provisioning\\CSPs\\.\\cimv2\\Win32_IDEController", writable: true);
		value8 = registryKey13.GetValue("Namespace");
		if (value8 != null)
		{
			registryKey13.SetValue("Namespace", StringRandomiseAround(value8.ToString()));
		}
		value9 = registryKey13.GetValue("ExecutionMode");
		if (value9 != null)
		{
			string string4 = Encoding.UTF8.GetString((byte[])value9);
			byte[] bytes4 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string4));
			registryKey13.SetValue("ExecutionMode", bytes4);
		}
		value10 = registryKey13.GetValue("ProviderType");
		if (value10 != null)
		{
			string string5 = Encoding.UTF8.GetString((byte[])value10);
			byte[] bytes5 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string5));
			registryKey13.SetValue("ProviderType", bytes5);
		}
		RegistryKey registryKey14 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", writable: true);
		object value11 = registryKey14.GetValue("BuildGUID");
		if (value11 != null)
		{
			registryKey14.SetValue("BuildGUID", StringRandomiseAroundHexadecimal(value11.ToString()));
		}
		object value12 = registryKey14.GetValue("ProductId");
		if (value12 != null)
		{
			registryKey14.SetValue("ProductId", StringRandomiseAround(value12.ToString()));
		}
		object value13 = registryKey14.GetValue("BuildGUIDEx");
		if (value13 != null)
		{
			string string6 = Encoding.UTF8.GetString((byte[])value13);
			byte[] bytes6 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string6));
			registryKey14.SetValue("BuildGUIDEx", bytes6);
		}
		object value14 = registryKey14.GetValue("DigitalProductId");
		if (value14 != null)
		{
			string string7 = Encoding.UTF8.GetString((byte[])value14);
			byte[] bytes7 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string7));
			registryKey14.SetValue("DigitalProductId", bytes7);
		}
		object value15 = registryKey14.GetValue("DigitalProductId4");
		if (value15 != null)
		{
			string string8 = Encoding.UTF8.GetString((byte[])value15);
			byte[] bytes8 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string8));
			registryKey14.SetValue("DigitalProductId4", bytes8);
		}
		object value16 = registryKey14.GetValue("InstallDate");
		if (value16 != null)
		{
			registryKey14.SetValue("InstallDate", StringRandomiseAround(value16.ToString()));
		}
		object value17 = registryKey14.GetValue("InstallTime");
		if (value17 != null)
		{
			registryKey14.SetValue("InstallTime", StringRandomiseAround(value17.ToString()));
		}
		RegistryKey registryKey15 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", writable: true);
		object value18 = registryKey15.GetValue("MachineGuid");
		if (value18 != null)
		{
			registryKey15.SetValue("MachineGuid", StringRandomiseAroundHexadecimal(value18.ToString()));
		}
		object value19 = registryKey15.GetValue("GUID");
		if (value19 != null)
		{
			registryKey15.SetValue("GUID", StringRandomiseAroundHexadecimal(value19.ToString()));
		}
		RegistryKey registryKey16 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", writable: true);
		object value20 = registryKey16.GetValue("HwProfileGuid");
		if (value20 != null)
		{
			registryKey16.SetValue("HwProfileGuid", StringRandomiseAroundHexadecimal(value20.ToString()));
		}
		RegistryKey registryKey17 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate", writable: true);
		object value21 = registryKey17.GetValue("SusClientId");
		if (value21 != null)
		{
			registryKey17.SetValue("SusClientId", StringRandomiseAroundHexadecimal(value21.ToString()));
		}
		object value22 = registryKey17.GetValue("AccountDomainSid");
		if (value22 != null)
		{
			registryKey17.SetValue("AccountDomainSid", StringRandomiseAroundHexadecimal(value22.ToString()));
		}
		object value23 = registryKey17.GetValue("PingID");
		if (value23 != null)
		{
			registryKey17.SetValue("PingID", StringRandomiseAroundHexadecimal(value23.ToString()));
		}
		object value24 = registryKey17.GetValue("SusClientIdValidation");
		if (value24 != null)
		{
			string string9 = Encoding.UTF8.GetString((byte[])value24);
			byte[] bytes9 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string9));
			registryKey17.SetValue("SusClientIdValidation", bytes9);
		}
		RegistryKey registryKey18 = Registry.LocalMachine.OpenSubKey("SYSTEM\\HardwareConfig", writable: true);
		object value25 = registryKey18.GetValue("LastConfig");
		if (value25 != null)
		{
			registryKey18.SetValue("LastConfig", StringRandomiseAroundHexadecimal(value25.ToString()));
		}
		RegistryKey registryKey19 = Registry.LocalMachine.OpenSubKey("SYSTEM\\ControlSet001\\Control\\SystemInformation", writable: true);
		object value26 = registryKey19.GetValue("ComputerHardwareId");
		if (value26 != null)
		{
			registryKey19.SetValue("ComputerHardwareId", StringRandomiseAroundHexadecimal(value26.ToString()));
		}
		object value27 = registryKey19.GetValue("ComputerHardwareIds");
		if (value27 != null)
		{
			registryKey19.SetValue("ComputerHardwareIds", StringRandomiseAroundHexadecimal(value27.ToString()));
		}
		RegistryKey registryKey20 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\Tcpip6\\Parameters", writable: true);
		object value28 = registryKey20.GetValue("Dhcpv6DUID");
		if (value28 != null)
		{
			string string10 = Encoding.UTF8.GetString((byte[])value28);
			byte[] bytes10 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string10));
			registryKey20.SetValue("Dhcpv6DUID", bytes10);
		}
		RegistryKey registryKey21 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation", writable: true);
		object value29 = registryKey21.GetValue("ComputerHardwareId");
		if (value29 != null)
		{
			registryKey21.SetValue("ComputerHardwareId", StringRandomiseAroundHexadecimal(value29.ToString()));
		}
		object value30 = registryKey21.GetValue("ComputerHardwareIds");
		if (value30 != null)
		{
			registryKey21.SetValue("ComputerHardwareIds", StringRandomiseAroundHexadecimal(value30.ToString()));
		}
		RegistryKey registryKey22 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Migration", writable: true);
		object value31 = registryKey22.GetValue("IE Installed Date");
		if (value31 != null)
		{
			string string11 = Encoding.UTF8.GetString((byte[])value31);
			byte[] bytes11 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string11));
			registryKey22.SetValue("IE Installed Date", bytes11);
		}
		RegistryKey registryKey23 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\SQMClient", writable: true);
		object value32 = registryKey23.GetValue("MachineId");
		if (value32 != null)
		{
			registryKey23.SetValue("MachineId", StringRandomiseAroundHexadecimal(value32.ToString()));
		}
		object value33 = registryKey23.GetValue("WinSqmFirstSessionStartTime");
		if (value33 != null)
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			object obj = value33;
			string text2 = "";
			for (int m = 0; m < obj.ToString()!.Length; m++)
			{
				random.NextBytes(new byte[5]);
				text2 += random.Next(0, 9);
			}
			registryKey23.SetValue("WinSqmFirstSessionStartTime", Convert.ToInt64(text2), RegistryValueKind.QWord);
		}
		RegistryKey registryKey24 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\GPU", writable: true);
		object value34 = registryKey24.GetValue("DeviceId");
		if (value34 != null)
		{
			string string12 = Encoding.UTF8.GetString((byte[])value34);
			byte[] bytes12 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string12));
			registryKey24.SetValue("DeviceId", bytes12);
		}
		object value35 = registryKey24.GetValue("Revision");
		if (value35 != null)
		{
			string string13 = Encoding.UTF8.GetString((byte[])value35);
			byte[] bytes13 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string13));
			registryKey24.SetValue("Revision", bytes13);
		}
		object value36 = registryKey24.GetValue("SubSysId");
		if (value36 != null)
		{
			string string14 = Encoding.UTF8.GetString((byte[])value36);
			byte[] bytes14 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string14));
			registryKey24.SetValue("SubSysId", bytes14);
		}
		object value37 = registryKey24.GetValue("VendorId");
		if (value37 != null)
		{
			string string15 = Encoding.UTF8.GetString((byte[])value37);
			byte[] bytes15 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string15));
			registryKey24.SetValue("VendorId", bytes15);
		}
		object value38 = registryKey24.GetValue("Wow64-DeviceId");
		if (value38 != null)
		{
			string string16 = Encoding.UTF8.GetString((byte[])value38);
			byte[] bytes16 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string16));
			registryKey24.SetValue("Wow64-DeviceId", bytes16);
		}
		object value39 = registryKey24.GetValue("Wow64-Revision");
		if (value39 != null)
		{
			string string17 = Encoding.UTF8.GetString((byte[])value39);
			byte[] bytes17 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string17));
			registryKey24.SetValue("Wow64-Revision", bytes17);
		}
		object value40 = registryKey24.GetValue("Wow64-SubSysId");
		if (value40 != null)
		{
			string string18 = Encoding.UTF8.GetString((byte[])value40);
			byte[] bytes18 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string18));
			registryKey24.SetValue("Wow64-SubSysId", bytes18);
		}
		object value41 = registryKey24.GetValue("Wow64-VendorId");
		if (value41 != null)
		{
			string string19 = Encoding.UTF8.GetString((byte[])value41);
			byte[] bytes19 = Encoding.UTF8.GetBytes(StringRandomiseAroundHexadecimal(string19));
			registryKey24.SetValue("Wow64-VendorId", bytes19);
		}
	}

	public static void RepairPhysicalDisk()
	{
		Process process = new Process();
		process.StartInfo.FileName = "powershell.exe";
		process.StartInfo.Arguments = "Repair-PhysicalDisk *";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
	}

	public static void ResetPhysicalDisk()
	{
		Process process = new Process();
		process.StartInfo.FileName = "powershell.exe";
		process.StartInfo.Arguments = "Reset-PhysicalDisk *";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		process.WaitForExit();
	}

	public static void RunAsProcess(string Code)
	{
		Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + Code)
		{
			CreateNoWindow = true,
			UseShellExecute = false
		});
		process?.WaitForExit();
		process?.Close();
	}

	public static string StringRandomiseAround(string str)
	{
		string text = "";
		Random random = new Random(Guid.NewGuid().GetHashCode());
		char[] array = str.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			char c = array[i];
			string text2 = ((!char.IsNumber(c)) ? (char.IsLower(c) ? (text + GenerateLowerAlphaString(1)) : ((!char.IsUpper(c)) ? (text + c) : (text + GenerateUpperAlphaString(1)))) : (text + random.Next(0, 9)));
			text = text2;
		}
		return text;
	}

	public static string StringRandomiseAroundHexadecimal(string str)
	{
		string text = "";
		Random random = new Random(Guid.NewGuid().GetHashCode());
		char[] array = str.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			char c = array[i];
			string text2 = ((!char.IsNumber(c)) ? (char.IsLower(c) ? (text + GenerateLowerAlphaHexString(1)) : ((!char.IsUpper(c)) ? (text + c) : (text + GenerateUpperAlphaHexString(1)))) : (text + random.Next(0, 9)));
			text = text2;
		}
		return text;
	}
}
