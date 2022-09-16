using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using dg3ypDAonQcOidMs0w;

public class GClass20
{
	[Flags]
	public enum GEnum4 : uint
	{
		flag_0 = 0x8000000u,
		flag_1 = 0x1000u,
		flag_2 = 0x4000000u,
		flag_3 = 0x20000000u,
		flag_4 = 0x40000000u,
		flag_5 = 0x10000000u
	}

	public struct GStruct1
	{
		public short short_0;

		public short short_1;

		public short short_2;

		public short short_3;

		public short short_4;

		public short short_5;

		public short short_6;

		public short short_7;
	}

	public const uint uint_0 = 131072u;

	public const uint uint_1 = 2048u;

	public const uint uint_2 = 8u;

	public const uint uint_3 = 512u;

	public const uint uint_4 = 16u;

	public const uint uint_5 = 16384u;

	public const uint uint_6 = 8192u;

	public const uint uint_7 = 16384u;

	public const uint uint_8 = 1u;

	public const uint uint_9 = 0u;

	public const uint uint_10 = 1u;

	public const uint uint_11 = 256u;

	public const uint uint_12 = 0u;

	public const uint uint_13 = 4u;

	public const uint uint_14 = 1u;

	public const uint uint_15 = 1024u;

	public const uint uint_16 = 4096u;

	private static GClass20 z6E0mBgoVdCNVOhLph8;

	[DllImport("shlwapi.dll")]
	public static extern int UrlCanonicalize(string pszUrl, StringBuilder pszCanonicalized, ref int pcchCanonicalized, GEnum4 dwFlags);

	public static string smethod_0(string pszUrl, GEnum4 dwFlags)
	{
		return null;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool FileTimeToSystemTime(ref FILETIME FileTime, ref GStruct1 SystemTime);

	public static DateTime smethod_1(FILETIME filetime)
	{
		return (DateTime)(object)null;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool SystemTimeToFileTime([In] ref GStruct1 lpSystemTime, out FILETIME lpFileTime);

	public static FILETIME smethod_2(DateTime datetime)
	{
		return (FILETIME)(object)null;
	}

	[DllImport("kernel32.dll")]
	public static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);

	[DllImport("shell32.dll")]
	public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref GStruct2 psfi, uint cbSizeFileInfo, uint uFlags);

	static GClass20()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		vPldXsgBJ7XAyKdD5wJ();
	}

	internal static int YgaPNZgssnkNUbVHXcD(object object_0)
	{
		return 0;
	}

	internal static void eiSX4QgipfgKDru71cY(object object_0, int int_0)
	{
	}

	internal static bool G8xQNhgfODJ4XrHF1ZX()
	{
		return true;
	}

	internal static GClass20 kkgxqsgTH3eZKhegtrZ()
	{
		return null;
	}

	internal static DateTime qPIS05gInktJXNxl8o5()
	{
		return (DateTime)(object)null;
	}

	internal static void tJciJfgKfKWKKjcXsHi()
	{
	}

	internal static void hcgEVWgbWym4gBlt3K1()
	{
	}

	internal static void vPldXsgBJ7XAyKdD5wJ()
	{
	}
}
