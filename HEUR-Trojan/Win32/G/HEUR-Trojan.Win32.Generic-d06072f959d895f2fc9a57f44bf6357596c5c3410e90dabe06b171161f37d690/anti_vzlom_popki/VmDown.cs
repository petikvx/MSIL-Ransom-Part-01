using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace anti_vzlom_popki;

internal class VmDown
{
	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetModuleHandle(string x);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetProcAddress(IntPtr a, string b);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern uint GetFileAttributes(string d);

	public static void Initialize()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (CspParameters())
			{
				MessageBox.Show("Runtime Error at 69464569456945694e2432");
				CrossAppDomainSerializer("START CMD /C \"ECHO VirtualMachine Detected ! && PAUSE\" ");
				Process.GetCurrentProcess().Kill();
			}
		}
		catch
		{
		}
	}

	internal static void CrossAppDomainSerializer(string A_0)
	{
		Process.Start(new ProcessStartInfo("cmd.exe", "/c " + A_0)
		{
			CreateNoWindow = true,
			UseShellExecute = false
		});
	}

	internal static bool CspParameters()
	{
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0242: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		if (NodeEnumerator("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VBOX"))
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\Description\\System", "SystemBiosVersion").ToUpper().Contains("VBOX"))
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\Description\\System", "VideoBiosVersion").ToUpper().Contains("VIRTUALBOX"))
		{
			return true;
		}
		if (NodeEnumerator("SOFTWARE\\Oracle\\VirtualBox Guest Additions", "") == "noValueButYesKey")
		{
			return true;
		}
		if (GetFileAttributes("C:\\WINDOWS\\system32\\drivers\\VBoxMouse.sys") != uint.MaxValue)
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (NodeEnumerator("SOFTWARE\\VMware, Inc.\\VMware Tools", "") == "noValueButYesKey")
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 1\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 2\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (NodeEnumerator("SYSTEM\\ControlSet001\\Services\\Disk\\Enum", "0").ToUpper().Contains("vmware".ToUpper()))
		{
			return true;
		}
		if (NodeEnumerator("SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000", "DriverDesc").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (NodeEnumerator("SYSTEM\\ControlSet001\\Control\\Class\\{4D36E968-E325-11CE-BFC1-08002BE10318}\\0000\\Settings", "Device Description").ToUpper().Contains("VMWARE"))
		{
			return true;
		}
		if (NodeEnumerator("SOFTWARE\\VMware, Inc.\\VMware Tools", "InstallPath").ToUpper().Contains("C:\\PROGRAM FILES\\VMWARE\\VMWARE TOOLS\\"))
		{
			return true;
		}
		if (GetFileAttributes("C:\\WINDOWS\\system32\\drivers\\vmmouse.sys") != uint.MaxValue)
		{
			return true;
		}
		if (GetFileAttributes("C:\\WINDOWS\\system32\\drivers\\vmhgfs.sys") != uint.MaxValue)
		{
			return true;
		}
		if (GetProcAddress(GetModuleHandle("kernel32.dll"), "wine_get_unix_file_name") != (IntPtr)0)
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", "Identifier").ToUpper().Contains("QEMU"))
		{
			return true;
		}
		if (NodeEnumerator("HARDWARE\\Description\\System", "SystemBiosVersion").ToUpper().Contains("QEMU"))
		{
			return true;
		}
		ManagementScope val = new ManagementScope("\\\\.\\ROOT\\cimv2");
		ObjectQuery val2 = new ObjectQuery("SELECT * FROM Win32_VideoController");
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(val, val2).Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				if (!(((ManagementBaseObject)val3).get_Item("Description").ToString() == "VM Additions S3 Trio32/64"))
				{
					if (!(((ManagementBaseObject)val3).get_Item("Description").ToString() == "S3 Trio32/64"))
					{
						if (!(((ManagementBaseObject)val3).get_Item("Description").ToString() == "VirtualBox Graphics Adapter"))
						{
							if (!(((ManagementBaseObject)val3).get_Item("Description").ToString() == "VMware SVGA II"))
							{
								if (!((ManagementBaseObject)val3).get_Item("Description").ToString()!.ToUpper().Contains("VMWARE"))
								{
									if (((ManagementBaseObject)val3).get_Item("Description").ToString() == "")
									{
										return true;
									}
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return false;
	}

	internal static string NodeEnumerator(string A_0, string A_1)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(A_0, writable: false);
		if (registryKey == null)
		{
			return "noKey";
		}
		object value = registryKey.GetValue(A_1, "noValueButYesKey");
		if (value.GetType() == typeof(string))
		{
			return value.ToString();
		}
		if (registryKey.GetValueKind(A_1) != RegistryValueKind.String && registryKey.GetValueKind(A_1) != RegistryValueKind.ExpandString)
		{
			if (registryKey.GetValueKind(A_1) == RegistryValueKind.DWord)
			{
				return Convert.ToString((int)value);
			}
			if (registryKey.GetValueKind(A_1) == RegistryValueKind.QWord)
			{
				return Convert.ToString((long)value);
			}
			if (registryKey.GetValueKind(A_1) == RegistryValueKind.Binary)
			{
				return Convert.ToString((byte[])value);
			}
			if (registryKey.GetValueKind(A_1) == RegistryValueKind.MultiString)
			{
				return string.Join("", (string[])value);
			}
			return "noValueButYesKey";
		}
		return value.ToString();
	}
}
