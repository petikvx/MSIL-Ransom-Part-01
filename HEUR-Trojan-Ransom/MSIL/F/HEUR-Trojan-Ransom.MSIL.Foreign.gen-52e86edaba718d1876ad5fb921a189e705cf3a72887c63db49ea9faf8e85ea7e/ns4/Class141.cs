using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns21;

namespace ns4;

internal sealed class Class141
{
	[NonSerialized]
	internal static GetString getString_0;

	private static void smethod_0(byte[] byte_0, int int_0, byte[] byte_1, int int_1, byte[] byte_2, int int_2)
	{
		if (int_0 >= 0 && int_0 < byte_0.Length)
		{
			if (int_0 + int_2 > byte_0.Length)
			{
				throw new ArgumentException(Class121.FromAndLengthTooBig, getString_0(107353644));
			}
			if (byte_0 == null)
			{
				throw new ArgumentException(Class121.BufferCannotBeNull, getString_0(107353663));
			}
			if (byte_1 == null)
			{
				throw new ArgumentException(Class121.BufferCannotBeNull, getString_0(107353622));
			}
			if (int_1 >= 0 && int_1 < byte_1.Length)
			{
				if (int_1 + int_2 > byte_1.Length)
				{
					throw new ArgumentException(Class121.IndexAndLengthTooBig, getString_0(107353617));
				}
				if (byte_2 != null && byte_2.Length >= int_2)
				{
					if (int_2 < 0)
					{
						throw new ArgumentException(Class121.ParameterCannotBeNegative, getString_0(107359614));
					}
					for (int i = 0; i < int_2; i++)
					{
						byte_1[int_1++] = (byte)(byte_0[int_0++] ^ byte_2[i]);
					}
					return;
				}
				throw new ArgumentException(Class121.PasswordMustHaveLegalChars, getString_0(107353636));
			}
			throw new ArgumentException(Class121.IndexMustBeValid, getString_0(107353617));
		}
		throw new ArgumentException(Class121.IndexMustBeValid, getString_0(107353644));
	}

	public static byte[] smethod_1(string string_0, string string_1)
	{
		if (string_0.Length == 0)
		{
			return new byte[1];
		}
		SHA1 sHA = SHA1.Create();
		byte[] array = sHA.ComputeHash(Encoding.Default.GetBytes(string_0));
		byte[] array2 = sHA.ComputeHash(array);
		byte[] bytes = Encoding.Default.GetBytes(string_1);
		byte[] array3 = new byte[bytes.Length + array2.Length];
		Array.Copy(bytes, 0, array3, 0, bytes.Length);
		Array.Copy(array2, 0, array3, bytes.Length, array2.Length);
		byte[] array4 = sHA.ComputeHash(array3);
		byte[] array5 = new byte[array4.Length + 1];
		array5[0] = 20;
		Array.Copy(array4, 0, array5, 1, array4.Length);
		for (int i = 1; i < array5.Length; i++)
		{
			array5[i] = (byte)(array5[i] ^ array[i - 1]);
		}
		return array5;
	}

	private static double smethod_2(ref long long_0, ref long long_1, long long_2)
	{
		long_0 = long_0 * 3L + long_1;
		long_0 %= long_2;
		long_1 = (long_0 + long_1 + 33L) % long_2;
		return (double)long_0 / (double)long_2;
	}

	public static string smethod_3(string string_0, string string_1, bool bool_0)
	{
		long num = 1073741823L;
		if (!bool_0)
		{
			num = 33554431L;
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return string_0;
		}
		long[] array = smethod_4(string_1);
		long[] array2 = smethod_4(string_0);
		long long_ = (array[0] ^ array2[0]) % num;
		long long_2 = (array[1] ^ array2[1]) % num;
		if (!bool_0)
		{
			long_2 = long_ / 2L;
		}
		char[] array3 = new char[string_1.Length];
		for (int i = 0; i < string_1.Length; i++)
		{
			double num2 = smethod_2(ref long_, ref long_2, num);
			array3[i] = (char)(Math.Floor(num2 * 31.0) + 64.0);
		}
		if (bool_0)
		{
			char c = (char)Math.Floor(smethod_2(ref long_, ref long_2, num) * 31.0);
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] ^= c;
			}
		}
		return new string(array3);
	}

	private static long[] smethod_4(string string_0)
	{
		long num = 1345345333L;
		long num2 = 305419889L;
		long num3 = 7L;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] != ' ' && string_0[i] != '\t')
			{
				long num4 = 0xFF & string_0[i];
				num ^= ((num & 0x3FL) + num3) * num4 + (num << 8);
				num2 += (num2 << 8) ^ num;
				num3 += num4;
			}
		}
		return new long[2]
		{
			num & 0x7FFFFFFFL,
			num2 & 0x7FFFFFFFL
		};
	}

	static Class141()
	{
		Strings.CreateGetStringDelegate(typeof(Class141));
	}
}
