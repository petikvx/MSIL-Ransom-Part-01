using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

public class FingerPrint
{
	private static string fingerPrint = string.Empty;

	public static string Value()
	{
		if (string.IsNullOrEmpty(fingerPrint))
		{
			fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " + biosId() + "\nBASE >> " + baseId() + "\nDISK >> " + diskId());
		}
		return fingerPrint;
	}

	private static string GetHash(string s)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = new ASCIIEncoding().GetBytes(s);
		return GetHexString(mD5CryptoServiceProvider.ComputeHash(bytes));
	}

	private static string GetHexString(byte[] bt)
	{
		string text = string.Empty;
		for (int i = 0; i < bt.Length; i++)
		{
			byte num = bt[i];
			int num2 = num & 0xF;
			int num3 = (num >> 4) & 0xF;
			text = ((num3 <= 9) ? (text + num3) : (text + (char)(num3 - 10 + 65)));
			text = ((num2 <= 9) ? (text + num2) : (text + (char)(num2 - 10 + 65)));
			if (i + 1 != bt.Length && (i + 1) % 2 == 0)
			{
				text += "-";
			}
		}
		return text;
	}

	private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		string text = "";
		ManagementObjectEnumerator enumerator = new ManagementClass(wmiClass).GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				if (((ManagementBaseObject)val).get_Item(wmiMustBeTrue).ToString() == "True" && text == "")
				{
					try
					{
						text = ((ManagementBaseObject)val).get_Item(wmiProperty).ToString();
						return text;
					}
					catch
					{
					}
				}
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string identifier(string wmiClass, string wmiProperty)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		string text = "";
		ManagementObjectEnumerator enumerator = new ManagementClass(wmiClass).GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				if (text == "")
				{
					try
					{
						text = ((ManagementBaseObject)val).get_Item(wmiProperty).ToString();
						return text;
					}
					catch
					{
					}
				}
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private static string cpuId()
	{
		string text = identifier("Win32_Processor", "UniqueId");
		if (text == "")
		{
			text = identifier("Win32_Processor", "ProcessorId");
			if (text == "")
			{
				text = identifier("Win32_Processor", "Name");
				if (text == "")
				{
					text = identifier("Win32_Processor", "Manufacturer");
				}
				text += identifier("Win32_Processor", "MaxClockSpeed");
			}
		}
		return text;
	}

	private static string biosId()
	{
		return identifier("Win32_BIOS", "Manufacturer") + identifier("Win32_BIOS", "SMBIOSBIOSVersion") + identifier("Win32_BIOS", "IdentificationCode") + identifier("Win32_BIOS", "SerialNumber") + identifier("Win32_BIOS", "ReleaseDate") + identifier("Win32_BIOS", "Version");
	}

	private static string diskId()
	{
		return identifier("Win32_DiskDrive", "Model") + identifier("Win32_DiskDrive", "Manufacturer") + identifier("Win32_DiskDrive", "Signature") + identifier("Win32_DiskDrive", "TotalHeads");
	}

	private static string baseId()
	{
		return identifier("Win32_BaseBoard", "Model") + identifier("Win32_BaseBoard", "Manufacturer") + identifier("Win32_BaseBoard", "Name") + identifier("Win32_BaseBoard", "SerialNumber");
	}

	private static string videoId()
	{
		return identifier("Win32_VideoController", "DriverVersion") + identifier("Win32_VideoController", "Name");
	}

	private static string macId()
	{
		return identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
	}
}
