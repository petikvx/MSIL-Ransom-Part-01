using System;

namespace Google.Protobuf.WellKnownTypes;

public static class TimeExtensions
{
	public static Timestamp ToTimestamp(this DateTime dateTime)
	{
		return Timestamp.FromDateTime(dateTime);
	}

	public static Timestamp ToTimestamp(this DateTimeOffset dateTimeOffset)
	{
		return Timestamp.FromDateTimeOffset(dateTimeOffset);
	}

	public static Duration ToDuration(this TimeSpan timeSpan)
	{
		return Duration.FromTimeSpan(timeSpan);
	}
}
