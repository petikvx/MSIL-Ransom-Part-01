using System;
using System.Collections;
using System.Management;
using Microsoft.Win32;
using ___codefort;

internal sealed class Class6
{
	public string method_0()
	{
		return method_2() + Class22.smethod_0(737969405) + method_4();
	}

	public string method_1()
	{
		string string_ = (method_5() + method_7() + method_6()).ToString();
		return Class8.class21_0.method_2(string_);
	}

	private string method_2()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class22.smethod_0(737969285), Class22.smethod_0(737969300));
		string text = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class22.smethod_0(737969337)));
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		try
		{
			text = text.Split(new char[1] { '|' })[0];
			int length = text.Split(new char[1] { ' ' })[0].Length;
			return text.Substring(length).TrimStart(new char[0]).TrimEnd(new char[0]);
		}
		catch
		{
			return Class22.smethod_0(737969218);
		}
	}

	public static string smethod_0()
	{
		string empty = string.Empty;
		if (Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969241))!.GetValue(Class22.smethod_0(737969172))!.ToString()!.Contains(Class22.smethod_0(737969191)))
		{
			return Class22.smethod_0(737969193);
		}
		return empty + Class22.smethod_0(737969212);
	}

	public string method_3()
	{
		string empty = string.Empty;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969603));
		if (registryKey != null)
		{
			_ = (string)registryKey.GetValue(Class22.smethod_0(737969657)) + smethod_0();
		}
		RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969603));
		if (registryKey2 != null)
		{
			smethod_1((byte[])registryKey2.GetValue(Class22.smethod_0(737969547), RegistryValueKind.DWord));
		}
		return smethod_1((byte[])registryKey2.GetValue(Class22.smethod_0(737969547), RegistryValueKind.DWord));
	}

	public static string smethod_1(byte[] byte_0)
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

	private string method_4()
	{
		if (Registry.LocalMachine.OpenSubKey(Class22.smethod_0(737969241))!.GetValue(Class22.smethod_0(737969172))!.ToString()!.Contains(Class22.smethod_0(737969191)))
		{
			return Class22.smethod_0(737969568);
		}
		return Class22.smethod_0(737969585);
	}

	private string method_5()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class22.smethod_0(737969285), Class22.smethod_0(737969478));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class22.smethod_0(737969530)));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private string method_6()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class22.smethod_0(737969285), Class22.smethod_0(737969428));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class22.smethod_0(737969456)));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public string method_7()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher(Class22.smethod_0(737969285), Class22.smethod_0(737968845));
		string result = string.Empty;
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = Convert.ToString(((ManagementBaseObject)val2).get_Item(Class22.smethod_0(737968887)));
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
