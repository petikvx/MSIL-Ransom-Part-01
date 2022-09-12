using System;

namespace InstagramApiSharp.Helpers;

public static class DateTimeHelper
{
	private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public static double GetUnixTimestampMilliseconds(DateTime dt)
	{
		return (dt - UnixEpoch).TotalMilliseconds;
	}

	public static DateTime UnixTimestampToDateTime(double unixTime)
	{
		try
		{
			return ((long)unixTime).FromUnixTimeSeconds();
		}
		catch
		{
		}
		return DateTime.Now;
	}

	public static DateTime UnixTimestampToDateTime(string unixTime)
	{
		if (unixTime.Length <= 10)
		{
			return ((long)Convert.ToDouble(unixTime)).FromUnixTimeSeconds();
		}
		return UnixTimestampMilisecondsToDateTime(unixTime);
	}

	public static DateTime UnixTimestampMilisecondsToDateTime(string unixTime)
	{
		try
		{
			return ((long)Convert.ToDouble(unixTime) / 1000000L).FromUnixTimeSeconds();
		}
		catch
		{
		}
		return DateTime.Now;
	}

	public static DateTime FromUnixTimeSeconds(this long unixTime)
	{
		try
		{
			DateTime unixEpoch = UnixEpoch;
			return unixEpoch.AddSeconds(unixTime);
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static DateTime FromUnixTimeMiliSeconds(this long unixTime)
	{
		try
		{
			DateTime unixEpoch = UnixEpoch;
			return unixEpoch.AddMilliseconds(unixTime);
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static long ToUnixTime(this DateTime date)
	{
		try
		{
			return Convert.ToInt64((date - UnixEpoch).TotalSeconds);
		}
		catch
		{
			return 0L;
		}
	}

	public static long ToUnixTimeMiliSeconds(this DateTime date)
	{
		try
		{
			return Convert.ToInt64((date - UnixEpoch).TotalMilliseconds);
		}
		catch
		{
			return 0L;
		}
	}

	public static long GetUnixTimestampSeconds()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}
}
