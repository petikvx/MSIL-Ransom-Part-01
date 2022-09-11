using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace System.Runtime.Caching;

internal class MemoryCacheEntry : MemoryCacheKey
{
	private class SeldomUsedFields
	{
		internal Collection<ChangeMonitor> _dependencies;

		internal Dictionary<MemoryCacheEntryChangeMonitor, MemoryCacheEntryChangeMonitor> _dependents;

		internal MemoryCache _cache;

		internal Tuple<MemoryCacheStore, MemoryCacheEntry> _updateSentinel;
	}

	private object _value;

	private DateTime _utcCreated;

	private int _state;

	private DateTime _utcAbsExp;

	private TimeSpan _slidingExp;

	private ExpiresEntryRef _expiresEntryRef;

	private byte _expiresBucket;

	private byte _usageBucket;

	private UsageEntryRef _usageEntryRef;

	private DateTime _utcLastUpdateUsage;

	private CacheEntryRemovedCallback _callback;

	private SeldomUsedFields _fields;

	internal object Value => _value;

	internal DateTime UtcAbsExp
	{
		get
		{
			return _utcAbsExp;
		}
		set
		{
			_utcAbsExp = value;
		}
	}

	internal DateTime UtcCreated => _utcCreated;

	internal ExpiresEntryRef ExpiresEntryRef
	{
		get
		{
			return _expiresEntryRef;
		}
		set
		{
			_expiresEntryRef = value;
		}
	}

	internal byte ExpiresBucket
	{
		get
		{
			return _expiresBucket;
		}
		set
		{
			_expiresBucket = value;
		}
	}

	internal TimeSpan SlidingExp => _slidingExp;

	internal EntryState State
	{
		get
		{
			return (EntryState)_state;
		}
		set
		{
			_state = (int)value;
		}
	}

	internal byte UsageBucket => _usageBucket;

	internal UsageEntryRef UsageEntryRef
	{
		get
		{
			return _usageEntryRef;
		}
		set
		{
			_usageEntryRef = value;
		}
	}

	internal DateTime UtcLastUpdateUsage
	{
		get
		{
			return _utcLastUpdateUsage;
		}
		set
		{
			_utcLastUpdateUsage = value;
		}
	}

	internal bool HasExpiration()
	{
		return _utcAbsExp < DateTime.MaxValue;
	}

	internal bool InExpires()
	{
		return !_expiresEntryRef.IsInvalid;
	}

	internal MemoryCacheEntry(string key, object value, DateTimeOffset absExp, TimeSpan slidingExp, CacheItemPriority priority, Collection<ChangeMonitor> dependencies, CacheEntryRemovedCallback removedCallback, MemoryCache cache)
		: base(key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		_utcCreated = DateTime.UtcNow;
		_value = value;
		_slidingExp = slidingExp;
		if (_slidingExp > TimeSpan.Zero)
		{
			_utcAbsExp = _utcCreated + _slidingExp;
		}
		else
		{
			_utcAbsExp = absExp.UtcDateTime;
		}
		_expiresEntryRef = ExpiresEntryRef.INVALID;
		_expiresBucket = byte.MaxValue;
		_usageEntryRef = UsageEntryRef.INVALID;
		if (priority == CacheItemPriority.NotRemovable)
		{
			_usageBucket = byte.MaxValue;
		}
		else
		{
			_usageBucket = 0;
		}
		_callback = removedCallback;
		if (dependencies != null)
		{
			_fields = new SeldomUsedFields();
			_fields._dependencies = dependencies;
			_fields._cache = cache;
		}
	}

	internal void AddDependent(MemoryCache cache, MemoryCacheEntryChangeMonitor dependent)
	{
		lock (this)
		{
			if ((int)State <= 2)
			{
				if (_fields == null)
				{
					_fields = new SeldomUsedFields();
				}
				if (_fields._cache == null)
				{
					_fields._cache = cache;
				}
				if (_fields._dependents == null)
				{
					_fields._dependents = new Dictionary<MemoryCacheEntryChangeMonitor, MemoryCacheEntryChangeMonitor>();
				}
				_fields._dependents[dependent] = dependent;
			}
		}
	}

	private void CallCacheEntryRemovedCallback(MemoryCache cache, CacheEntryRemovedReason reason)
	{
		if (_callback == null)
		{
			return;
		}
		CacheEntryRemovedArguments arguments = new CacheEntryRemovedArguments(cache, reason, new CacheItem(base.Key, _value));
		try
		{
			_callback(arguments);
		}
		catch
		{
		}
	}

	internal void CallNotifyOnChanged()
	{
		if (_fields == null || _fields._dependencies == null)
		{
			return;
		}
		foreach (ChangeMonitor dependency in _fields._dependencies)
		{
			dependency.NotifyOnChanged(OnDependencyChanged);
		}
	}

	internal bool CompareExchangeState(EntryState value, EntryState comparand)
	{
		return Interlocked.CompareExchange(ref _state, (int)value, (int)comparand) == (int)comparand;
	}

	internal void ConfigureUpdateSentinel(MemoryCacheStore sentinelStore, MemoryCacheEntry sentinelEntry)
	{
		lock (this)
		{
			if (_fields == null)
			{
				_fields = new SeldomUsedFields();
			}
			_fields._updateSentinel = Tuple.Create(sentinelStore, sentinelEntry);
		}
	}

	internal bool HasUsage()
	{
		return _usageBucket != byte.MaxValue;
	}

	internal bool InUsage()
	{
		return !_usageEntryRef.IsInvalid;
	}

	private void OnDependencyChanged(object state)
	{
		if (State == EntryState.AddedToCache)
		{
			_fields._cache.RemoveEntry(base.Key, this, CacheEntryRemovedReason.ChangeMonitorChanged);
		}
	}

	internal void Release(MemoryCache cache, CacheEntryRemovedReason reason)
	{
		State = EntryState.Closed;
		Dictionary<MemoryCacheEntryChangeMonitor, MemoryCacheEntryChangeMonitor>.KeyCollection keyCollection = null;
		lock (this)
		{
			if (_fields != null && _fields._dependents != null && _fields._dependents.Count > 0)
			{
				keyCollection = _fields._dependents.Keys;
				_fields._dependents = null;
			}
		}
		if (keyCollection != null)
		{
			foreach (MemoryCacheEntryChangeMonitor item in keyCollection)
			{
				item?.OnCacheEntryReleased();
			}
		}
		CallCacheEntryRemovedCallback(cache, reason);
		if (_fields == null || _fields._dependencies == null)
		{
			return;
		}
		foreach (ChangeMonitor dependency in _fields._dependencies)
		{
			dependency.Dispose();
		}
	}

	internal void RemoveDependent(MemoryCacheEntryChangeMonitor dependent)
	{
		lock (this)
		{
			if (_fields != null && _fields._dependents != null)
			{
				_fields._dependents.Remove(dependent);
			}
		}
	}

	internal void UpdateSlidingExp(DateTime utcNow, CacheExpires expires)
	{
		if (_slidingExp > TimeSpan.Zero)
		{
			DateTime dateTime = utcNow + _slidingExp;
			if (dateTime - _utcAbsExp >= CacheExpires.MIN_UPDATE_DELTA || dateTime < _utcAbsExp)
			{
				expires.UtcUpdate(this, dateTime);
			}
		}
	}

	internal void UpdateSlidingExpForUpdateSentinel()
	{
		SeldomUsedFields fields = _fields;
		if (fields != null)
		{
			Tuple<MemoryCacheStore, MemoryCacheEntry> updateSentinel = fields._updateSentinel;
			if (updateSentinel != null)
			{
				MemoryCacheStore item = updateSentinel.Item1;
				MemoryCacheEntry item2 = updateSentinel.Item2;
				item.UpdateExpAndUsage(item2, updatePerfCounters: false);
			}
		}
	}

	internal void UpdateUsage(DateTime utcNow, CacheUsage usage)
	{
		if (!InUsage() || !(_utcLastUpdateUsage < utcNow - CacheUsage.CORRELATED_REQUEST_TIMEOUT))
		{
			return;
		}
		_utcLastUpdateUsage = utcNow;
		usage.Update(this);
		if (_fields == null || _fields._dependencies == null)
		{
			return;
		}
		foreach (ChangeMonitor dependency in _fields._dependencies)
		{
			if (!(dependency is MemoryCacheEntryChangeMonitor memoryCacheEntryChangeMonitor))
			{
				continue;
			}
			foreach (MemoryCacheEntry dependency2 in memoryCacheEntryChangeMonitor.Dependencies)
			{
				MemoryCacheStore store = dependency2._fields._cache.GetStore(dependency2);
				dependency2.UpdateUsage(utcNow, store.Usage);
			}
		}
	}
}
