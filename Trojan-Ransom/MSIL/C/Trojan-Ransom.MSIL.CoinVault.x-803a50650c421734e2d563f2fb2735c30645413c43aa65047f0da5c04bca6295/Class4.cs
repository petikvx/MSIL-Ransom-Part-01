using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

internal class Class4
{
	private static string string_0 = string.Empty;

	public static string smethod_0()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			string_0 = smethod_1("CPU >> " + smethod_5() + "\nBIOS >> " + smethod_6() + "\nBASE >> " + smethod_8() + "\nDISK >> " + smethod_7());
		}
		return string_0;
	}

	private static string smethod_1(string string_1)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(string_1);
		return smethod_2(mD.ComputeHash(bytes));
	}

	private static string smethod_2(byte[] byte_0)
	{
		string text = string.Empty;
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte b = byte_0[i];
			int num = b;
			int num2 = num & 0xF;
			int num3 = (num >> 4) & 0xF;
			text = ((num3 <= 9) ? (text + num3) : (text + (char)(num3 - 10 + 65)));
			text = ((num2 <= 9) ? (text + num2) : (text + (char)(num2 - 10 + 65)));
			if (i + 1 != byte_0.Length && (i + 1) % 2 == 0)
			{
				text += "-";
			}
		}
		return text;
	}

	private static string smethod_3(string string_1, string string_2, string string_3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(string_1);
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (((ManagementBaseObject)val2).get_Item(string_3).ToString() == "True" && text == "")
				{
					try
					{
						text = ((ManagementBaseObject)val2).get_Item(string_2).ToString();
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

	private static string smethod_4(string string_1, string string_2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		string text = "";
		ManagementClass val = new ManagementClass(string_1);
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				if (text == "")
				{
					try
					{
						text = ((ManagementBaseObject)val2).get_Item(string_2).ToString();
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

	private static string smethod_5()
	{
		string text = smethod_4("Win32_Processor", "UniqueId");
		if (text == "")
		{
			text = smethod_4("Win32_Processor", "ProcessorId");
			if (text == "")
			{
				text = smethod_4("Win32_Processor", "Name");
				if (text == "")
				{
					text = smethod_4("Win32_Processor", "Manufacturer");
				}
				text += smethod_4("Win32_Processor", "MaxClockSpeed");
			}
		}
		return text;
	}

	private static string smethod_6()
	{
		return smethod_4("Win32_BIOS", "Manufacturer") + smethod_4("Win32_BIOS", "IdentificationCode") + smethod_4("Win32_BIOS", "SerialNumber") + smethod_4("Win32_BIOS", "ReleaseDate") + smethod_4("Win32_BIOS", "Version");
	}

	private static string smethod_7()
	{
		return smethod_4("Win32_DiskDrive", "Model") + smethod_4("Win32_DiskDrive", "Manufacturer") + smethod_4("Win32_DiskDrive", "Signature") + smethod_4("Win32_DiskDrive", "TotalHeads");
	}

	private static string smethod_8()
	{
		return smethod_4("Win32_BaseBoard", "Model") + smethod_4("Win32_BaseBoard", "Manufacturer") + smethod_4("Win32_BaseBoard", "Name") + smethod_4("Win32_BaseBoard", "SerialNumber");
	}
}
