using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public static class IEEE
{
	[NonSerialized]
	internal static GetString _0007;

	private static double UnsignedToFloat(ulong u)
	{
		return (double)(long)(u - int.MaxValue - 1) + 2147483648.0;
	}

	private static double ldexp(double x, int exp)
	{
		return x * Math.Pow(2.0, exp);
	}

	private static double frexp(double x, out int exp)
	{
		exp = (int)Math.Floor(Math.Log(x) / Math.Log(2.0)) + 1;
		return 1.0 - (Math.Pow(2.0, exp) - x) / Math.Pow(2.0, exp);
	}

	private static ulong FloatToUnsigned(double f)
	{
		return (ulong)((long)(f - 2147483648.0) + int.MaxValue + 1);
	}

	public static byte[] ConvertToIeeeExtended(double num)
	{
		int num2;
		if (num < 0.0)
		{
			num2 = 32768;
			num *= -1.0;
		}
		else
		{
			num2 = 0;
		}
		ulong num4;
		ulong num5;
		int num3;
		if (num == 0.0)
		{
			num3 = 0;
			num4 = 0uL;
			num5 = 0uL;
		}
		else
		{
			double num6 = frexp(num, out num3);
			if (num3 > 16384 || !(num6 < 1.0))
			{
				num3 = num2 | 0x7FFF;
				num4 = 0uL;
				num5 = 0uL;
			}
			else
			{
				num3 += 16382;
				if (num3 < 0)
				{
					num6 = ldexp(num6, num3);
					num3 = 0;
				}
				num3 |= num2;
				num6 = ldexp(num6, 32);
				double num7 = Math.Floor(num6);
				num4 = FloatToUnsigned(num7);
				num6 = ldexp(num6 - num7, 32);
				num7 = Math.Floor(num6);
				num5 = FloatToUnsigned(num7);
			}
		}
		return new byte[10]
		{
			(byte)(num3 >> 8),
			(byte)num3,
			(byte)(num4 >> 24),
			(byte)(num4 >> 16),
			(byte)(num4 >> 8),
			(byte)num4,
			(byte)(num5 >> 24),
			(byte)(num5 >> 16),
			(byte)(num5 >> 8),
			(byte)num5
		};
	}

	public static double ConvertFromIeeeExtended(byte[] bytes)
	{
		if (bytes.Length != 10)
		{
			throw new Exception(_0007(107414414));
		}
		int num = ((bytes[0] & 0x7F) << 8) | bytes[1];
		uint num2 = (uint)((bytes[2] << 24) | (bytes[3] << 16) | (bytes[4] << 8) | bytes[5]);
		uint num3 = (uint)((bytes[6] << 24) | (bytes[7] << 16) | (bytes[8] << 8) | bytes[9]);
		double num4;
		if (num == 0 && num2 == 0 && num3 == 0)
		{
			num4 = 0.0;
		}
		else if (num == 32767)
		{
			num4 = double.NaN;
		}
		else
		{
			num -= 16383;
			num4 = ldexp(UnsignedToFloat(num2), num -= 31);
			num4 += ldexp(UnsignedToFloat(num3), num -= 32);
		}
		if ((bytes[0] & 0x80) == 128)
		{
			return 0.0 - num4;
		}
		return num4;
	}

	static IEEE()
	{
		Strings.CreateGetStringDelegate(typeof(IEEE));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(global::_0007._007E_0087(global::_0007._007E_0087(_0006._007E_001C(assembly), _0007(107399058), _0007(107399021)), _0007(107399016), _0007(107399011)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0007(107399038)))
		{
			return;
		}
		throw new SecurityException(_0007(107398981));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
