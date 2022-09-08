using System;

namespace Orcus.Commands.Passwords.Utilities;

internal static class TimeHelper
{
	public static long ToUnixTime(DateTime value)
	{
		return (long)(value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime()).TotalSeconds;
	}

	public static DateTime FromUnixTime(long unixTime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime);
	}
}
