using System;
using System.Collections;
using Microsoft.Win32;
using ns13;

namespace ns5;

public class GClass12
{
	public enum GEnum3
	{
		const_0,
		const_1
	}

	public static string smethod_0(byte[] byte_0)
	{
		string text = string.Empty;
		byte_0[66] = (byte)((byte_0[66] & 0xF7u) | 0u);
		int num = 0;
		for (int num2 = 24; num2 >= 0; num2--)
		{
			int num3 = 0;
			for (int num4 = 14; num4 >= 0; num4--)
			{
				num3 *= 256;
				num3 = byte_0[num4 + 52] + num3;
				byte_0[num4 + 52] = (byte)(num3 / 24);
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

	private static string smethod_1(byte[] byte_0)
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
			arrayList.Add(byte_0[i]);
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

	private static string smethod_2(byte[] byte_0, GEnum3 genum3_0)
	{
		if (genum3_0 != GEnum3.const_1)
		{
			return smethod_1(byte_0);
		}
		return smethod_0(byte_0);
	}

	public static string smethod_3()
	{
		RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
		object obj = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion")?.GetValue("DigitalProductId");
		if (obj == null)
		{
			return "Failed to get DigitalProductId from registry";
		}
		byte[] byte_ = (byte[])obj;
		registryKey.Close();
		bool flag = (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 2) || Environment.OSVersion.Version.Major > 6;
		Class55.bool_4 = true;
		return smethod_2(byte_, flag ? GEnum3.const_1 : GEnum3.const_0);
	}
}
