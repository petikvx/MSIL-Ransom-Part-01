using System;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

public static class GClass49
{
	[CompilerGenerated]
	private static string string_0;

	public static string HardwareId
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	static GClass49()
	{
		HardwareId = GClass31.smethod_0(smethod_2() + smethod_1() + smethod_0());
	}

	public static string smethod_0()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						text = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Manufacturer").ToString();
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
		}
		return "Unknown";
	}

	public static string smethod_1()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = ((ManagementBaseObject)val2).get_Item("Manufacturer").ToString() + ((ManagementBaseObject)val2).get_Item("SerialNumber").ToString();
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
		}
		return "Unknown";
	}

	public static string smethod_2()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("Name").ToString() + "; ";
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
			text = GClass43.smethod_3(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
		}
		return "Unknown";
	}

	public static int smethod_3()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int result = 0;
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						result = (int)(Convert.ToDouble(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("TotalPhysicalMemory")) / 1048576.0);
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
			return result;
		}
		catch
		{
			return -1;
		}
	}

	public static string smethod_4()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("Description").ToString() + "; ";
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
			text = GClass43.smethod_3(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string smethod_5()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.GetIPProperties().GatewayAddresses.FirstOrDefault() == null || (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 && (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet || networkInterface.OperationalStatus != OperationalStatus.Up)))
			{
				continue;
			}
			foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
			{
				if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != 4294967295L)
				{
					return unicastAddress.Address.ToString();
				}
			}
		}
		return "-";
	}

	public static string smethod_6()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		int num = 0;
		NetworkInterface networkInterface;
		while (true)
		{
			if (num < allNetworkInterfaces.Length)
			{
				networkInterface = allNetworkInterfaces[num];
				if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet && networkInterface.OperationalStatus == OperationalStatus.Up))
				{
					bool flag = false;
					foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
					{
						if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != 4294967295L)
						{
							flag = unicastAddress.Address.ToString() == smethod_5();
						}
					}
					if (flag)
					{
						break;
					}
				}
				num++;
				continue;
			}
			return "-";
		}
		return GClass43.smethod_0(networkInterface.GetPhysicalAddress().ToString());
	}
}
