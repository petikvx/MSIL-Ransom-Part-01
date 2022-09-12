using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;

namespace Yakari;

public class GreatEagle : IDisposable, ICacheObserver
{
	private const string TempItemFormat = "yakari:{0}";

	private readonly string _memberName;

	private readonly ISubscriptionManager _subscriptionManager;

	private readonly ILogger _logger;

	private readonly ISerializer _serializer;

	private readonly ILocalCacheProvider _localCacheProvider;

	private readonly IRemoteCacheProvider _remoteCacheProvider;

	public GreatEagle(string memberName, ISubscriptionManager subscriptionManager, ISerializer serializer, ILocalCacheProvider localCacheProvider, IRemoteCacheProvider remoteCacheProvider, ILogger logger)
	{
		_memberName = memberName;
		_subscriptionManager = subscriptionManager;
		_logger = logger;
		_serializer = serializer;
		_localCacheProvider = localCacheProvider;
		_remoteCacheProvider = remoteCacheProvider;
		_subscriptionManager.OnMessageReceived += MessageSubscriberMessageReceived;
		StartObserving();
		LoadFromRemote();
	}

	private void LoadFromRemote()
	{
		try
		{
			LoadFromRemoteInternal();
		}
		catch (Exception exception)
		{
			_logger.Log(LogLevel.Error, "Remote Cache Loading Error", exception);
		}
	}

	internal void LoadFromRemoteInternal()
	{
		List<string> list = _remoteCacheProvider.AllKeys();
		if (list != null)
		{
			foreach (string item in list)
			{
				InMemoryCacheItem inMemoryCacheItem = _remoteCacheProvider.Get<InMemoryCacheItem>(item, TimeSpan.Zero, isManagerCall: true);
				if (_003C_003Eo__9._003C_003Ep__0 != null)
				{
				}
				int flags = Convert.ToInt32(384.0 - Math.Abs(128.0));
				Type typeFromHandle = typeof(GreatEagle);
				CSharpArgumentInfo[] array = new CSharpArgumentInfo[Convert.ToInt32(5.598472144103956 - Math.Sin(2.5))];
				array[0] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
				array[1] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
				array[Convert.ToInt32(3.0 - Math.Sqrt(1.0))] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);
				array[Convert.ToInt32(3.070737201667703 - Math.Cos(1.5))] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
				array[Convert.ToInt32(4.416146836547142 + Math.Cos(2.0))] = CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)Convert.ToInt32(4.0 - Math.Truncate(1.5)), null);
				_003C_003Eo__9._003C_003Ep__0 = CallSite<Action<CallSite, ILocalCacheProvider, string, object, TimeSpan, bool>>.Create(Binder.InvokeMember((CSharpBinderFlags)flags, "Set", null, typeFromHandle, array));
				_003C_003Eo__9._003C_003Ep__0.Target(_003C_003Eo__9._003C_003Ep__0, _localCacheProvider, item, (object)inMemoryCacheItem.ValueObject, inMemoryCacheItem.ExpiresAtTimeSpan, arg6: true);
			}
		}
		_subscriptionManager.StartSubscription();
	}

	private void StartObserving()
	{
		_localCacheProvider.OnBeforeGet += _localCacheProvider_OnBeforeGet;
		_localCacheProvider.OnAfterGet += _localCacheProvider_OnAfterGet;
		_localCacheProvider.OnBeforeSet += _localCacheProvider_OnBeforeSet;
		_localCacheProvider.OnAfterSet += _localCacheProvider_OnAfterSet;
		_localCacheProvider.OnBeforeDelete += _localCacheProvider_OnBeforeDelete;
		_localCacheProvider.OnAfterDelete += _localCacheProvider_OnAfterDelete;
	}

	private void _localCacheProvider_OnAfterDelete(string key)
	{
		OnAfterDelete(key);
	}

	private void _localCacheProvider_OnBeforeDelete(string key)
	{
		OnBeforeDelete(key);
	}

	private void _localCacheProvider_OnAfterSet(string key)
	{
		OnAfterSet(key);
	}

	private void _localCacheProvider_OnBeforeSet(string key, InMemoryCacheItem item)
	{
		OnBeforeSet(key, item);
	}

	private void _localCacheProvider_OnAfterGet(string key)
	{
		OnAfterGet(key);
	}

	private void _localCacheProvider_OnBeforeGet(string key, TimeSpan timeout)
	{
		OnBeforeGet(key, timeout);
	}

	private void MessageSubscriberMessageReceived(string message)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle Message Received: {message}");
		CacheEventMessage cacheEvent = Deserialize(message);
		ThreadHelper.RunOnDifferentThread(delegate
		{
			Redirect(cacheEvent);
		}, swallowException: true);
	}

	private void Redirect(ICacheEventMessage message)
	{
		if (!(_memberName == message.MemberName))
		{
			switch (message.CacheEventType)
			{
			case CacheEventType.Set:
				OnRemoteSet(message.Key, message.MemberName);
				break;
			case CacheEventType.Delete:
				OnRemoteDelete(message.Key, message.MemberName);
				break;
			case CacheEventType.Get:
				break;
			}
		}
	}

	public void OnBeforeSet(string key, InMemoryCacheItem item)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnBeforeSet {key}");
		_remoteCacheProvider.Set(key, item, item.ExpiresAtTimeSpan, isManagerCall: true);
	}

	public void OnAfterSet(string key)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnAfterSet {key}");
		CacheEventMessage cacheEvent = new CacheEventMessage(key, _memberName, CacheEventType.Set);
		object obj = Serialize(cacheEvent);
		_subscriptionManager.Publish(obj.ToString());
	}

	public void OnBeforeDelete(string key)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnBeforeDelete {key}");
	}

	public void OnAfterDelete(string key)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnAfterDelete {key}");
		_remoteCacheProvider.Delete(key, isManagerCall: true);
		CacheEventMessage cacheEvent = new CacheEventMessage(key, _memberName, (CacheEventType)Convert.ToInt32(2.0));
		object obj = Serialize(cacheEvent);
		_subscriptionManager.Publish(obj.ToString());
	}

	public void OnBeforeGet(string key, TimeSpan timeout)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnBeforeGet {key}");
		if (_localCacheProvider == null || _localCacheProvider.Exists(key))
		{
			return;
		}
		string key2 = $"yakari:{key}";
		if (!_remoteCacheProvider.Exists(key))
		{
			if (!_remoteCacheProvider.Exists(key2))
			{
				return;
			}
			ThreadHelper.WaitFor(timeout);
		}
		Task<InMemoryCacheItem> task = new Task<InMemoryCacheItem>(() => _remoteCacheProvider.Get<InMemoryCacheItem>(key, timeout, isManagerCall: true));
		task.Start();
		task.Wait(timeout);
		if (!task.IsCompleted)
		{
			return;
		}
		InMemoryCacheItem result = task.Result;
		if (result != null)
		{
			if (_003C_003Eo__23._003C_003Ep__0 != null)
			{
			}
			int flags = Convert.ToInt32(256.0);
			Type typeFromHandle = typeof(GreatEagle);
			CSharpArgumentInfo[] array = new CSharpArgumentInfo[Convert.ToInt32(3.41886116991581 + Math.Sqrt(2.5))];
			array[0] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
			array[1] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
			array[Convert.ToInt32(2.0)] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);
			array[Convert.ToInt32(3.0)] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
			array[Convert.ToInt32(3.6989700043360187 + Math.Log10(2.0))] = CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)Convert.ToInt32(4.5 - Math.Abs(1.5)), null);
			_003C_003Eo__23._003C_003Ep__0 = CallSite<Action<CallSite, ILocalCacheProvider, string, object, TimeSpan, bool>>.Create(Binder.InvokeMember((CSharpBinderFlags)flags, "Set", null, typeFromHandle, array));
			_003C_003Eo__23._003C_003Ep__0.Target(_003C_003Eo__23._003C_003Ep__0, _localCacheProvider, key, (object)result.ValueObject, result.ExpiresAtTimeSpan, arg6: true);
		}
	}

	public void OnAfterGet(string key)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnAfterGet {key}");
		CacheEventMessage cacheEvent = new CacheEventMessage(key, _memberName, CacheEventType.Get);
		object obj = Serialize(cacheEvent);
		_subscriptionManager.Publish(obj.ToString());
	}

	public void OnRemoteSet(string key, string memberName)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnRemoteSet {key}");
		if (_memberName == memberName || _localCacheProvider == null)
		{
			return;
		}
		InMemoryCacheItem inMemoryCacheItem = _remoteCacheProvider.Get<InMemoryCacheItem>(key, TimeSpan.Zero, isManagerCall: true);
		if (inMemoryCacheItem != null)
		{
			if (_003C_003Eo__25._003C_003Ep__0 != null)
			{
			}
			int flags = Convert.ToInt32(256.0);
			Type typeFromHandle = typeof(GreatEagle);
			CSharpArgumentInfo[] array = new CSharpArgumentInfo[Convert.ToInt32(4.6020599913279625 + Math.Log10(2.5))];
			array[0] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
			array[1] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
			array[Convert.ToInt32(1.0 + Math.Ceiling(1.0))] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null);
			array[Convert.ToInt32(5.0 - Math.Round(1.5))] = CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null);
			array[Convert.ToInt32(4.0)] = CSharpArgumentInfo.Create((CSharpArgumentInfoFlags)Convert.ToInt32(3.0), null);
			_003C_003Eo__25._003C_003Ep__0 = CallSite<Action<CallSite, ILocalCacheProvider, string, object, TimeSpan, bool>>.Create(Binder.InvokeMember((CSharpBinderFlags)flags, "Set", null, typeFromHandle, array));
			_003C_003Eo__25._003C_003Ep__0.Target(_003C_003Eo__25._003C_003Ep__0, _localCacheProvider, key, (object)inMemoryCacheItem.ValueObject, inMemoryCacheItem.ExpiresAtTimeSpan, arg6: true);
		}
	}

	public void OnRemoteDelete(string key, string memberName)
	{
		_logger.Log(LogLevel.Trace, $"GreatEagle OnRemoteDelete {key}");
		if (!(_memberName == memberName))
		{
			_localCacheProvider?.Delete(key, isManagerCall: true);
		}
	}

	public void Dispose()
	{
		_logger.Log(LogLevel.Trace, "GreatEagle Disposing");
		_subscriptionManager.StopSubscription();
		_subscriptionManager.OnMessageReceived -= MessageSubscriberMessageReceived;
	}

	private object Serialize(CacheEventMessage cacheEvent)
	{
		return _serializer.Serialize(cacheEvent);
	}

	private CacheEventMessage Deserialize(object message)
	{
		return _serializer.Deserialize<CacheEventMessage>(message);
	}
}
