using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using Microsoft.Win32;

internal class Spoof69
{
	[Obfuscation(Feature = "virtualization", Exclude = true)]
	private static Random random;

	static Spoof69()
	{
		random = new Random();
	}

	public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
	{
		string text = "Ethernet";
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (!(networkInterface.Id != adapterId))
			{
				text = networkInterface.Name;
				break;
			}
		}
		string text2 = ((!enable) ? "disable" : "enable");
		ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + text + "\" " + text2);
		Process process = new Process
		{
			StartInfo = startInfo
		};
		process.Start();
		process.WaitForExit();
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static string RandomId(int length)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = "";
		Random random = new Random();
		for (int i = 0; i < length; i++)
		{
			text2 += text[random.Next(text.Length)];
		}
		return text2;
	}

	public static string RandomMac()
	{
		string text = "ABCDEF0123456789";
		string text2 = "26AE";
		string text3 = "";
		Random random = new Random();
		text3 += text[random.Next(text.Length)];
		text3 += text2[random.Next(text2.Length)];
		for (int i = 0; i < 5; i++)
		{
			text3 += "-";
			text3 += text[random.Next(text.Length)];
			text3 += text[random.Next(text.Length)];
		}
		return text3;
	}

	public static string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofBiosInfo(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("BIOSVendor", generatedID);
			registryKey.SetValue("BIOSReleaseDate", generatedID);
			registryKey.SetValue("ProductId", generatedID);
			registryKey.SetValue("ProcessorNameString", generatedID);
			registryKey.SetValue("BaseBoardProduct", generatedID);
			registryKey.SetValue("SystemProductName", generatedID);
			registryKey.SetValue("SystemSKU", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofCentralProcessor(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Hardware\\Description\\System\\CentralProcessor\\0", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("SystemProductName", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("Previous Update Revision", generatedID);
			registryKey.SetValue("ProcessorNameString", generatedID);
			registryKey.SetValue("VendorIdentifier", generatedID);
			registryKey.SetValue("Platform Specific Field1", generatedID);
			registryKey.SetValue("Component Information", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofCurrentConstrollSet(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0000", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("MatchingDeviceId", generatedID);
			registryKey.SetValue("InfPath", generatedID);
			registryKey.SetValue("InfSection", generatedID);
			registryKey.SetValue("DriverVersion", generatedID);
			registryKey.SetValue("DriverDateData", generatedID);
			registryKey.SetValue("DriverDate", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofCurrentConstrollSet2(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Class\\{4d36e968-e325-11ce-bfc1-08002be10318}\\0001", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("MonitorCapabilityList", generatedID);
			registryKey.SetValue("MatchingDeviceId", generatedID);
			registryKey.SetValue("InfSection", generatedID);
			registryKey.SetValue("InfPath", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofDisk1(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofDisk2(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofDisk3(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 2\\Target Id 0\\Logical Unit Id 0", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofDisk4(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 3\\Target Id 0\\Logical Unit Id 0", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofDisk5(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 1\\Target Id 0\\Logical Unit Id 0", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofDiskPort1(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 1\\Scsi Bus 0\\Initiator Id ", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("DeviceIdentifierPage", generatedID);
			registryKey.SetValue("Identifier", generatedID);
			registryKey.SetValue("SerialNumber", generatedID);
			registryKey.SetValue("InquiryData", generatedID);
			registryKey.Close();
		}
	}

	public static void SpoofDisks()
	{
		string[] subKeyNames = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi")!.GetSubKeyNames();
		foreach (string text in subKeyNames)
		{
			string[] subKeyNames2 = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text)!.GetSubKeyNames();
			foreach (string text2 in subKeyNames2)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text + "\\" + text2 + "\\Target Id 0\\Logical Unit Id 0", writable: true);
				if (registryKey != null && registryKey.GetValue("DeviceType")!.ToString() == "DiskPeripheral")
				{
					string text3 = RandomId(14);
					string text4 = RandomId(14);
					registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(text4));
					registryKey.SetValue("Identifier", text3);
					registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(text3));
					registryKey.SetValue("SerialNumber", text4);
				}
			}
		}
		subKeyNames = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral")!.GetSubKeyNames();
		foreach (string text5 in subKeyNames)
		{
			Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + text5, writable: true)!.SetValue("Identifier", RandomId(8) + "-" + RandomId(8) + "-A");
		}
	}

	public static void SpoofGUIDs()
	{
		Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", writable: true)!.SetValue("HwProfileGuid", $"{{{Guid.NewGuid()}}}");
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", writable: true);
		registryKey.SetValue("MachineGuid", Guid.NewGuid().ToString());
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\SQMClient", writable: true)!.SetValue("MachineId", $"{{{Guid.NewGuid()}}}");
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\SystemInformation", writable: true);
		Random random = new Random();
		int num = random.Next(1, 31);
		string text = "";
		text = ((num >= 10) ? num.ToString() : $"0{num}");
		int num2 = random.Next(1, 13);
		string text2 = "";
		text2 = ((num2 >= 10) ? num2.ToString() : $"0{num2}");
		registryKey2.SetValue("BIOSReleaseDate", $"{text}/{text2}/{random.Next(2000, 2023)}");
		registryKey2.SetValue("BIOSVersion", RandomId(10));
		registryKey2.SetValue("ComputerHardwareId", $"{{{Guid.NewGuid()}}}");
		registryKey2.SetValue("ComputerHardwareIds", $"{{{Guid.NewGuid()}}}\n{{{Guid.NewGuid()}}}\n{{{Guid.NewGuid()}}}\n");
		registryKey2.SetValue("SystemManufacturer", RandomId(15));
		registryKey2.SetValue("SystemProductName", RandomId(6));
		RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate", writable: true);
		registryKey3.SetValue("SusClientId", Guid.NewGuid().ToString());
		registryKey3.SetValue("SusClientIdValidation", Encoding.UTF8.GetBytes(RandomId(25)));
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void SpoofRegistry()
	{
		string generatedID = RandomString(10);
		spoofCentralProcessor(generatedID);
		spoofDisk1(generatedID);
		spoofDisk2(generatedID);
		spoofDisk3(generatedID);
		spoofDisk4(generatedID);
		spoofDisk5(generatedID);
		spoofDiskPort1(generatedID);
		SpoofDisks();
		SpoofGUIDs();
		spoofCurrentConstrollSet(generatedID);
		spoofCurrentConstrollSet2(generatedID);
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofSystemControllSet(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\SystemInformation", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("BIOSReleaseDate", "14/12/2020");
			registryKey.SetValue("BIOSVersion", generatedID);
			registryKey.SetValue("ComputerHardwareId", "{c2ca38ff-ab7f-5d23-ba6b-3f01afc1488d}");
			registryKey.SetValue("ComputerHardwareIds", "{id}");
			registryKey.SetValue("SystemManufacturer", generatedID);
			registryKey.SetValue("SystemProductName", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofWindows(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("SusClientId", generatedID);
			registryKey.SetValue("SusClientIdValidation", generatedID);
			registryKey.SetValue("LastDownloadsPurgeTime", "2020-14-04 06:29:29");
			registryKey.Close();
		}
	}

	public static void spoofWindows2(string generatedID)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001", writable: true);
		if (registryKey != null)
		{
			registryKey.SetValue("ComponentId", generatedID);
			registryKey.SetValue("DeviceInstanceID", generatedID);
			registryKey.SetValue("DriverVersion", generatedID);
			registryKey.SetValue("InfPath", generatedID);
			registryKey.SetValue("InfSection", generatedID);
			registryKey.SetValue("MatchingDeviceId", generatedID);
			registryKey.SetValue("NetCfgInstanceId", generatedID);
			registryKey.Close();
		}
	}

	[Obfuscation(Feature = "virtualization", Exclude = true)]
	public static void spoofWindowsActivation(string generatedID)
	{
		Registry.LocalMachine.OpenSubKey("", writable: true);
	}
}
