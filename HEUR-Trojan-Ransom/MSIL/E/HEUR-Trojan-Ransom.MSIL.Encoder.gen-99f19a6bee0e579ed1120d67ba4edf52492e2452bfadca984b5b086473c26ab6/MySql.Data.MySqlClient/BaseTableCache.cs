using System;
using System.Collections.Generic;
using System.Linq;

namespace MySql.Data.MySqlClient;

public class BaseTableCache
{
	private struct CacheEntry
	{
		public DateTime CacheTime;

		public object CacheElement;
	}

	protected int MaxCacheAge;

	private Dictionary<string, CacheEntry> cache = new Dictionary<string, CacheEntry>();

	public BaseTableCache(int maxCacheAge)
	{
		MaxCacheAge = maxCacheAge;
	}

	public virtual void AddToCache(string commandText, object resultSet)
	{
		CleanCache();
		CacheEntry value = default(CacheEntry);
		value.CacheTime = DateTime.Now;
		value.CacheElement = resultSet;
		lock (cache)
		{
			if (!cache.ContainsKey(commandText))
			{
				cache.Add(commandText, value);
			}
		}
	}

	public virtual object RetrieveFromCache(string commandText, int cacheAge)
	{
		CleanCache();
		lock (cache)
		{
			if (!cache.ContainsKey(commandText))
			{
				return null;
			}
			CacheEntry cacheEntry = cache[commandText];
			if (DateTime.Now.Subtract(cacheEntry.CacheTime).TotalSeconds > (double)cacheAge)
			{
				return null;
			}
			return cacheEntry.CacheElement;
		}
	}

	public void RemoveFromCache(string commandText)
	{
		lock (cache)
		{
			if (cache.ContainsKey(commandText))
			{
				cache.Remove(commandText);
			}
		}
	}

	public virtual void Dump()
	{
		lock (cache)
		{
			cache.Clear();
		}
	}

	protected virtual void CleanCache()
	{
		DateTime now = DateTime.Now;
		List<string> list = new List<string>();
		lock (cache)
		{
			list.AddRange(from key in cache.Keys
				let diff = now.Subtract(cache[key].CacheTime)
				where diff.TotalSeconds > (double)MaxCacheAge
				select key);
			foreach (string item in list)
			{
				cache.Remove(item);
			}
		}
	}
}
