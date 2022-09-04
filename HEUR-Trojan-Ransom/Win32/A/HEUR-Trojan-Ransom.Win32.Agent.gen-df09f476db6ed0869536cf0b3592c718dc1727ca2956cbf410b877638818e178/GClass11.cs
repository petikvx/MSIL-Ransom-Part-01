using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

[GAttribute0]
public static class GClass11
{
	[GAttribute0]
	public static string smethod_0(int int_0)
	{
		return $"0x{int_0:X}";
	}

	[GAttribute0]
	public static int smethod_1(byte[] byte_0, byte[] byte_1, int int_0 = 0)
	{
		int result = -1;
		int num = 0;
		for (int i = int_0; i < byte_0.Length; i++)
		{
			if (byte_0[i] == byte_1[num])
			{
				if (num == byte_1.Length - 1)
				{
					result = i - num;
					break;
				}
				num++;
			}
			else
			{
				num = 0;
			}
		}
		return result;
	}

	[GAttribute0]
	public static int smethod_2(string string_0)
	{
		if (string_0.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
		{
			string_0 = string_0.Substring(2);
		}
		return int.Parse(string_0, NumberStyles.HexNumber);
	}

	[GAttribute0]
	public static int smethod_3(byte[] byte_0, string string_0, int int_0 = 0)
	{
		int result = -1;
		int num = 0;
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		for (int i = int_0; i < byte_0.Length; i++)
		{
			if (byte_0[i] == bytes[num])
			{
				if (num == bytes.Length - 1)
				{
					result = i - num;
					break;
				}
				num++;
			}
			else
			{
				num = 0;
			}
		}
		return result;
	}

	[GAttribute0]
	public static byte[] smethod_4(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] array = null;
		int num = smethod_1(byte_0, byte_1);
		if (num >= 0)
		{
			array = new byte[byte_0.Length - byte_1.Length + byte_2.Length];
			Buffer.BlockCopy(byte_0, 0, array, 0, num);
			Buffer.BlockCopy(byte_2, 0, array, num, byte_2.Length);
			Buffer.BlockCopy(byte_0, num + byte_1.Length, array, num + byte_2.Length, byte_0.Length - (num + byte_1.Length));
			return array;
		}
		return byte_0;
	}

	[GAttribute0]
	public static byte[] smethod_5(byte[] byte_0, string string_0, string string_1)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		byte[] bytes2 = Encoding.ASCII.GetBytes(string_1);
		byte[] array = null;
		int num = smethod_1(byte_0, bytes);
		if (num >= 0)
		{
			array = new byte[byte_0.Length - bytes.Length + bytes2.Length];
			Buffer.BlockCopy(byte_0, 0, array, 0, num);
			Buffer.BlockCopy(bytes2, 0, array, num, bytes2.Length);
			Buffer.BlockCopy(byte_0, num + bytes.Length, array, num + bytes2.Length, byte_0.Length - (num + bytes.Length));
			return array;
		}
		return byte_0;
	}

	[GAttribute0]
	public static string smethod_6(byte[] byte_0, int int_0, int int_1)
	{
		byte[] array = null;
		array = new byte[int_1 - int_0];
		Buffer.BlockCopy(byte_0, int_0, array, 0, int_1 - int_0);
		return Encoding.ASCII.GetString(array);
	}

	[GAttribute0]
	public static byte[] smethod_7(byte[] byte_0, int int_0, int int_1)
	{
		byte[] array = null;
		array = new byte[int_1 - int_0];
		Buffer.BlockCopy(byte_0, int_0, array, 0, int_1 - int_0);
		return array;
	}

	[GAttribute0]
	public static byte[] smethod_8(byte[] byte_0, string string_0, string string_1, string string_2)
	{
		byte[] array = null;
		int num = smethod_3(byte_0, string_0);
		int num2 = smethod_3(byte_0, string_1);
		if (num > -1 && num2 > -1)
		{
			array = new byte[byte_0.Length - (num - num2) + string_2.Length];
			Buffer.BlockCopy(byte_0, 0, array, 0, num);
			Buffer.BlockCopy(Encoding.ASCII.GetBytes(string_2), 0, array, num, string_2.Length);
			Buffer.BlockCopy(byte_0, num + (num2 - num), array, num + string_2.Length, byte_0.Length - (num + (num2 - num)));
		}
		return array;
	}

	[GAttribute0]
	public static byte[] smethod_9(byte[] byte_0, int int_0, int int_1, byte[] byte_1)
	{
		byte[] array = null;
		array = new byte[byte_0.Length - (int_1 - int_0) + byte_1.Length];
		Buffer.BlockCopy(byte_0, 0, array, 0, int_0);
		Buffer.BlockCopy(byte_1, 0, array, int_0, byte_1.Length);
		Buffer.BlockCopy(byte_0, int_0 + (int_1 - int_0), array, int_0 + byte_1.Length, byte_0.Length - (int_0 + (int_1 - int_0)));
		return array;
	}

	[GAttribute0]
	public static T smethod_10<T>(List<T> list)
	{
		T val = list[0];
		list.Remove(val);
		return val;
	}

	[GAttribute0]
	public static void smethod_11<T>(List<T> list, T item)
	{
		list.Add(item);
	}
}
