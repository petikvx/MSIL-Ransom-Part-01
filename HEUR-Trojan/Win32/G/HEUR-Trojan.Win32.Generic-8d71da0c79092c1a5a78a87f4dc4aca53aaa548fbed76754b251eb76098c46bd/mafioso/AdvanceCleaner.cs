using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using YullySpoofer;

namespace mafioso;

internal class AdvanceCleaner
{
	public static void CleanSteam()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.ProcessName.ToLower().Contains("rust") || process.ProcessName.ToLower().Contains("steam"))
				{
					process.Kill();
				}
			}
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Valve\\Steam", writable: true);
			if (registryKey == null)
			{
				return;
			}
			string path = registryKey.GetValue("InstallPath")!.ToString();
			DeleteDirectory(Path.Combine(path, "appcache"), subdirs: true);
			Directory.CreateDirectory(Path.Combine(path, "appcache"));
			DeleteDirectory(Path.Combine(path, "userdata"), subdirs: true);
			Directory.CreateDirectory(Path.Combine(path, "userdata"));
			DeleteFile(Path.Combine(path, "depotcache", "*.*"), insubdirs: true);
			DeleteFile(Path.Combine(path, "config", "*.*"), insubdirs: true);
			DeleteFile(Path.Combine(path, "dumps", "*.*"), insubdirs: true);
			DeleteFile(Path.Combine(path, "logs", "*.*"), insubdirs: true);
			DeleteFile(Path.Combine(path, ".crash"), insubdirs: true);
			DeleteFile(Path.Combine(path, "ssfn*"), insubdirs: true);
			RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam", writable: true);
			if (registryKey2 != null)
			{
				registryKey2.SetValue("AutoLoginUser", "");
				registryKey2.SetValue("LastGameNameUsed", "");
				registryKey2.SetValue("PseudoUUID", "");
			}
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Valve\\");
			string[] subKeyNames = registryKey3.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				using RegistryKey registryKey4 = registryKey3.OpenSubKey(subKeyNames[i]);
				string text = registryKey4.GetValue("InstallPath")!.ToString();
				string path2 = text + "/steamapps/libraryfolders.vdf";
				string pattern = "[A-Z]:\\\\";
				if (!File.Exists(path2))
				{
					continue;
				}
				string[] array = File.ReadAllLines(path2);
				foreach (string text2 in array)
				{
					Match match = Regex.Match(text2, pattern);
					if (!(text2 == string.Empty) && match.Success)
					{
						string value = match.ToString();
						string text3 = text2.Substring(text2.IndexOf(value));
						text3 = text3.Replace("\\\\", "\\");
						list.Add(text3.Replace("\"", "\\steamapps\\common\\"));
					}
				}
				list.Add(text + "\\steamapps\\common\\");
			}
			foreach (string item in list)
			{
				subKeyNames = Directory.GetDirectories(item);
				foreach (string text4 in subKeyNames)
				{
					string text5 = Path.Combine(item, "Rust");
					if (text4 == text5)
					{
						list2.Add(text5);
					}
				}
			}
			if (list2.Count == 0)
			{
				return;
			}
			foreach (string item2 in list2)
			{
				DeleteFile(Path.Combine(item2, "output_log*"), insubdirs: true);
			}
			RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Facepunch Studios LTD", writable: true);
			if (registryKey5.OpenSubKey("Rust") != null)
			{
				registryKey5.DeleteSubKey("Rust");
			}
		}
		catch (Exception)
		{
		}
	}

	public static void DeleteDirectory(string dir, bool subdirs = false, bool waitforexit = true)
	{
		string text = null;
		if (subdirs)
		{
			text = " /s";
		}
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/C \"rmdir" + text + " /q \"" + dir + "\"\"";
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		if (waitforexit)
		{
			process.WaitForExit();
		}
	}

	public static void DeleteFile(string file, bool insubdirs = false, bool waitforexit = true)
	{
		string text = null;
		if (insubdirs)
		{
			text = " /s";
		}
		Process process = new Process();
		process.StartInfo.FileName = "cmd.exe";
		process.StartInfo.Arguments = "/C \"del /f" + text + " /q \"" + file + "\"\"";
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
		if (waitforexit)
		{
			process.WaitForExit();
		}
	}

	public static void DeleteRegistry(string key, string valuename = null, bool recursive = true, bool searchintopkeyonly = true)
	{
		try
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			if (!TokenManipulation.MySetPrivilege("SeTakeOwnershipPrivilege", enablePrivilege: true))
			{
				throw new PrivilegeNotHeldException("SeTakeOwnershipPrivilege");
			}
			if (!TokenManipulation.MySetPrivilege("SeRestorePrivilege", enablePrivilege: true))
			{
				throw new PrivilegeNotHeldException("SeRestorePrivilege");
			}
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows Defender\\Features", RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.TakeOwnership);
			RegistrySecurity accessControl = registryKey.GetAccessControl(AccessControlSections.All);
			SecurityIdentifier owner = new SecurityIdentifier(accessControl.GetOwner(typeof(SecurityIdentifier))!.ToString());
			accessControl.SetOwner(current.User);
			registryKey.SetAccessControl(accessControl);
			RegistryAccessRule rule = new RegistryAccessRule(current.User, RegistryRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow);
			accessControl.AddAccessRule(rule);
			registryKey.SetAccessControl(accessControl);
			accessControl.SetOwner(owner);
			registryKey.SetAccessControl(accessControl);
			accessControl.RemoveAccessRule(rule);
			registryKey.SetAccessControl(accessControl);
		}
		catch (Exception)
		{
		}
	}

	public static void SpoofMAC()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		try
		{
			Process process = new Process();
			Random random = new Random(Guid.NewGuid().GetHashCode());
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter").Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val = (ManagementObject)enumerator.get_Current();
					if (!Convert.ToBoolean(((ManagementBaseObject)val).get_Item("PhysicalAdapter")))
					{
						continue;
					}
					string text = "02";
					if (!((ManagementBaseObject)val).get_Item("NetConnectionID").ToString()!.Contains("Bluetooth") && !((ManagementBaseObject)val).get_Item("Caption").ToString()!.Contains("Bluetooth") && !((ManagementBaseObject)val).get_Item("Name").ToString()!.Contains("Bluetooth"))
					{
						string text2 = ((ManagementBaseObject)val).get_Item("DeviceID").ToString()!.PadLeft(4, '0');
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\" + text2, writable: true);
						byte[] array = new byte[5];
						random.NextBytes(array);
						string value = text + string.Concat(array.Select(delegate(byte x)
						{
							byte b = x;
							return string.Format("{0}", b.ToString("X2"));
						}).ToArray()).TrimEnd(new char[1] { ':' });
						registryKey.SetValue("OriginalNetworkAddress", value);
						registryKey.SetValue("NetworkAddress", value);
						registryKey.SetValue("PnPCapabilities", "24");
						process.StartInfo.FileName = "netsh.exe";
						ProcessStartInfo startInfo = process.StartInfo;
						string text3 = "int set int name=\"";
						object obj = ((ManagementBaseObject)val).get_Item("NetConnectionID");
						string text4 = text3;
						string text5 = obj?.ToString();
						startInfo.Arguments = text4 + text5 + "\" disable";
						process.StartInfo.UseShellExecute = false;
						process.StartInfo.CreateNoWindow = true;
						process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process.Start();
						process.WaitForExit();
						ProcessStartInfo startInfo2 = process.StartInfo;
						string text6 = "int set int name=\"";
						object obj2 = ((ManagementBaseObject)val).get_Item("NetConnectionID");
						string text7 = text6;
						string text8 = obj2?.ToString();
						startInfo2.Arguments = text7 + text8 + "\" enable";
						process.Start();
						process.WaitForExit();
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			process.StartInfo.Arguments = "winsock reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int ip reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int ipv4 reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int ipv6 reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int tcp reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int reset all";
			process.Start();
			process.WaitForExit();
			process.StartInfo.FileName = "ipconfig.exe";
			process.StartInfo.Arguments = "/release";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "/renew";
			process.Start();
			process.StartInfo.Arguments = "/flushdns";
			process.Start();
			process.WaitForExit();
			process.StartInfo.FileName = "nbtstat.exe";
			process.StartInfo.Arguments = "-R";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "-RR";
			process.Start();
			process.WaitForExit();
			process.StartInfo.FileName = "wmic.exe";
			process.StartInfo.Arguments = "PATH WIN32_NETWORKADAPTER WHERE PHYSICALADAPTER=TRUE CALL DISABLE";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "PATH WIN32_NETWORKADAPTER WHERE PHYSICALADAPTER=TRUE CALL ENABLE";
			process.Start();
			process.WaitForExit();
			process.StartInfo.FileName = "netsh.exe";
			process.StartInfo.Arguments = "advfirewall reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int ipv6 reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "winsock reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "int ip reset";
			process.Start();
			process.WaitForExit();
			process.StartInfo.FileName = "ipconfig.exe";
			process.StartInfo.Arguments = "/release";
			process.Start();
			process.WaitForExit();
			process.StartInfo.Arguments = "/renew";
			process.Start();
			process.StartInfo.Arguments = "/flushdns";
			process.Start();
			process.WaitForExit();
		}
		catch (Exception)
		{
		}
	}
}
