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

		internal static Class23 E2VRiygH0iDxsjvwLNd;

		internal bool method_0(string value)
		{
			return true;
		}

		static Class23()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			dTv3NPgVF54onlXQCly();
		}

		internal static void Y8J5rCg1b4liS83pVZu()
		{
		}

		internal static bool Bcyx7pgvoh57lJxIHWG()
		{
			return true;
		}

		internal static Class23 aDQgj4gP0vFBh1JatAS()
		{
			return null;
		}

		internal static bool PKYIJpgpKrqF1vdKl9t(object object_0, object object_1)
		{
			return true;
		}

		internal static void dTv3NPgVF54onlXQCly()
		{
		}
	}

	private static GClass19 wmIrahl6AuovsDeHOQL;

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
		L4Hs0Mldwt51mAMbG6o();
	}

	internal static object r52W00lqVqlkFACkgG5(int int_0)
	{
		return null;
	}

	internal static object gXPcs6lNdrI7IhBXvmw(RegistryHive hive, object object_0)
	{
		return null;
	}

	internal static void wGtLeplZBkXHY5kqBsb(object object_0)
	{
	}

	internal static bool fQ4tAclmSqNHJaiG3tR()
	{
		return true;
	}

	internal static GClass19 iOBYRilJviKlYC3gdS4()
	{
		return null;
	}

	internal static int wEtu1Gl3mgHsD4lxOUs()
	{
		return 0;
	}

	internal static object gGJO9ylrmuZ7Cs1AodD()
	{
		return null;
	}

	internal static int uG6UCBleL7iOQdeyvrM(object object_0)
	{
		return 0;
	}

	internal static void NVH4WylO0AaSNmkab5h(object object_0, int int_0)
	{
	}

	internal static object dkfV4al0PNssuBN2GBM(object object_0, object object_1, object object_2)
	{
		return null;
	}

	internal static void L4Hs0Mldwt51mAMbG6o()
	{
	}
}
