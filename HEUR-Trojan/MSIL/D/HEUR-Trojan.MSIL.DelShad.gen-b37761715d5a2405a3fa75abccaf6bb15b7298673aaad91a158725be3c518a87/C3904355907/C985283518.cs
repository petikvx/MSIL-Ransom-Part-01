using System;
using System.Globalization;
using System.Security.Cryptography;
using C3554254475;

namespace C3904355907;

public static class C985283518
{
	private static readonly uint[] m_C3554254475 = new uint[9] { 1u, 10u, 100u, 1000u, 10000u, 100000u, 1000000u, 10000000u, 100000000u };

	private static readonly uint[] C3904355907 = new uint[10] { 0u, 2u, 4u, 6u, 8u, 1u, 3u, 5u, 7u, 9u };

	public static string C3554254475(byte[] byte_0, ulong ulong_0, uint uint_0, bool bool_0, int int_0)
	{
		byte[] array = global::C3554254475.C2137352139.C3554254475(ulong_0);
		Array.Reverse((Array)array);
		byte[] array2;
		using (HMACSHA1 hMACSHA = new HMACSHA1(byte_0))
		{
			array2 = hMACSHA.ComputeHash(array);
		}
		uint num = array2[^1] & 0xFu;
		if (int_0 >= 0 && int_0 < array2.Length - 4)
		{
			num = (uint)int_0;
		}
		uint num2 = (uint)(((array2[num] & 0x7F) << 24) | ((array2[num + 1] & 0xFF) << 16) | ((array2[num + 2] & 0xFF) << 8)) | (array2[num + 3] & 0xFFu);
		uint num3 = num2 % C985283518.m_C3554254475[uint_0];
		if (bool_0)
		{
			num3 = num3 * 10 + C3554254475(num3, uint_0);
		}
		uint totalWidth = (bool_0 ? (uint_0 + 1) : uint_0);
		return num3.ToString(NumberFormatInfo.InvariantInfo).PadLeft((int)totalWidth, '0');
	}

	private static uint C3554254475(uint uint_0, uint uint_1)
	{
		bool flag = true;
		uint num = 0u;
		while (0 < uint_1--)
		{
			uint num2 = uint_0 % 10u;
			uint_0 /= 10u;
			if (flag)
			{
				num2 = C3904355907[num2];
			}
			num += num2;
			flag = !flag;
		}
		uint num3 = num % 10u;
		if (num3 != 0)
		{
			num3 = 10 - num3;
		}
		return num3;
	}
}
