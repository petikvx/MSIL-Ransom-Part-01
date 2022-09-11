namespace System.Runtime.Caching;

internal class MemoryCacheKey
{
	private string _key;

	private int _hash;

	internal int Hash => _hash;

	internal string Key => _key;

	internal MemoryCacheKey(string key)
	{
		_key = key;
		_hash = key.GetHashCode();
	}
}
