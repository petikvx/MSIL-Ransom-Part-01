using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;

public static class GClass19
{
	private struct Struct9
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;
	}

	private struct Struct10
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public Struct9 struct9_0;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct Struct11
	{
		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public byte byte_0;

		[FieldOffset(5)]
		public byte byte_1;

		[FieldOffset(6)]
		public byte byte_2;

		[FieldOffset(7)]
		public byte byte_3;

		[FieldOffset(8)]
		public byte byte_4;

		[FieldOffset(9)]
		public byte byte_5;

		[FieldOffset(10)]
		public byte byte_6;

		[FieldOffset(11)]
		public byte byte_7;

		[FieldOffset(12)]
		public uint uint_1;
	}

	private enum Enum1
	{
		const_0 = 32771,
		const_1
	}

	private enum Enum2
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4
	}

	[CompilerGenerated]
	private sealed class Class23
	{
		public string string_0;

		internal static Class23 L39Nq6gGbidRZA4vA8S;

		internal bool method_0(string value)
		{
			return true;
		}

		static Class23()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}

		internal static void CrgMiLgWbv9AKlHtD2i()
		{
		}

		internal static bool A8fobvg5sr9O5KHbu7v()
		{
			return true;
		}

		internal static Class23 nbykw0gJOHv4ifmuMHZ()
		{
			return null;
		}

		internal static bool RSoNmFgHl4r51xF6A0k(object object_0, object object_1)
		{
			return true;
		}
	}

	private static GClass19 CsA4JXgtxfMAsXhqZ5X;

	public static List<GClass56> smethod_0()
	{
		return null;
	}

	public static List<GClass56> smethod_1()
	{
		return null;
	}

	private static T smethod_2<T>(object bytes) where T : struct
	{
		return (T)null;
	}

	private static bool smethod_3(object url, List<string[]> dataList)
	{
		return true;
	}

	private static bool smethod_4(object urlHash)
	{
		return true;
	}

	private static string smethod_5(object wstrURL)
	{
		return null;
	}

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptAcquireContext(out IntPtr phProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptCreateHash(IntPtr hProv, Enum1 algid, IntPtr hKey, uint dwFlags, ref IntPtr phHash);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptHashData(IntPtr hHash, byte[] pbData, int dwDataLen, uint dwFlags);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptDestroyHash(IntPtr hHash);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptGetHashParam(IntPtr hHash, Enum2 dwParam, byte[] pbData, ref uint pdwDataLen, uint dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);

	static GClass19()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		upGUj8g6B42P3b8EwBE();
	}

	internal static object fNqkfNgogZbxiGljBP4(int int_0)
	{
		return null;
	}

	internal static object LWExF9g0y7WNJ2mId6O(object object_0)
	{
		return null;
	}

	internal static bool YwSRtpgCOhbPjth3Nqy()
	{
		return true;
	}

	internal static GClass19 jiSTgrgxP9NIhGi0f0B()
	{
		return null;
	}

	internal static int GFGYgOg1k7JIwtLWSMs()
	{
		return 0;
	}

	internal static object MytEXpgIog6y8PkSxxk(object object_0, object object_1)
	{
		return null;
	}

	internal static int cBwfcggKXHdEuZlpBOa(object object_0)
	{
		return 0;
	}

	internal static void LHLGmugOPZ6a0vApwFM(object object_0, int int_0)
	{
	}

	internal static object RtonVcgYUi6sQ0fahgT(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static void upGUj8g6B42P3b8EwBE()
	{
	}
}
