using System;

namespace InstagramApiSharp.Classes;

public class RequestDelay : IRequestDelay
{
	private readonly Random _random;

	private readonly int _minSeconds;

	private readonly int _maxSeconds;

	private bool _isEnabled;

	public TimeSpan Value
	{
		get
		{
			if (!Exist)
			{
				return TimeSpan.Zero;
			}
			return TimeSpan.FromSeconds(_random.Next(_minSeconds, _maxSeconds));
		}
	}

	public bool Exist
	{
		get
		{
			if (_isEnabled && _minSeconds != 0)
			{
				return _maxSeconds != 0;
			}
			return false;
		}
	}

	private RequestDelay(int minSeconds, int maxSeconds)
	{
		_minSeconds = minSeconds;
		_maxSeconds = maxSeconds;
		_random = new Random(DateTime.Now.Millisecond);
		_isEnabled = true;
	}

	public static IRequestDelay FromSeconds(int min, int max)
	{
		if (min > max)
		{
			throw new ArgumentException("Value max should be bigger that value min");
		}
		if (max < 0)
		{
			throw new ArgumentException("Both min and max values should be bigger than 0");
		}
		return new RequestDelay(min, max);
	}

	public static IRequestDelay Empty()
	{
		return new RequestDelay(0, 0);
	}

	public void Enable()
	{
		_isEnabled = true;
	}

	public void Disable()
	{
		_isEnabled = false;
	}
}
