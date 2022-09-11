using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Utils;

public static class ByteArrayExtensions
{
	[NonSerialized]
	internal static GetString _0012;

	public static bool IsEntirelyNull(byte[] buffer)
	{
		for (int i = 0; i < buffer.Length; i++)
		{
			if (buffer[i] != 0)
			{
				return false;
			}
		}
		return true;
	}

	public static string DescribeAsHex(byte[] buffer, string separator, int bytesPerLine)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (byte b in buffer)
		{
			stringBuilder.AppendFormat(_0012(107414462), b, separator);
			if (++num % bytesPerLine == 0)
			{
				stringBuilder.Append(_0012(107414449));
			}
		}
		stringBuilder.Append(_0012(107414449));
		return stringBuilder.ToString();
	}

	public static string DecodeAsString(byte[] buffer, int offset, int length, Encoding encoding)
	{
		for (int i = 0; i < length; i++)
		{
			if (buffer[offset + i] == 0)
			{
				length = i;
			}
		}
		return encoding.GetString(buffer, offset, length);
	}

	public static byte[] Concat(params byte[][] byteArrays)
	{
		int num = 0;
		byte[][] array = byteArrays;
		foreach (byte[] array2 in array)
		{
			num += array2.Length;
		}
		if (num <= 0)
		{
			return new byte[0];
		}
		byte[] array3 = new byte[num];
		int num2 = 0;
		array = byteArrays;
		foreach (byte[] array4 in array)
		{
			Array.Copy(array4, 0, array3, num2, array4.Length);
			num2 += array4.Length;
		}
		return array3;
	}

	static ByteArrayExtensions()
	{
		Strings.CreateGetStringDelegate(typeof(ByteArrayExtensions));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0012(107399056), _0012(107399019)), _0012(107399014), _0012(107399009)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0012(107399036)))
		{
			return;
		}
		throw new SecurityException(_0012(107398979));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
