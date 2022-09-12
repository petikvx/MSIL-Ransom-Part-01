using System;

namespace Org.BouncyCastle.Utilities.Date;

public class DateTimeUtilities
{
	public static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1);

	private DateTimeUtilities()
	{
	}

	public static long DateTimeToUnixMs(DateTime dateTime)
	{
		if (dateTime.CompareTo((object?)UnixEpoch) < 0)
		{
			throw new ArgumentException("DateTime value may not be before the epoch", "dateTime");
		}
		long ticks = dateTime.Ticks;
		DateTime unixEpoch = UnixEpoch;
		return (ticks - unixEpoch.Ticks) / 10000L;
	}

	public static DateTime UnixMsToDateTime(long unixMs)
	{
		long num = unixMs * 10000L;
		DateTime unixEpoch = UnixEpoch;
		return new DateTime(num + unixEpoch.Ticks);
	}

	public static long CurrentUnixMs()
	{
		return DateTimeToUnixMs(DateTime.UtcNow);
	}
}
