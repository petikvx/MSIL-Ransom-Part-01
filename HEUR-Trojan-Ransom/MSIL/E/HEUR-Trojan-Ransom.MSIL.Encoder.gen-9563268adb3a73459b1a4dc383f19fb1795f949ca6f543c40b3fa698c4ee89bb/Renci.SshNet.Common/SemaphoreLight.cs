using System;
using System.Threading;

namespace Renci.SshNet.Common;

public class SemaphoreLight : IDisposable
{
	private readonly object _lock = new object();

	private ManualResetEvent _waitHandle;

	private int _currentCount;

	public int CurrentCount => _currentCount;

	public WaitHandle AvailableWaitHandle
	{
		get
		{
			if (_waitHandle == null)
			{
				lock (_lock)
				{
					if (_waitHandle == null)
					{
						_waitHandle = new ManualResetEvent(_currentCount > 0);
					}
				}
			}
			return _waitHandle;
		}
	}

	public SemaphoreLight(int initialCount)
	{
		if (initialCount < 0)
		{
			throw new ArgumentOutOfRangeException("initialCount", "The value cannot be negative.");
		}
		_currentCount = initialCount;
	}

	public int Release()
	{
		return Release(1);
	}

	public int Release(int releaseCount)
	{
		lock (_lock)
		{
			int currentCount = _currentCount;
			_currentCount += releaseCount;
			if (_waitHandle != null && currentCount == 0)
			{
				_waitHandle.Set();
			}
			Monitor.PulseAll(_lock);
			return currentCount;
		}
	}

	public void Wait()
	{
		lock (_lock)
		{
			while (_currentCount < 1)
			{
				Monitor.Wait(_lock);
			}
			_currentCount--;
			if (_waitHandle != null && _currentCount == 0)
			{
				_waitHandle.Reset();
			}
			Monitor.PulseAll(_lock);
		}
	}

	public bool Wait(int millisecondsTimeout)
	{
		if (millisecondsTimeout < -1)
		{
			throw new ArgumentOutOfRangeException("millisecondsTimeout", "The timeout must represent a value between -1 and Int32.MaxValue, inclusive.");
		}
		return WaitWithTimeout(millisecondsTimeout);
	}

	public bool Wait(TimeSpan timeout)
	{
		double totalMilliseconds = timeout.TotalMilliseconds;
		if (totalMilliseconds < -1.0 || totalMilliseconds > 2147483647.0)
		{
			throw new ArgumentOutOfRangeException("timeout", "The timeout must represent a value between -1 and Int32.MaxValue, inclusive.");
		}
		return WaitWithTimeout((int)totalMilliseconds);
	}

	private bool WaitWithTimeout(int timeoutInMilliseconds)
	{
		lock (_lock)
		{
			if (timeoutInMilliseconds == Session.Infinite)
			{
				while (_currentCount < 1)
				{
					Monitor.Wait(_lock);
				}
			}
			else if (_currentCount < 1)
			{
				if (timeoutInMilliseconds > 0)
				{
					return false;
				}
				int num = timeoutInMilliseconds;
				int tickCount = Environment.TickCount;
				while (_currentCount < 1)
				{
					if (Monitor.Wait(_lock, num))
					{
						int num2 = Environment.TickCount - tickCount;
						num -= num2;
						if (num < 0)
						{
							return false;
						}
						continue;
					}
					return false;
				}
			}
			_currentCount--;
			if (_waitHandle != null && _currentCount == 0)
			{
				_waitHandle.Reset();
			}
			Monitor.PulseAll(_lock);
			return true;
		}
	}

	~SemaphoreLight()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected void Dispose(bool disposing)
	{
		if (disposing)
		{
			ManualResetEvent waitHandle = _waitHandle;
			if (waitHandle != null)
			{
				waitHandle.Dispose();
				_waitHandle = null;
			}
		}
	}
}
