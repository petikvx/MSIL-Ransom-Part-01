using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

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

	[DllImport("shlwapi.dll")]
	public static extern int UrlCanonicalize(string pszUrl, StringBuilder pszCanonicalized, ref int pcchCanonicalized, GEnum4 dwFlags);

	public static string smethod_0(string pszUrl, GEnum4 dwFlags)
	{
		StringBuilder stringBuilder = new StringBuilder(260);
		int pcchCanonicalized = stringBuilder.Capacity;
		if (UrlCanonicalize(pszUrl, stringBuilder, ref pcchCanonicalized, dwFlags) == 0)
		{
			return stringBuilder.ToString();
		}
		stringBuilder.Capacity = pcchCanonicalized;
		UrlCanonicalize(pszUrl, stringBuilder, ref pcchCanonicalized, dwFlags);
		return stringBuilder.ToString();
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool FileTimeToSystemTime(ref FILETIME FileTime, ref GStruct1 SystemTime);

	public static DateTime smethod_1(FILETIME filetime)
	{
		GStruct1 SystemTime = default(GStruct1);
		FileTimeToSystemTime(ref filetime, ref SystemTime);
		try
		{
			return new DateTime(SystemTime.short_7, SystemTime.short_5, SystemTime.short_0, SystemTime.short_2, SystemTime.short_4, SystemTime.short_6, SystemTime.short_3);
		}
		catch (Exception)
		{
			return DateTime.Now;
		}
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool SystemTimeToFileTime([In] ref GStruct1 lpSystemTime, out FILETIME lpFileTime);

	public static FILETIME smethod_2(DateTime datetime)
	{
		GStruct1 lpSystemTime = default(GStruct1);
		lpSystemTime.short_7 = (short)datetime.Year;
		lpSystemTime.short_5 = (short)datetime.Month;
		lpSystemTime.short_0 = (short)datetime.Day;
		lpSystemTime.short_2 = (short)datetime.Hour;
		lpSystemTime.short_4 = (short)datetime.Minute;
		lpSystemTime.short_6 = (short)datetime.Second;
		lpSystemTime.short_3 = (short)datetime.Millisecond;
		SystemTimeToFileTime(ref lpSystemTime, out var lpFileTime);
		return lpFileTime;
	}

	[DllImport("Kernel32.dll")]
	public static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);

	[DllImport("shell32.dll")]
	public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref GStruct2 psfi, uint cbSizeFileInfo, uint uFlags);
}
