using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Caching.Configuration;
using System.Runtime.Caching.Resources;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Caching;

public class MemoryCache : ObjectCache, IDisposable, IEnumerable
{
	private class SentinelEntry
	{
		private string _key;

		private ChangeMonitor _expensiveObjectDependency;

		private CacheEntryUpdateCallback _updateCallback;

		internal string Key => _key;

		internal ChangeMonitor ExpensiveObjectDependency => _expensiveObjectDependency;

		internal CacheEntryUpdateCallback CacheEntryUpdateCallback => _updateCallback;

		internal SentinelEntry(string key, ChangeMonitor expensiveObjectDependency, CacheEntryUpdateCallback callback)
		{
			_key = key;
			_expensiveObjectDependency = expensiveObjectDependency;
			_updateCallback = callback;
		}

		private static bool IsPolicyValid(CacheItemPolicy policy)
		{
			if (policy == null)
			{
				return false;
			}
			bool flag = false;
			Collection<ChangeMonitor> changeMonitors = policy.ChangeMonitors;
			if (changeMonitors != null)
			{
				foreach (ChangeMonitor item in changeMonitors)
				{
					if (item != null && item.HasChanged)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag && policy.UpdateCallback != null)
			{
				return true;
			}
			if (flag)
			{
				foreach (ChangeMonitor item2 in changeMonitors)
				{
					item2?.Dispose();
				}
			}
			return false;
		}

		internal static void OnCacheEntryRemovedCallback(CacheEntryRemovedArguments arguments)
		{
			MemoryCache memoryCache = arguments.Source as MemoryCache;
			SentinelEntry sentinelEntry = arguments.CacheItem.Value as SentinelEntry;
			CacheEntryRemovedReason removedReason = arguments.RemovedReason;
			switch (removedReason)
			{
			default:
				return;
			case CacheEntryRemovedReason.Evicted:
				return;
			case CacheEntryRemovedReason.ChangeMonitorChanged:
				if (sentinelEntry.ExpensiveObjectDependency.HasChanged)
				{
					return;
				}
				break;
			case CacheEntryRemovedReason.Expired:
				break;
			}
			try
			{
				CacheEntryUpdateArguments cacheEntryUpdateArguments = new CacheEntryUpdateArguments(memoryCache, removedReason, sentinelEntry.Key, null);
				sentinelEntry.CacheEntryUpdateCallback(cacheEntryUpdateArguments);
				object obj = ((cacheEntryUpdateArguments.UpdatedCacheItem != null) ? cacheEntryUpdateArguments.UpdatedCacheItem.Value : null);
				CacheItemPolicy updatedCacheItemPolicy = cacheEntryUpdateArguments.UpdatedCacheItemPolicy;
				if (obj != null && IsPolicyValid(updatedCacheItemPolicy))
				{
					memoryCache.Set(sentinelEntry.Key, obj, updatedCacheItemPolicy);
				}
				else
				{
					memoryCache.Remove(sentinelEntry.Key);
				}
			}
			catch
			{
				memoryCache.Remove(sentinelEntry.Key);
			}
		}
	}

	private const DefaultCacheCapabilities CAPABILITIES = DefaultCacheCapabilities.InMemoryProvider | DefaultCacheCapabilities.CacheEntryChangeMonitors | DefaultCacheCapabilities.AbsoluteExpirations | DefaultCacheCapabilities.SlidingExpirations | DefaultCacheCapabilities.CacheEntryUpdateCallback | DefaultCacheCapabilities.CacheEntryRemovedCallback;

	private static readonly TimeSpan OneYear = new TimeSpan(365, 0, 0, 0);

	private static object s_initLock = new object();

	private static MemoryCache s_defaultCache;

	private static CacheEntryRemovedCallback s_sentinelRemovedCallback = SentinelEntry.OnCacheEntryRemovedCallback;

	private GCHandleRef<MemoryCacheStore>[] _storeRefs;

	private int _storeCount;

	private int _disposed;

	private MemoryCacheStatistics _stats;

	private string _name;

	private PerfCounters _perfCounters;

	private bool _configLess;

	private bool _useMemoryCacheManager = true;

	private EventHandler _onAppDomainUnload;

	private UnhandledExceptionEventHandler _onUnhandledException;

	private bool IsDisposed => _disposed == 1;

	internal bool ConfigLess => _configLess;

	internal object[] AllSRefTargets
	{
		get
		{
			MemoryCacheStore[] array = new MemoryCacheStore[_storeCount];
			for (int i = 0; i < _storeCount; i++)
			{
				array[i] = _storeRefs[i].Target;
			}
			return array;
		}
	}

	public long CacheMemoryLimit => _stats.CacheMemoryLimit;

	public static MemoryCache Default
	{
		get
		{
			if (s_defaultCache == null)
			{
				lock (s_initLock)
				{
					if (s_defaultCache == null)
					{
						s_defaultCache = new MemoryCache();
					}
				}
			}
			return s_defaultCache;
		}
	}

	public override DefaultCacheCapabilities DefaultCacheCapabilities => DefaultCacheCapabilities.InMemoryProvider | DefaultCacheCapabilities.CacheEntryChangeMonitors | DefaultCacheCapabilities.AbsoluteExpirations | DefaultCacheCapabilities.SlidingExpirations | DefaultCacheCapabilities.CacheEntryUpdateCallback | DefaultCacheCapabilities.CacheEntryRemovedCallback;

	public override string Name => _name;

	internal bool UseMemoryCacheManager => _useMemoryCacheManager;

	public long PhysicalMemoryLimit => _stats.PhysicalMemoryLimit;

	public TimeSpan PollingInterval => _stats.PollingInterval;

	public override object this[string key]
	{
		get
		{
			return GetInternal(key, null);
		}
		set
		{
			Set(key, value, ObjectCache.InfiniteAbsoluteExpiration);
		}
	}

	internal MemoryCacheStore GetStore(MemoryCacheKey cacheKey)
	{
		int num = cacheKey.Hash;
		if (num < 0)
		{
			num = ((num != int.MinValue) ? (-num) : 0);
		}
		int num2 = num % _storeCount;
		return _storeRefs[num2].Target;
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private void InitDisposableMembers(NameValueCollection config)
	{
		bool flag = true;
		try
		{
			try
			{
				_perfCounters = new PerfCounters(_name);
			}
			catch
			{
			}
			for (int i = 0; i < _storeCount; i++)
			{
				_storeRefs[i] = new GCHandleRef<MemoryCacheStore>(new MemoryCacheStore(this, _perfCounters));
			}
			_stats = new MemoryCacheStatistics(this, config);
			AppDomain domain = Thread.GetDomain();
			EventHandler eventHandler = OnAppDomainUnload;
			domain.DomainUnload += eventHandler;
			_onAppDomainUnload = eventHandler;
			UnhandledExceptionEventHandler unhandledExceptionEventHandler = OnUnhandledException;
			domain.UnhandledException += unhandledExceptionEventHandler;
			_onUnhandledException = unhandledExceptionEventHandler;
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

	private void OnAppDomainUnload(object sender, EventArgs e)
	{
		Dispose();
	}

	private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.IsTerminating)
		{
			Dispose();
		}
	}

	private void ValidatePolicy(CacheItemPolicy policy)
	{
		if (policy.AbsoluteExpiration != ObjectCache.InfiniteAbsoluteExpiration && policy.SlidingExpiration != ObjectCache.NoSlidingExpiration)
		{
			throw new ArgumentException(R.Invalid_expiration_combination, "policy");
		}
		if (!(policy.SlidingExpiration < ObjectCache.NoSlidingExpiration) && !(OneYear < policy.SlidingExpiration))
		{
			if (policy.RemovedCallback != null && policy.UpdateCallback != null)
			{
				throw new ArgumentException(R.Invalid_callback_combination, "policy");
			}
			if (policy.Priority != 0 && policy.Priority != CacheItemPriority.NotRemovable)
			{
				throw new ArgumentOutOfRangeException("policy", RH.Format(R.Argument_out_of_range, "Priority", CacheItemPriority.Default, CacheItemPriority.NotRemovable));
			}
			return;
		}
		throw new ArgumentOutOfRangeException("policy", RH.Format(R.Argument_out_of_range, "SlidingExpiration", ObjectCache.NoSlidingExpiration, OneYear));
	}

	private MemoryCache()
	{
		_name = "Default";
		Init(null);
	}

	public MemoryCache(string name, NameValueCollection config = null)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name == string.Empty)
		{
			throw new ArgumentException(R.Empty_string_invalid, "name");
		}
		if (string.Equals(name, "default", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(R.Default_is_reserved, "name");
		}
		_name = name;
		Init(config);
	}

	public MemoryCache(string name, NameValueCollection config, bool ignoreConfigSection)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name == string.Empty)
		{
			throw new ArgumentException(R.Empty_string_invalid, "name");
		}
		if (string.Equals(name, "default", StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(R.Default_is_reserved, "name");
		}
		_name = name;
		_configLess = ignoreConfigSection;
		Init(config);
	}

	private void Init(NameValueCollection config)
	{
		_storeCount = Environment.ProcessorCount;
		_storeRefs = new GCHandleRef<MemoryCacheStore>[_storeCount];
		if (config != null)
		{
			_useMemoryCacheManager = ConfigUtil.GetBooleanValue(config, "useMemoryCacheManager", defaultValue: true);
		}
		InitDisposableMembers(config);
	}

	private object AddOrGetExistingInternal(string key, object value, CacheItemPolicy policy)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		DateTimeOffset absExp = ObjectCache.InfiniteAbsoluteExpiration;
		TimeSpan slidingExp = ObjectCache.NoSlidingExpiration;
		CacheItemPriority priority = CacheItemPriority.Default;
		Collection<ChangeMonitor> collection = null;
		CacheEntryRemovedCallback removedCallback = null;
		if (policy != null)
		{
			ValidatePolicy(policy);
			if (policy.UpdateCallback != null)
			{
				throw new ArgumentException(R.Update_callback_must_be_null, "policy");
			}
			absExp = policy.AbsoluteExpiration;
			slidingExp = policy.SlidingExpiration;
			priority = policy.Priority;
			collection = policy.ChangeMonitors;
			removedCallback = policy.RemovedCallback;
		}
		if (IsDisposed)
		{
			if (collection != null)
			{
				foreach (ChangeMonitor item in collection)
				{
					item?.Dispose();
				}
			}
			return null;
		}
		MemoryCacheKey memoryCacheKey = new MemoryCacheKey(key);
		MemoryCacheStore store = GetStore(memoryCacheKey);
		return store.AddOrGetExisting(memoryCacheKey, new MemoryCacheEntry(key, value, absExp, slidingExp, priority, collection, removedCallback, this))?.Value;
	}

	public override CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(IEnumerable<string> keys, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		List<string> list = new List<string>(keys);
		if (list.Count == 0)
		{
			throw new ArgumentException(RH.Format(R.Empty_collection, "keys"));
		}
		foreach (string item in list)
		{
			if (item == null)
			{
				throw new ArgumentException(RH.Format(R.Collection_contains_null_element, "keys"));
			}
		}
		return new MemoryCacheEntryChangeMonitor(list.AsReadOnly(), regionName, this);
	}

	public void Dispose()
	{
		if (Interlocked.Exchange(ref _disposed, 1) != 0)
		{
			return;
		}
		DisposeSafeCritical();
		if (_stats != null)
		{
			_stats.Dispose();
		}
		if (_storeRefs != null)
		{
			GCHandleRef<MemoryCacheStore>[] storeRefs = _storeRefs;
			for (int i = 0; i < storeRefs.Length; i++)
			{
				storeRefs[i]?.Dispose();
			}
		}
		if (_perfCounters != null)
		{
			_perfCounters.Dispose();
		}
		GC.SuppressFinalize(this);
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private void DisposeSafeCritical()
	{
		AppDomain domain = Thread.GetDomain();
		if (_onAppDomainUnload != null)
		{
			domain.DomainUnload -= _onAppDomainUnload;
		}
		if (_onUnhandledException != null)
		{
			domain.UnhandledException -= _onUnhandledException;
		}
	}

	private object GetInternal(string key, string regionName)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return GetEntry(key)?.Value;
	}

	internal MemoryCacheEntry GetEntry(string key)
	{
		if (IsDisposed)
		{
			return null;
		}
		MemoryCacheKey memoryCacheKey = new MemoryCacheKey(key);
		MemoryCacheStore store = GetStore(memoryCacheKey);
		return store.Get(memoryCacheKey);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Hashtable hashtable = new Hashtable();
		if (!IsDisposed)
		{
			GCHandleRef<MemoryCacheStore>[] storeRefs = _storeRefs;
			foreach (GCHandleRef<MemoryCacheStore> gCHandleRef in storeRefs)
			{
				gCHandleRef.Target.CopyTo(hashtable);
			}
		}
		return hashtable.GetEnumerator();
	}

	protected override IEnumerator<KeyValuePair<string, object>> GetEnumerator()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!IsDisposed)
		{
			GCHandleRef<MemoryCacheStore>[] storeRefs = _storeRefs;
			foreach (GCHandleRef<MemoryCacheStore> gCHandleRef in storeRefs)
			{
				gCHandleRef.Target.CopyTo(dictionary);
			}
		}
		return dictionary.GetEnumerator();
	}

	internal MemoryCacheEntry RemoveEntry(string key, MemoryCacheEntry entry, CacheEntryRemovedReason reason)
	{
		MemoryCacheKey memoryCacheKey = new MemoryCacheKey(key);
		MemoryCacheStore store = GetStore(memoryCacheKey);
		return store.Remove(memoryCacheKey, entry, reason);
	}

	public long Trim(int percent)
	{
		if (percent > 100)
		{
			percent = 100;
		}
		long num = 0L;
		if (_disposed == 0)
		{
			GCHandleRef<MemoryCacheStore>[] storeRefs = _storeRefs;
			foreach (GCHandleRef<MemoryCacheStore> gCHandleRef in storeRefs)
			{
				num += gCHandleRef.Target.TrimInternal(percent);
			}
		}
		return num;
	}

	public override bool Contains(string key, string regionName = null)
	{
		return GetInternal(key, regionName) != null;
	}

	public override bool Add(CacheItem item, CacheItemPolicy policy)
	{
		CacheItem cacheItem = AddOrGetExisting(item, policy);
		if (cacheItem != null)
		{
			return cacheItem.Value == null;
		}
		return true;
	}

	public override object AddOrGetExisting(string key, object value, DateTimeOffset absoluteExpiration, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
		cacheItemPolicy.AbsoluteExpiration = absoluteExpiration;
		return AddOrGetExistingInternal(key, value, cacheItemPolicy);
	}

	public override CacheItem AddOrGetExisting(CacheItem item, CacheItemPolicy policy)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return new CacheItem(item.Key, AddOrGetExistingInternal(item.Key, item.Value, policy));
	}

	public override object AddOrGetExisting(string key, object value, CacheItemPolicy policy, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		return AddOrGetExistingInternal(key, value, policy);
	}

	public override object Get(string key, string regionName = null)
	{
		return GetInternal(key, regionName);
	}

	public override CacheItem GetCacheItem(string key, string regionName = null)
	{
		object @internal = GetInternal(key, regionName);
		if (@internal == null)
		{
			return null;
		}
		return new CacheItem(key, @internal);
	}

	public override void Set(string key, object value, DateTimeOffset absoluteExpiration, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
		cacheItemPolicy.AbsoluteExpiration = absoluteExpiration;
		Set(key, value, cacheItemPolicy);
	}

	public override void Set(CacheItem item, CacheItemPolicy policy)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		Set(item.Key, item.Value, policy);
	}

	public override void Set(string key, object value, CacheItemPolicy policy, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		DateTimeOffset absExp = ObjectCache.InfiniteAbsoluteExpiration;
		TimeSpan slidingExp = ObjectCache.NoSlidingExpiration;
		CacheItemPriority priority = CacheItemPriority.Default;
		Collection<ChangeMonitor> collection = null;
		CacheEntryRemovedCallback removedCallback = null;
		if (policy != null)
		{
			ValidatePolicy(policy);
			if (policy.UpdateCallback != null)
			{
				Set(key, value, policy.ChangeMonitors, policy.AbsoluteExpiration, policy.SlidingExpiration, policy.UpdateCallback);
				return;
			}
			absExp = policy.AbsoluteExpiration;
			slidingExp = policy.SlidingExpiration;
			priority = policy.Priority;
			collection = policy.ChangeMonitors;
			removedCallback = policy.RemovedCallback;
		}
		if (IsDisposed)
		{
			if (collection == null)
			{
				return;
			}
			{
				foreach (ChangeMonitor item in collection)
				{
					item?.Dispose();
				}
				return;
			}
		}
		MemoryCacheKey memoryCacheKey = new MemoryCacheKey(key);
		MemoryCacheStore store = GetStore(memoryCacheKey);
		store.Set(memoryCacheKey, new MemoryCacheEntry(key, value, absExp, slidingExp, priority, collection, removedCallback, this));
	}

	internal void Set(string key, object value, Collection<ChangeMonitor> changeMonitors, DateTimeOffset absoluteExpiration, TimeSpan slidingExpiration, CacheEntryUpdateCallback onUpdateCallback)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (changeMonitors == null && absoluteExpiration == ObjectCache.InfiniteAbsoluteExpiration && slidingExpiration == ObjectCache.NoSlidingExpiration)
		{
			throw new ArgumentException(R.Invalid_argument_combination);
		}
		if (onUpdateCallback == null)
		{
			throw new ArgumentNullException("onUpdateCallback");
		}
		if (IsDisposed)
		{
			if (changeMonitors == null)
			{
				return;
			}
			{
				foreach (ChangeMonitor changeMonitor2 in changeMonitors)
				{
					changeMonitor2?.Dispose();
				}
				return;
			}
		}
		MemoryCacheKey memoryCacheKey = new MemoryCacheKey(key);
		MemoryCacheStore store = GetStore(memoryCacheKey);
		MemoryCacheEntry memoryCacheEntry = new MemoryCacheEntry(key, value, ObjectCache.InfiniteAbsoluteExpiration, ObjectCache.NoSlidingExpiration, CacheItemPriority.NotRemovable, null, null, this);
		store.Set(memoryCacheKey, memoryCacheEntry);
		string[] keys = new string[1] { key };
		ChangeMonitor changeMonitor = CreateCacheEntryChangeMonitor(keys);
		if (changeMonitors == null)
		{
			changeMonitors = new Collection<ChangeMonitor>();
		}
		changeMonitors.Add(changeMonitor);
		MemoryCacheKey memoryCacheKey2 = new MemoryCacheKey("OnUpdateSentinel" + key);
		MemoryCacheStore store2 = GetStore(memoryCacheKey2);
		MemoryCacheEntry memoryCacheEntry2 = new MemoryCacheEntry(memoryCacheKey2.Key, new SentinelEntry(key, changeMonitor, onUpdateCallback), absoluteExpiration, slidingExpiration, CacheItemPriority.NotRemovable, changeMonitors, s_sentinelRemovedCallback, this);
		store2.Set(memoryCacheKey2, memoryCacheEntry2);
		memoryCacheEntry.ConfigureUpdateSentinel(store2, memoryCacheEntry2);
	}

	public override object Remove(string key, string regionName = null)
	{
		return Remove(key, CacheEntryRemovedReason.Removed, regionName);
	}

	public object Remove(string key, CacheEntryRemovedReason reason, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDisposed)
		{
			return null;
		}
		return RemoveEntry(key, null, reason)?.Value;
	}

	public override long GetCount(string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		long num = 0L;
		if (!IsDisposed)
		{
			GCHandleRef<MemoryCacheStore>[] storeRefs = _storeRefs;
			foreach (GCHandleRef<MemoryCacheStore> gCHandleRef in storeRefs)
			{
				num += gCHandleRef.Target.Count;
			}
		}
		return num;
	}

	public long GetLastSize(string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		return _stats.GetLastSize();
	}

	public override IDictionary<string, object> GetValues(IEnumerable<string> keys, string regionName = null)
	{
		if (regionName != null)
		{
			throw new NotSupportedException(R.RegionName_not_supported);
		}
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		Dictionary<string, object> dictionary = null;
		if (!IsDisposed)
		{
			foreach (string key in keys)
			{
				if (key == null)
				{
					throw new ArgumentException(RH.Format(R.Collection_contains_null_element, "keys"));
				}
				object @internal = GetInternal(key, null);
				if (@internal != null)
				{
					if (dictionary == null)
					{
						dictionary = new Dictionary<string, object>();
					}
					dictionary[key] = @internal;
				}
			}
			return dictionary;
		}
		return dictionary;
	}

	internal void UpdateConfig(NameValueCollection config)
	{
		if (config == null)
		{
			throw new ArgumentNullException("config");
		}
		if (!IsDisposed)
		{
			_stats.UpdateConfig(config);
		}
	}
}
