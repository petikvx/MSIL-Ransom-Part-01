using System;
using System.Collections.Generic;

namespace Yakari;

public abstract class BaseCacheProvider : IDisposable, ICacheProvider
{
	public abstract bool HasSlidingSupport { get; }

	public abstract void Dispose();

	public abstract T Get<T>(string key, TimeSpan getTimeout, bool isManagerCall = false) where T : class;

	public T Get<T>(string key, TimeSpan getTimeout, Func<T> acquireFunction, TimeSpan expiresIn, bool isManagerCall = false) where T : class
	{
		T val = Get<T>(key, getTimeout, isManagerCall);
		if (val == null)
		{
			val = acquireFunction();
			if (val == null)
			{
				return null;
			}
			Set(key, val, expiresIn, isManagerCall);
		}
		return val;
	}

	public abstract void Set(string key, object value, TimeSpan expiresIn, bool isManagerCall = false);

	public abstract void Delete(string key, bool isManagerCall = false);

	public abstract bool Exists(string key);

	public abstract List<string> AllKeys();
}
