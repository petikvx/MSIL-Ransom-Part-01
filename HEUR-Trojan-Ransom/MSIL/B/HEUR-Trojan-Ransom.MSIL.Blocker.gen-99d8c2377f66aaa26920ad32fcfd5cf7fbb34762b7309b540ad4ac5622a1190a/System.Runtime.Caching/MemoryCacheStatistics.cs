using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.Caching.Configuration;
using System.Security;
using System.Threading;

namespace System.Runtime.Caching;

internal sealed class MemoryCacheStatistics : IDisposable
{
	private const int MEMORYSTATUS_INTERVAL_5_SECONDS = 5000;

	private const int MEMORYSTATUS_INTERVAL_30_SECONDS = 30000;

	private int _configCacheMemoryLimitMegabytes;

	private int _configPhysicalMemoryLimitPercentage;

	private int _configPollingInterval;

	private int _inCacheManagerThread;

	private int _disposed;

	private long _lastTrimCount;

	private long _lastTrimDurationTicks;

	private int _lastTrimGen2Count;

	private int _lastTrimPercent;

	private DateTime _lastTrimTime;

	private int _pollingInterval;

	private GCHandleRef<Timer> _timerHandleRef;

	private object _timerLock;

	private long _totalCountBeforeTrim;

	private CacheMemoryMonitor _cacheMemoryMonitor;

	private MemoryCache _memoryCache;

	private PhysicalMemoryMonitor _physicalMemoryMonitor;

	internal long CacheMemoryLimit => _cacheMemoryMonitor.MemoryLimit;

	internal long PhysicalMemoryLimit => _physicalMemoryMonitor.MemoryLimit;

	internal TimeSpan PollingInterval => TimeSpan.FromMilliseconds(_configPollingInterval);

	private MemoryCacheStatistics()
	{
	}

	private void AdjustTimer()
	{
		lock (_timerLock)
		{
			if (_timerHandleRef == null)
			{
				return;
			}
			Timer target = _timerHandleRef.Target;
			if (!_physicalMemoryMonitor.IsAboveHighPressure() && !_cacheMemoryMonitor.IsAboveHighPressure())
			{
				if (_cacheMemoryMonitor.PressureLast <= _cacheMemoryMonitor.PressureLow / 2 && _physicalMemoryMonitor.PressureLast <= _physicalMemoryMonitor.PressureLow / 2)
				{
					if (_pollingInterval != _configPollingInterval)
					{
						_pollingInterval = _configPollingInterval;
						target.Change(_pollingInterval, _pollingInterval);
					}
					return;
				}
				int num = Math.Min(_configPollingInterval, 30000);
				if (_pollingInterval != num)
				{
					_pollingInterval = num;
					target.Change(_pollingInterval, _pollingInterval);
				}
			}
			else if (_pollingInterval > 5000)
			{
				_pollingInterval = 5000;
				target.Change(_pollingInterval, _pollingInterval);
			}
		}
	}

	private void CacheManagerTimerCallback(object state)
	{
		CacheManagerThread(0);
	}

	internal long GetLastSize()
	{
		return _cacheMemoryMonitor.PressureLast;
	}

	private int GetPercentToTrim()
	{
		int num = GC.CollectionCount(2);
		if (num != _lastTrimGen2Count)
		{
			return Math.Max(_physicalMemoryMonitor.GetPercentToTrim(_lastTrimTime, _lastTrimPercent), _cacheMemoryMonitor.GetPercentToTrim(_lastTrimTime, _lastTrimPercent));
		}
		return 0;
	}

	private void InitializeConfiguration(NameValueCollection config)
	{
		MemoryCacheElement memoryCacheElement = null;
		if (!_memoryCache.ConfigLess && ConfigurationManager.GetSection("system.runtime.caching/memoryCache") is MemoryCacheSection memoryCacheSection)
		{
			memoryCacheElement = memoryCacheSection.NamedCaches[_memoryCache.Name];
		}
		if (memoryCacheElement != null)
		{
			_configCacheMemoryLimitMegabytes = memoryCacheElement.CacheMemoryLimitMegabytes;
			_configPhysicalMemoryLimitPercentage = memoryCacheElement.PhysicalMemoryLimitPercentage;
			double totalMilliseconds = memoryCacheElement.PollingInterval.TotalMilliseconds;
			_configPollingInterval = ((totalMilliseconds < 2147483647.0) ? ((int)totalMilliseconds) : int.MaxValue);
		}
		else
		{
			_configPollingInterval = 120000;
			_configCacheMemoryLimitMegabytes = 0;
			_configPhysicalMemoryLimitPercentage = 0;
		}
		if (config != null)
		{
			_configPollingInterval = ConfigUtil.GetIntValueFromTimeSpan(config, "pollingInterval", _configPollingInterval);
			_configCacheMemoryLimitMegabytes = ConfigUtil.GetIntValue(config, "cacheMemoryLimitMegabytes", _configCacheMemoryLimitMegabytes, zeroAllowed: true, int.MaxValue);
			_configPhysicalMemoryLimitPercentage = ConfigUtil.GetIntValue(config, "physicalMemoryLimitPercentage", _configPhysicalMemoryLimitPercentage, zeroAllowed: true, 100);
		}
	}

	private void InitDisposableMembers()
	{
		bool flag = true;
		try
		{
			_cacheMemoryMonitor = new CacheMemoryMonitor(_memoryCache, _configCacheMemoryLimitMegabytes);
			Timer t = new Timer(CacheManagerTimerCallback, null, _configPollingInterval, _configPollingInterval);
			_timerHandleRef = new GCHandleRef<Timer>(t);
			flag = false;
		}
		finally
		{
			if (flag)
			{
				Dispose();
			}
		}
	}

	private void SetTrimStats(long trimDurationTicks, long totalCountBeforeTrim, long trimCount)
	{
		_lastTrimDurationTicks = trimDurationTicks;
		int num = GC.CollectionCount(2);
		if (num != _lastTrimGen2Count)
		{
			_lastTrimTime = DateTime.UtcNow;
			_totalCountBeforeTrim = totalCountBeforeTrim;
			_lastTrimCount = trimCount;
		}
		else
		{
			_lastTrimCount += trimCount;
		}
		_lastTrimGen2Count = num;
		_lastTrimPercent = (int)(_lastTrimCount * 100L / _totalCountBeforeTrim);
	}

	private void Update()
	{
		_physicalMemoryMonitor.Update();
		_cacheMemoryMonitor.Update();
	}

	internal MemoryCacheStatistics(MemoryCache memoryCache, NameValueCollection config)
	{
		_memoryCache = memoryCache;
		_lastTrimGen2Count = -1;
		_lastTrimTime = DateTime.MinValue;
		_timerLock = new object();
		InitializeConfiguration(config);
		_pollingInterval = _configPollingInterval;
		_physicalMemoryMonitor = new PhysicalMemoryMonitor(_configPhysicalMemoryLimitPercentage);
		InitDisposableMembers();
	}

	[SecuritySafeCritical]
	internal long CacheManagerThread(int minPercent)
	{
		if (Interlocked.Exchange(ref _inCacheManagerThread, 1) != 0)
		{
			return 0L;
		}
		try
		{
			if (_disposed == 1)
			{
				return 0L;
			}
			Update();
			AdjustTimer();
			int num = Math.Max(minPercent, GetPercentToTrim());
			long count = _memoryCache.GetCount();
			Stopwatch stopwatch = Stopwatch.StartNew();
			long num2 = _memoryCache.Trim(num);
			stopwatch.Stop();
			if (num > 0 && num2 > 0L)
			{
				SetTrimStats(stopwatch.Elapsed.Ticks, count, num2);
			}
			return num2;
		}
		finally
		{
			Interlocked.Exchange(ref _inCacheManagerThread, 0);
		}
	}

	public void Dispose()
	{
		if (Interlocked.Exchange(ref _disposed, 1) != 0)
		{
			return;
		}
		lock (_timerLock)
		{
			GCHandleRef<Timer> timerHandleRef = _timerHandleRef;
			if (timerHandleRef != null && Interlocked.CompareExchange(ref _timerHandleRef, null, timerHandleRef) == timerHandleRef)
			{
				timerHandleRef.Dispose();
			}
		}
		while (_inCacheManagerThread != 0)
		{
			Thread.Sleep(100);
		}
		if (_cacheMemoryMonitor != null)
		{
			_cacheMemoryMonitor.Dispose();
		}
	}

	internal void UpdateConfig(NameValueCollection config)
	{
		int intValueFromTimeSpan = ConfigUtil.GetIntValueFromTimeSpan(config, "pollingInterval", _configPollingInterval);
		int intValue = ConfigUtil.GetIntValue(config, "cacheMemoryLimitMegabytes", _configCacheMemoryLimitMegabytes, zeroAllowed: true, int.MaxValue);
		int intValue2 = ConfigUtil.GetIntValue(config, "physicalMemoryLimitPercentage", _configPhysicalMemoryLimitPercentage, zeroAllowed: true, 100);
		if (intValueFromTimeSpan != _configPollingInterval)
		{
			lock (_timerLock)
			{
				_configPollingInterval = intValueFromTimeSpan;
			}
		}
		if (intValue == _configCacheMemoryLimitMegabytes && intValue2 == _configPhysicalMemoryLimitPercentage)
		{
			return;
		}
		try
		{
			try
			{
			}
			finally
			{
				while (Interlocked.Exchange(ref _inCacheManagerThread, 1) != 0)
				{
					Thread.Sleep(100);
				}
			}
			if (_disposed == 0)
			{
				if (intValue != _configCacheMemoryLimitMegabytes)
				{
					_cacheMemoryMonitor.SetLimit(intValue);
					_configCacheMemoryLimitMegabytes = intValue;
				}
				if (intValue2 != _configPhysicalMemoryLimitPercentage)
				{
					_physicalMemoryMonitor.SetLimit(intValue2);
					_configPhysicalMemoryLimitPercentage = intValue2;
				}
			}
		}
		finally
		{
			Interlocked.Exchange(ref _inCacheManagerThread, 0);
		}
	}
}
