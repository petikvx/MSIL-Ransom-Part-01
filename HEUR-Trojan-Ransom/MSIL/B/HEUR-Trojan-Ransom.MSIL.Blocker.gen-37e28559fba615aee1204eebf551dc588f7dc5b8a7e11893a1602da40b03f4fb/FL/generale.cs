using System;
using System.Management;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace FL;

[StandardModule]
public sealed class generale
{
	public static void KU_KeyCreate(string string_0, string string_1, string string_2)
	{
		KeyRegistration.regedit = Registry.CurrentUser.OpenSubKey(string_0, writable: true);
		KeyRegistration.regedit.SetValue(string_1, string_2);
		KeyRegistration.regedit.Close();
	}

	public static string GetStrings(string string_0)
	{
		int num = 0;
		string result = "";
		string[] array = string_0.Split(new char[1] { ';' });
		checked
		{
			int num2 = array.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				switch (num)
				{
				case 0:
					num = 1;
					break;
				case 1:
					result = array[i];
					break;
				}
			}
			return result;
		}
	}

	public static string CreateRandomPassword(int int_0)
	{
		string text = "0123456789";
		Random random = new Random();
		checked
		{
			char[] array = new char[int_0 - 1 + 1];
			_ = text.Length;
			int num = int_0 - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = text[(int)Math.Round(Conversion.Fix((double)text.Length * random.NextDouble()))];
			}
			return new string(array);
		}
	}

	public static string smethod_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("Win32_LogicalDisk.DeviceID=\"C:\"");
		PropertyData val2 = ((ManagementBaseObject)val).get_Properties().get_Item("VolumeSerialNumber");
		return val2.get_Value().ToString();
	}
}
