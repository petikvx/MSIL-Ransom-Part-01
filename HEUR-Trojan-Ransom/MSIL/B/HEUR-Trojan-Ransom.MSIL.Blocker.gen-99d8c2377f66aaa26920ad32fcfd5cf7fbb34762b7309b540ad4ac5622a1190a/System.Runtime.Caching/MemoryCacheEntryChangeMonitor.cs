using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace System.Runtime.Caching;

internal sealed class MemoryCacheEntryChangeMonitor : CacheEntryChangeMonitor
{
	private static readonly DateTime DATETIME_MINVALUE_UTC = new DateTime(0L, DateTimeKind.Utc);

	private const int MAX_CHAR_COUNT_OF_LONG_CONVERTED_TO_HEXADECIMAL_STRING = 16;

	private ReadOnlyCollection<string> _keys;

	private string _regionName;

	private string _uniqueId;

	private DateTimeOffset _lastModified;

	private List<MemoryCacheEntry> _dependencies;

	public override ReadOnlyCollection<string> CacheKeys => new ReadOnlyCollection<string>(_keys);

	public override string RegionName => _regionName;

	public override string UniqueId => _uniqueId;

	public override DateTimeOffset LastModified => _lastModified;

	internal List<MemoryCacheEntry> Dependencies => _dependencies;

	private MemoryCacheEntryChangeMonitor()
	{
	}

	private void InitDisposableMembers(MemoryCache cache)
	{
		bool flag = true;
		try
		{
			bool hasChanged = false;
			string text = null;
			_dependencies = new List<MemoryCacheEntry>(_keys.Count);
			if (_keys.Count == 1)
			{
				string text2 = _keys[0];
				MemoryCacheEntry entry = cache.GetEntry(text2);
				DateTime utcCreated = DATETIME_MINVALUE_UTC;
				StartMonitoring(cache, entry, ref hasChanged, ref utcCreated);
				text = text2 + utcCreated.Ticks.ToString("X", CultureInfo.InvariantCulture);
				_lastModified = utcCreated;
			}
			else
			{
				int num = 0;
				foreach (string key in _keys)
				{
					num += key.Length + 16;
				}
				StringBuilder stringBuilder = new StringBuilder(num);
				foreach (string key2 in _keys)
				{
					MemoryCacheEntry entry2 = cache.GetEntry(key2);
					DateTime utcCreated2 = DATETIME_MINVALUE_UTC;
					StartMonitoring(cache, entry2, ref hasChanged, ref utcCreated2);
					stringBuilder.Append(key2);
					stringBuilder.Append(utcCreated2.Ticks.ToString("X", CultureInfo.InvariantCulture));
					if (utcCreated2 > _lastModified)
					{
						_lastModified = utcCreated2;
					}
				}
				text = stringBuilder.ToString();
			}
			_uniqueId = text;
			if (hasChanged)
			{
				OnChanged(null);
			}
			flag = false;
		}
		finally
		{
			InitializationComplete();
			if (flag)
			{
				Dispose();
			}
		}
	}

	private void StartMonitoring(MemoryCache cache, MemoryCacheEntry entry, ref bool hasChanged, ref DateTime utcCreated)
	{
		if (entry != null)
		{
			entry.AddDependent(cache, this);
			_dependencies.Add(entry);
			if (entry.State != EntryState.AddedToCache)
			{
				hasChanged = true;
			}
			utcCreated = entry.UtcCreated;
		}
		else
		{
			hasChanged = true;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (!disposing || _dependencies == null)
		{
			return;
		}
		foreach (MemoryCacheEntry dependency in _dependencies)
		{
			dependency?.RemoveDependent(this);
		}
	}

	internal MemoryCacheEntryChangeMonitor(ReadOnlyCollection<string> keys, string regionName, MemoryCache cache)
	{
		_keys = keys;
		_regionName = regionName;
		InitDisposableMembers(cache);
	}

	internal void OnCacheEntryReleased()
	{
		OnChanged(null);
	}
}
