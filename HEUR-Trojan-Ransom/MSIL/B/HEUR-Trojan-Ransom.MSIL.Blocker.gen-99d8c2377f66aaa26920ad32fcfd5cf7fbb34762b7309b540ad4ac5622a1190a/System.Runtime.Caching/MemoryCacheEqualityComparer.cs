using System.Collections;

namespace System.Runtime.Caching;

internal class MemoryCacheEqualityComparer : IEqualityComparer
{
	bool IEqualityComparer.Equals(object x, object y)
	{
		MemoryCacheKey memoryCacheKey = (MemoryCacheKey)x;
		MemoryCacheKey memoryCacheKey2 = (MemoryCacheKey)y;
		return string.Compare(memoryCacheKey.Key, memoryCacheKey2.Key, StringComparison.Ordinal) == 0;
	}

	int IEqualityComparer.GetHashCode(object obj)
	{
		MemoryCacheKey memoryCacheKey = (MemoryCacheKey)obj;
		return memoryCacheKey.Hash;
	}
}
