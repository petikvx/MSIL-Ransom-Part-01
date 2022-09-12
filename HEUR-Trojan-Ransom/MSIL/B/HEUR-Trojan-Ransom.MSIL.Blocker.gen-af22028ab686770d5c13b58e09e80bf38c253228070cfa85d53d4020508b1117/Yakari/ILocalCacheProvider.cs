using System;
using System.Collections.Generic;

namespace Yakari;

public interface ILocalCacheProvider : IDisposable
{
	bool HasSlidingSupport { get; }

	event BeforeGet OnBeforeGet;

	event AfterGet OnAfterGet;

	event BeforeSet OnBeforeSet;

	event AfterSet OnAfterSet;

	event BeforeDelete OnBeforeDelete;

	event AfterDelete OnAfterDelete;

	T Get<T>(string key, TimeSpan getTimeout, bool isManagerCall = false) where T : class;

	T Get<T>(string key, TimeSpan getTimeout, Func<T> acquireFunction, TimeSpan expiresIn, bool isManagerCall = false) where T : class;

	void Set(string key, object value, TimeSpan expiresIn, bool isManagerCall = false);

	void Delete(string key, bool isManagerCall = false);

	bool Exists(string key);

	List<string> AllKeys();
}
