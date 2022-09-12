using System;

namespace Gecko.Cache;

public enum CacheStoragePolicy
{
	Anywhere,
	InMemory,
	OnDisk,
	[Obsolete("value 3 was used by STORE_ON_DISK_AS_FILE which was removed", true)]
	OnDiskAsFile,
	Offline
}
