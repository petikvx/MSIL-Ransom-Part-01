using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;
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

		private static Class23 gQP35XVBtM9QO4oMOZ8;

		internal bool method_0(string value)
		{
			return true;
		}

		static Class23()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}

		internal static void NThUxHVgupyAk53296s()
		{
		}

		internal static bool ark01EVTwuNfFYVGvSK()
		{
			return true;
		}

		internal static Class23 u0AHxsVZIWXxUspVRnd()
		{
			return null;
		}

		internal static bool H2GKmUVFcmDVlyN2Sy1(object object_0, object object_1)
		{
			return true;
		}
	}

	internal static GClass19 v5wBgYWyhtSSgkSio6r;

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
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}

	internal static object TLiZFBWQe15hLjypM4U(RegistryHive hive, object object_0)
	{
		return null;
	}

	internal static void uNynusWzpYhRE4cBaja(object object_0)
	{
	}

	internal static bool HiCNE8WpIiP5AQuk8nJ()
	{
		return true;
	}

	internal static GClass19 eF1n1VW9yHMOvqS8Sly()
	{
		return null;
	}

	internal static int GcsC6ZVlJ9K44XCw7DD()
	{
		return 0;
	}

	internal static object quucaQVqeOEAMqGEOU7(object object_0, object object_1)
	{
		return null;
	}

	internal static int aaP3s4V52EqjUuGTY9y(object object_0)
	{
		return 0;
	}

	internal static object IHavHLVArxMoLWTtwr1(int int_0)
	{
		return null;
	}

	internal static object zB5uwkVMqTgwIOc4FT5(object object_0, object object_1, object object_2)
	{
		return null;
	}
}
