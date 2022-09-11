using System;

namespace DevDefined.OAuth.Framework;

public static class DateTimeUtility
{
	public static long Epoch(this DateTime d)
	{
		return (long)(d.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds;
	}

	public static DateTime FromEpoch(long epoch)
	{
		return new DateTime(1970, 1, 1).AddSeconds(epoch).ToLocalTime();
	}
}
