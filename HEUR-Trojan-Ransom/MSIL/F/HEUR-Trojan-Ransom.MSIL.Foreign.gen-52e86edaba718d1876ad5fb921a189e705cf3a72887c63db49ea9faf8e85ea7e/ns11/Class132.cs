using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns11;

internal sealed class Class132
{
	private static uint[] uint_0;

	private static uint[] uint_1;

	private ulong ulong_0;

	private uint[] uint_2;

	private bool bool_0;

	private short short_0;

	private byte[] byte_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class132()
	{
		uint_2 = new uint[5];
		byte_0 = new byte[64];
		method_0();
	}

	public void method_0()
	{
		ulong_0 = 0uL;
		short_0 = 0;
		uint_2[0] = uint_1[0];
		uint_2[1] = uint_1[1];
		uint_2[2] = uint_1[2];
		uint_2[3] = uint_1[3];
		uint_2[4] = uint_1[4];
		bool_0 = false;
	}

	public byte[] method_1(byte[] byte_1)
	{
		method_0();
		method_2(byte_1, 0, byte_1.Length);
		return method_5();
	}

	public void method_2(byte[] byte_1, int int_0, int int_1)
	{
		if (byte_1 == null || int_1 == 0)
		{
			return;
		}
		if (int_0 >= 0 && int_0 <= byte_1.Length - 1)
		{
			if (int_1 < 0)
			{
				throw new ArgumentException(getString_0(107356978), getString_0(107359503));
			}
			if (int_1 + int_0 > byte_1.Length)
			{
				throw new ArgumentException(getString_0(107356941), getString_0(107359503));
			}
			while (int_1-- > 0)
			{
				byte_0[short_0++] = (byte)(byte_1[int_0++] & 0xFFu);
				ulong_0 += 8uL;
				if (short_0 == 64)
				{
					method_3();
				}
			}
			return;
		}
		throw new ArgumentException(getString_0(107357024), getString_0(107356955));
	}

	private void method_3()
	{
		uint[] array = new uint[80];
		for (int i = 0; i < 16; i++)
		{
			int num = i * 4;
			array[i] = (uint)(byte_0[num] << 24);
			array[i] |= (uint)(byte_0[num + 1] << 16);
			array[i] |= (uint)(byte_0[num + 2] << 8);
			array[i] |= byte_0[num + 3];
		}
		for (int j = 16; j < 80; j++)
		{
			array[j] = smethod_0(1, array[j - 3] ^ array[j - 8] ^ array[j - 14] ^ array[j - 16]);
		}
		uint num2 = uint_2[0];
		uint num3 = uint_2[1];
		uint num4 = uint_2[2];
		uint num5 = uint_2[3];
		uint num6 = uint_2[4];
		for (int k = 0; k < 20; k++)
		{
			uint num7 = smethod_0(5, num2) + ((num3 & num4) | (~num3 & num5)) + num6 + array[k] + uint_0[0];
			num6 = num5;
			num5 = num4;
			num4 = smethod_0(30, num3);
			num3 = num2;
			num2 = num7;
		}
		for (int l = 20; l < 40; l++)
		{
			uint num8 = smethod_0(5, num2) + (num3 ^ num4 ^ num5) + num6 + array[l] + uint_0[1];
			num6 = num5;
			num5 = num4;
			num4 = smethod_0(30, num3);
			num3 = num2;
			num2 = num8;
		}
		for (int m = 40; m < 60; m++)
		{
			uint num9 = smethod_0(5, num2) + ((num3 & num4) | (num3 & num5) | (num4 & num5)) + num6 + array[m] + uint_0[2];
			num6 = num5;
			num5 = num4;
			num4 = smethod_0(30, num3);
			num3 = num2;
			num2 = num9;
		}
		for (int n = 60; n < 80; n++)
		{
			uint num10 = smethod_0(5, num2) + (num3 ^ num4 ^ num5) + num6 + array[n] + uint_0[3];
			num6 = num5;
			num5 = num4;
			num4 = smethod_0(30, num3);
			num3 = num2;
			num2 = num10;
		}
		uint_2[0] += num2;
		uint_2[1] += num3;
		uint_2[2] += num4;
		uint_2[3] += num5;
		uint_2[4] += num6;
		short_0 = 0;
	}

	private static uint smethod_0(int int_0, uint uint_3)
	{
		return (uint_3 << int_0) | (uint_3 >> 32 - int_0);
	}

	private void method_4()
	{
		int num = short_0;
		if (num > 55)
		{
			byte_0[num++] = 128;
			Array.Clear(byte_0, num, 64 - num);
			short_0 = 64;
			method_3();
			Array.Clear(byte_0, 0, 56);
			short_0 = 56;
		}
		else
		{
			byte_0[num++] = 128;
			Array.Clear(byte_0, num, 56 - num);
			short_0 = 56;
		}
		byte_0[56] = (byte)(ulong_0 >> 56);
		byte_0[57] = (byte)(ulong_0 >> 48);
		byte_0[58] = (byte)(ulong_0 >> 40);
		byte_0[59] = (byte)(ulong_0 >> 32);
		byte_0[60] = (byte)(ulong_0 >> 24);
		byte_0[61] = (byte)(ulong_0 >> 16);
		byte_0[62] = (byte)(ulong_0 >> 8);
		byte_0[63] = (byte)ulong_0;
		method_3();
	}

	public byte[] method_5()
	{
		if (!bool_0)
		{
			method_4();
			Array.Clear(byte_0, 0, 64);
			ulong_0 = 0uL;
			bool_0 = true;
		}
		byte[] array = new byte[20];
		for (int i = 0; i < 20; i++)
		{
			array[i] = (byte)(uint_2[i >> 2] >> 8 * (3 - (i & 3)));
		}
		return array;
	}

	static Class132()
	{
		Strings.CreateGetStringDelegate(typeof(Class132));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398192), getString_0(107398187)).Replace(getString_0(107398150), getString_0(107398145)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398140)))
		{
			throw new SecurityException(getString_0(107398115));
		}
		uint_0 = new uint[4] { 1518500249u, 1859775393u, 2400959708u, 3395469782u };
		uint_1 = new uint[5] { 1732584193u, 4023233417u, 2562383102u, 271733878u, 3285377520u };
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
