using System;
using System.Management;

public static class Static
{
	public static string GetProcessorId()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		string empty = string.Empty;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
					.ToString();
			}
			return empty;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string GetHDDSerialNo()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_LogicalDisk");
		ManagementObjectCollection instances = val.GetInstances();
		string text = "";
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text += Convert.ToString(((ManagementBaseObject)val2).get_Item("VolumeSerialNumber"));
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string GetMACAddress()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
		ManagementObjectCollection instances = val.GetInstances();
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == string.Empty && (bool)((ManagementBaseObject)val2).get_Item("IPEnabled"))
				{
					text = ((ManagementBaseObject)val2).get_Item("MacAddress").ToString();
				}
				val2.Dispose();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text.Replace(":", "");
	}

	public static string GetBoardMaker()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("Manufacturer").ToString();
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
		return "Board Maker: Unknown";
	}

	public static string GetBoardProductId()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("Product").ToString();
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
		return "Product: Unknown";
	}

	public static string GetCdRomDrive()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_CDROMDrive");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("Drive").ToString();
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
		return "CD ROM Drive Letter: Unknown";
	}

	public static string GetBIOSmaker()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("Manufacturer").ToString();
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

	public static string GetBIOSserNo()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("SerialNumber").ToString();
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
		return "BIOS Serial Number: Unknown";
	}

	public static string GetBIOScaption()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("Caption").ToString();
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
		return "BIOS Caption: Unknown";
	}

	public static string GetAccountName()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_UserAccount");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("Name").ToString();
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
		return "User Account Name: Unknown";
	}

	public static string GetPhysicalMemory()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		ManagementScope val = new ManagementScope();
		ObjectQuery val2 = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
		ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
		ManagementObjectCollection val4 = val3.Get();
		long num = 0L;
		long num2 = 0L;
		ManagementObjectEnumerator enumerator = val4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val5 = (ManagementObject)enumerator.get_Current();
				num2 = Convert.ToInt64(((ManagementBaseObject)val5).get_Item("Capacity"));
				num += num2;
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return num / 1024L / 1024L + "MB";
	}

	public static string GetNoRamSlots()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		int num = 0;
		ManagementScope val = new ManagementScope();
		ObjectQuery val2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
		ManagementObjectSearcher val3 = new ManagementObjectSearcher(val, val2);
		ManagementObjectCollection val4 = val3.Get();
		ManagementObjectEnumerator enumerator = val4.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val5 = (ManagementObject)enumerator.get_Current();
				num = Convert.ToInt32(((ManagementBaseObject)val5).get_Item("MemoryDevices"));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return num.ToString();
	}

	public static string GetCPUManufacturer()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass("Win32_Processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == string.Empty)
				{
					text = ((ManagementBaseObject)val2).get_Properties().get_Item("Manufacturer").get_Value()
						.ToString();
				}
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static int GetCPUCurrentClockSpeed()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		int num = 0;
		ManagementClass val = new ManagementClass("Win32_Processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (num == 0)
				{
					num = Convert.ToInt32(((ManagementBaseObject)val2).get_Properties().get_Item("CurrentClockSpeed").get_Value()
						.ToString());
				}
			}
			return num;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string GetDefaultIPGateway()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
		ManagementObjectCollection instances = val.GetInstances();
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == string.Empty && (bool)((ManagementBaseObject)val2).get_Item("IPEnabled"))
				{
					text = ((ManagementBaseObject)val2).get_Item("DefaultIPGateway").ToString();
				}
				val2.Dispose();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return text.Replace(":", "");
	}

	public static double? GetCpuSpeedInGHz()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		double? result = null;
		ManagementClass val = new ManagementClass("Win32_Processor");
		try
		{
			ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					return 0.001 * (double)(uint)((ManagementBaseObject)val2).get_Properties().get_Item("CurrentClockSpeed").get_Value();
				}
				return result;
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
	}

	public static string GetCurrentLanguage()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((ManagementBaseObject)val2).GetPropertyValue("CurrentLanguage").ToString();
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

	public static string GetOSInformation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					return ((string)((ManagementBaseObject)val2).get_Item("Caption")).Trim() + ", " + (string)((ManagementBaseObject)val2).get_Item("Version") + ", " + (string)((ManagementBaseObject)val2).get_Item("OSArchitecture");
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

	public static string GetProcessorInformation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				string text = (string)((ManagementBaseObject)val2).get_Item("Name");
				text = text.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®")
					.Replace("(r)", "®")
					.Replace("(C)", "©")
					.Replace("(c)", "©")
					.Replace("    ", " ")
					.Replace("  ", " ");
				result = text + ", " + (string)((ManagementBaseObject)val2).get_Item("Caption") + ", " + (string)((ManagementBaseObject)val2).get_Item("SocketDesignation");
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string GetComputerName()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ManagementClass val = new ManagementClass("Win32_ComputerSystem");
		ManagementObjectCollection instances = val.GetInstances();
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = (string)((ManagementBaseObject)val2).get_Item("Name");
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
