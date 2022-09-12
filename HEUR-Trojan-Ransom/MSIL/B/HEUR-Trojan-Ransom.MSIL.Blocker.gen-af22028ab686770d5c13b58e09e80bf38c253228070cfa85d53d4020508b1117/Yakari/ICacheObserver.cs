using System;

namespace Yakari;

public interface ICacheObserver : IDisposable
{
	void OnBeforeSet(string key, InMemoryCacheItem item);

	void OnAfterSet(string key);

	void OnBeforeDelete(string key);

	void OnAfterDelete(string key);

	void OnBeforeGet(string key, TimeSpan timeout);

	void OnAfterGet(string key);

	void OnRemoteSet(string key, string memberName);

	void OnRemoteDelete(string key, string memberName);
}
