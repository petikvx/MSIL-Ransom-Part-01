using System;

namespace MySql.Data.Common;

internal class LowResolutionStopwatch
{
	private long _startTime;

	public static readonly long Frequency = 1000L;

	public static readonly bool IsHighResolution = false;

	public long ElapsedMilliseconds { get; private set; }

	public TimeSpan Elapsed => new TimeSpan(0, 0, 0, 0, (int)ElapsedMilliseconds);

	public LowResolutionStopwatch()
	{
		ElapsedMilliseconds = 0L;
	}

	public void Start()
	{
		_startTime = Environment.TickCount;
	}

	public void Stop()
	{
		long num = Environment.TickCount;
		long num2 = ((num >= _startTime) ? (num - _startTime) : ((num >= 0L) ? (2147483647L - _startTime + num) : (1L + (2147483647L - _startTime) + (num - -2147483648L))));
		ElapsedMilliseconds += num2;
	}

	public void Reset()
	{
		ElapsedMilliseconds = 0L;
		_startTime = 0L;
	}

	public static LowResolutionStopwatch StartNew()
	{
		LowResolutionStopwatch lowResolutionStopwatch = new LowResolutionStopwatch();
		lowResolutionStopwatch.Start();
		return lowResolutionStopwatch;
	}

	public static long GetTimestamp()
	{
		return Environment.TickCount;
	}

	private bool IsRunning()
	{
		return (ulong)_startTime > 0uL;
	}
}
