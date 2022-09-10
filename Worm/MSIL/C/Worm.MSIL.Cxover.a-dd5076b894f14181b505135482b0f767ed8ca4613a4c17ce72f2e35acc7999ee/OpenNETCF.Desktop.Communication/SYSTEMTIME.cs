using System;
using System.Runtime.InteropServices;

namespace OpenNETCF.Desktop.Communication;

internal class SYSTEMTIME
{
	protected const int wYearOffset = 0;

	protected const ushort wMonthOffset = 2;

	protected const ushort wDayOfWeekOffset = 4;

	protected const ushort wDayOffset = 6;

	protected const ushort wHourOffset = 8;

	protected const ushort wMinuteOffset = 10;

	protected const ushort wSecondOffset = 12;

	protected const ushort wMillisecondsOffset = 14;

	protected byte[] flatStruct = new byte[16];

	public ushort wYear
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 0);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 0, 2);
		}
	}

	public ushort wMonth
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 2);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 2, 2);
		}
	}

	public ushort wDayOfWeek
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 4);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 4, 2);
		}
	}

	public ushort wDay
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 6);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 6, 2);
		}
	}

	public ushort wHour
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 8);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 8, 2);
		}
	}

	public ushort wMinute
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 10);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 10, 2);
		}
	}

	public ushort wSecond
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 12);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 12, 2);
		}
	}

	public ushort wMilliseconds
	{
		get
		{
			return BitConverter.ToUInt16(flatStruct, 14);
		}
		set
		{
			byte[] bytes = BitConverter.GetBytes(value);
			Buffer.BlockCopy(bytes, 0, flatStruct, 14, 2);
		}
	}

	public SYSTEMTIME(byte[] bytes)
		: this(bytes, 0)
	{
	}

	public SYSTEMTIME(byte[] bytes, int offset)
	{
		Buffer.BlockCopy(bytes, offset, flatStruct, 0, flatStruct.Length);
	}

	public SYSTEMTIME(ushort year, ushort month, ushort day, ushort hour, ushort minute, ushort second)
	{
		wYear = year;
		wMonth = month;
		wDayOfWeek = 0;
		wDay = day;
		wHour = hour;
		wMinute = minute;
		wSecond = second;
		wMilliseconds = 0;
	}

	public byte[] ToByteArray()
	{
		return flatStruct;
	}

	public SYSTEMTIME(DateTime dt)
		: this((ushort)dt.Year, (ushort)dt.Month, (ushort)dt.Day, (ushort)dt.Hour, (ushort)dt.Minute, (ushort)dt.Second)
	{
	}

	public SYSTEMTIME()
		: this(new byte[16])
	{
	}

	public static implicit operator DateTime(SYSTEMTIME st)
	{
		return new DateTime(st.wYear, st.wMonth, st.wDay, st.wHour, st.wMinute, st.wSecond, st.wMilliseconds);
	}

	public static implicit operator SYSTEMTIME(long FileTime)
	{
		byte[] array = new byte[16];
		FileTimeToSystemTime_1(ref FileTime, array);
		return new SYSTEMTIME(array);
	}

	public static implicit operator long(SYSTEMTIME st)
	{
		byte[] array = new byte[16];
		array = st.ToByteArray();
		long lpFileTime = 0L;
		SystemTimeToFileTime_1(array, ref lpFileTime);
		return lpFileTime;
	}

	public SYSTEMTIME FileTimeToSystemTime(long FileTime)
	{
		SYSTEMTIME sYSTEMTIME = new SYSTEMTIME();
		PlatformID platform = Environment.OSVersion.Platform;
		if (platform == PlatformID.WinCE)
		{
			FileTimeToSystemTime_2(ref FileTime, sYSTEMTIME.flatStruct);
		}
		else
		{
			FileTimeToSystemTime_1(ref FileTime, sYSTEMTIME.flatStruct);
		}
		return sYSTEMTIME;
	}

	public long SystemTimeToFileTime(SYSTEMTIME SystemTime)
	{
		long lpFileTime = 0L;
		PlatformID platform = Environment.OSVersion.Platform;
		if (platform == PlatformID.WinCE)
		{
			SystemTimeToFileTime_2(SystemTime.flatStruct, ref lpFileTime);
		}
		else
		{
			SystemTimeToFileTime_1(SystemTime.flatStruct, ref lpFileTime);
		}
		return lpFileTime;
	}

	[DllImport("kernel32.dll", EntryPoint = "FileTimeToSystemTime", SetLastError = true)]
	internal static extern int FileTimeToSystemTime_1(ref long lpFileTime, byte[] lpSystemTime);

	[DllImport("kernel32.dll", EntryPoint = "SystemTimeToFileTime", SetLastError = true)]
	internal static extern int SystemTimeToFileTime_1(byte[] lpSystemTime, ref long lpFileTime);

	[DllImport("coredll.dll", EntryPoint = "FileTimeToSystemTime", SetLastError = true)]
	internal static extern int FileTimeToSystemTime_2(ref long lpFileTime, byte[] lpSystemTime);

	[DllImport("coredll.dll", EntryPoint = "SystemTimeToFileTime", SetLastError = true)]
	internal static extern int SystemTimeToFileTime_2(byte[] lpSystemTime, ref long lpFileTime);

	public static implicit operator byte[](SYSTEMTIME st)
	{
		return st.ToByteArray();
	}
}
