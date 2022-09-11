using System;
using DevDefined.OAuth.Framework;
using DevDefined.OAuth.Utility;

namespace DevDefined.OAuth.Provider.Inspectors;

public class TimestampRangeInspector : IContextInspector
{
	private readonly Func<DateTime> _nowFunc;

	private TimeSpan _maxAfterNow;

	private TimeSpan _maxBeforeNow;

	public TimestampRangeInspector(TimeSpan window)
		: this(new TimeSpan(window.Ticks / 2L), new TimeSpan(window.Ticks / 2L))
	{
	}

	public TimestampRangeInspector(TimeSpan maxBeforeNow, TimeSpan maxAfterNow)
		: this(maxBeforeNow, maxAfterNow, () => Clock.Now)
	{
	}

	public TimestampRangeInspector(TimeSpan maxBeforeNow, TimeSpan maxAfterNow, Func<DateTime> nowFunc)
	{
		_maxBeforeNow = maxBeforeNow;
		_maxAfterNow = maxAfterNow;
		_nowFunc = nowFunc;
	}

	public void InspectContext(ProviderPhase phase, IOAuthContext context)
	{
		DateTime dateTime = DateTimeUtility.FromEpoch(Convert.ToInt32(context.Timestamp));
		DateTime dateTime2 = _nowFunc();
		if (dateTime2.Subtract(_maxBeforeNow) > dateTime)
		{
			throw new OAuthException(context, "timestamp_refused", $"The timestamp is to old, it must be at most {_maxBeforeNow.TotalSeconds} seconds before the servers current date and time");
		}
		if (dateTime2.Add(_maxAfterNow) < dateTime)
		{
			throw new OAuthException(context, "timestamp_refused", $"The timestamp is to far in the future, if must be at most {_maxAfterNow.TotalSeconds} seconds after the server current date and time");
		}
	}
}
