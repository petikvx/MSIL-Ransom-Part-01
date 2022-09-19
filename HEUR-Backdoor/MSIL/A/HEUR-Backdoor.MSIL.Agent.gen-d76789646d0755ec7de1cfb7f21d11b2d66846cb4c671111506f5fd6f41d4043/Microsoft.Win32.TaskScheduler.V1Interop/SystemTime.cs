using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.TaskScheduler.V1Interop;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
internal struct SystemTime
{
	public ushort Year;

	public ushort Month;

	public ushort DayOfWeek;

	public ushort Day;

	public ushort Hour;

	public ushort Minute;

	public ushort Second;

	public ushort Milliseconds;

	public static readonly SystemTime MinValue;

	public static readonly SystemTime MaxValue;

	public SystemTime(DateTime dt)
	{
		dt = dt.ToLocalTime();
		Year = Convert.ToUInt16(dt.Year);
		Month = Convert.ToUInt16(dt.Month);
		DayOfWeek = Convert.ToUInt16(dt.DayOfWeek);
		Day = Convert.ToUInt16(dt.Day);
		Hour = Convert.ToUInt16(dt.Hour);
		Minute = Convert.ToUInt16(dt.Minute);
		Second = Convert.ToUInt16(dt.Second);
		Milliseconds = Convert.ToUInt16(dt.Millisecond);
	}

	public SystemTime(ushort year, ushort month, ushort day, ushort hour = 0, ushort minute = 0, ushort second = 0, ushort millisecond = 0)
	{
		Year = year;
		Month = month;
		Day = day;
		Hour = hour;
		Minute = minute;
		Second = second;
		Milliseconds = millisecond;
		DayOfWeek = 0;
	}

	public static implicit operator DateTime(SystemTime st)
	{
		if (st.Year != 0 && !(st == MinValue))
		{
			if (st == MaxValue)
			{
				return DateTime.MaxValue;
			}
			return new DateTime(st.Year, st.Month, st.Day, st.Hour, st.Minute, st.Second, st.Milliseconds, DateTimeKind.Local);
		}
		return DateTime.MinValue;
	}

	public static bool operator ==(SystemTime s1, SystemTime s2)
	{
		if (s1.Year == s2.Year && s1.Month == s2.Month && s1.Day == s2.Day && s1.Hour == s2.Hour && s1.Minute == s2.Minute && s1.Second == s2.Second)
		{
			return s1.Milliseconds == s2.Milliseconds;
		}
		return false;
	}

	public static bool operator !=(SystemTime s1, SystemTime s2)
	{
		return !(s1 == s2);
	}

	static SystemTime()
	{
		MinValue = new SystemTime(1601, 1, 1, 0, 0, 0, 0);
		MaxValue = new SystemTime(30827, 12, 31, 23, 59, 59, 999);
	}

	public override bool Equals(object obj)
	{
		if (obj is SystemTime)
		{
			return (SystemTime)obj == this;
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public override string ToString()
	{
		return ((DateTime)this).ToString();
	}
}
