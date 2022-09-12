using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.CSharp.RuntimeBinder;

namespace Yakari;

public class LittleThunder : BaseCacheProvider, IDisposable, ILocalCacheProvider
{
	private const int Thousand = 1000;

	private ILocalCacheProviderOptions _options;

	private ConcurrentDictionary<string, InMemoryCacheItem> _concurrentStore;

	private readonly Timer _timer;

	private bool _inPeriod;

	private bool _disposing;

	public override bool HasSlidingSupport => true;

	public event BeforeGet OnBeforeGet;

	public event AfterGet OnAfterGet;

	public event BeforeSet OnBeforeSet;

	public event AfterSet OnAfterSet;

	public event BeforeDelete OnBeforeDelete;

	public event AfterDelete OnAfterDelete;

	public LittleThunder(ILocalCacheProviderOptions options)
	{
		_options = options;
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Constructor Begin");
		_concurrentStore = new ConcurrentDictionary<string, InMemoryCacheItem>(_options.ConcurrencyLevel, _options.InitialCapacity);
		_timer = new Timer(timer_Elapsed, null, Convert.ToInt32(500.0 + Math.Abs(500.0)), Convert.ToInt32(1500.0 - Math.Floor(500.0)));
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Constructor End");
	}

	public void Reset(ILocalCacheProviderOptions options)
	{
		_options = options;
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Reset Begin");
		_concurrentStore = new ConcurrentDictionary<string, InMemoryCacheItem>(_options.ConcurrencyLevel, _options.InitialCapacity);
		_timer.Change(Convert.ToInt32(1006.2146080984222 - Math.Log(500.0)), Convert.ToInt32(500.0 + Math.Abs(500.0)));
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Reset End");
	}

	private void timer_Elapsed(object sender)
	{
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Timer Elapsed");
		if (_disposing || _inPeriod)
		{
			return;
		}
		_options.Logger.Log(LogLevel.Trace, "LittleThunder In Period Begin");
		try
		{
			_inPeriod = true;
			RemoveExpiredItems();
		}
		catch (Exception exception)
		{
			_options.Logger.Log("LittleThunder In Period Exception", exception);
		}
		finally
		{
			_inPeriod = false;
		}
		_options.Logger.Log(LogLevel.Trace, "LittleThunder In Period End");
	}

	private void RemoveExpiredItems()
	{
		_options.Logger.Log(LogLevel.Trace, "LittleThunder RemoveExpiredItems Begin");
		KeyValuePair<string, InMemoryCacheItem>[] array = _concurrentStore.Where((KeyValuePair<string, InMemoryCacheItem> o) => o.Value.IsExpired).ToArray();
		_options.Logger.Log(LogLevel.Trace, $"LittleThunder Removing {array.Length} Item(s)");
		KeyValuePair<string, InMemoryCacheItem>[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			KeyValuePair<string, InMemoryCacheItem> keyValuePair = array2[i];
			int num = 0;
			InMemoryCacheItem value;
			while (!_concurrentStore.TryRemove(keyValuePair.Key, out value))
			{
				num++;
				if (!_concurrentStore.ContainsKey(keyValuePair.Key) || num >= _options.MaxRetryForLocalOperations)
				{
					break;
				}
			}
		}
		_options.Logger.Log(LogLevel.Trace, "LittleThunder RemoveExpiredItems End");
	}

	public override T Get<T>(string key, TimeSpan getTimeout, bool isManagerCall = false)
	{
		return GetInternal<T>(key, getTimeout, isManagerCall);
	}

	private T GetInternal<T>(string key, TimeSpan getTimeout, bool isManagerCall, bool secondCall = false)
	{
		T result = default(T);
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Get");
		OnBeforeGetWrapper(key, getTimeout, isManagerCall);
		if (_concurrentStore.ContainsKey(key))
		{
			int num = 0;
			InMemoryCacheItem value;
			while (!_concurrentStore.TryGetValue(key, out value))
			{
				num++;
				if (!_concurrentStore.ContainsKey(key) || num >= _options.MaxRetryForLocalOperations)
				{
					break;
				}
			}
			OnAfterGetWrapper(key, isManagerCall);
			if (value == null)
			{
				return default(T);
			}
			value.Hit();
			if (_003C_003Eo__10<T>._003C_003Ep__0 == null)
			{
				_003C_003Eo__10<T>._003C_003Ep__0 = CallSite<Func<CallSite, object, T>>.Create(Binder.Convert((CSharpBinderFlags)Convert.ToInt32(24.0 - Math.Round(8.0)), typeof(T), typeof(LittleThunder)));
			}
			result = _003C_003Eo__10<T>._003C_003Ep__0.Target(_003C_003Eo__10<T>._003C_003Ep__0, (object)value.ValueObject);
		}
		else if (!secondCall)
		{
			result = ThreadHelper.WaitForResult(() => GetInternal<T>(key, getTimeout, isManagerCall: false, secondCall: true), getTimeout);
		}
		ThreadHelper.RunOnDifferentThread(delegate
		{
			OnAfterGetWrapper(key, isManagerCall);
		}, swallowException: true);
		return result;
	}

	private void OnAfterGetWrapper(string key, bool isManagerCall)
	{
		if (!isManagerCall)
		{
			this.OnAfterGet?.Invoke(key);
		}
	}

	private void OnBeforeGetWrapper(string key, TimeSpan getTimeout, bool isManagerCall)
	{
		if (!isManagerCall)
		{
			this.OnBeforeGet?.Invoke(key, getTimeout);
		}
	}

	public override void Set(string key, object value, TimeSpan expiresIn, bool isManagerCall = false)
	{
		_options.Logger.Log(LogLevel.Debug, "LittleThunder Set");
		InMemoryCacheItem item = new InMemoryCacheItem(value, expiresIn);
		OnBeforeSetWrapper(key, item, isManagerCall);
		Func<string, InMemoryCacheItem, InMemoryCacheItem> updateValueFactory = (string s, InMemoryCacheItem cacheItem) => item;
		_concurrentStore.AddOrUpdate(key, item, updateValueFactory);
		OnAfterSetWrapper(key, isManagerCall);
	}

	private void OnAfterSetWrapper(string key, bool isManagerCall)
	{
		if (!isManagerCall)
		{
			ThreadHelper.RunOnDifferentThread(delegate
			{
				this.OnAfterSet?.Invoke(key);
			}, swallowException: true);
		}
	}

	private void OnBeforeSetWrapper(string key, InMemoryCacheItem item, bool isManagerCall)
	{
		if (!isManagerCall)
		{
			this.OnBeforeSet?.Invoke(key, item);
		}
	}

	public override void Delete(string key, bool isManagerCall = false)
	{
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Delete");
		OnBeforeDeleteWrapper(key, isManagerCall);
		if (!_concurrentStore.ContainsKey(key))
		{
			return;
		}
		int num = 0;
		InMemoryCacheItem value;
		while (_concurrentStore.TryRemove(key, out value))
		{
			num++;
			if (!_concurrentStore.ContainsKey(key) || num >= _options.MaxRetryForLocalOperations)
			{
				break;
			}
		}
		OnAfterDeleteWrapper(key, isManagerCall);
	}

	private void OnAfterDeleteWrapper(string key, bool isManagerCall)
	{
		if (!isManagerCall)
		{
			ThreadHelper.RunOnDifferentThread(delegate
			{
				this.OnAfterDelete?.Invoke(key);
			}, swallowException: true);
		}
	}

	private void OnBeforeDeleteWrapper(string key, bool isManagerCall)
	{
		if (!isManagerCall)
		{
			ThreadHelper.RunOnDifferentThread(delegate
			{
				this.OnBeforeDelete?.Invoke(key);
			}, swallowException: true);
		}
	}

	public override bool Exists(string key)
	{
		_options.Logger.Log(LogLevel.Trace, "LittleThunder Exists");
		if (_concurrentStore.ContainsKey(key))
		{
			return true;
		}
		return false;
	}

	public override List<string> AllKeys()
	{
		return _concurrentStore.Keys.ToList();
	}

	public override void Dispose()
	{
		if (!_disposing)
		{
			_options.Logger.Log(LogLevel.Trace, "LittleThunder Disposing");
			_disposing = true;
			_timer.Dispose();
			_concurrentStore = null;
		}
	}
}
