using System;
using System.Collections.Generic;

namespace Gecko.Cache;

internal sealed class CacheEntryMetadataSearcher : IDisposable, nsICacheMetaDataVisitor
{
	private Func<string, string, bool> _predicate;

	private List<KeyValuePair<string, string>> _foundEntries = new List<KeyValuePair<string, string>>();

	internal CacheEntryMetadataSearcher(Func<string, string, bool> predicate)
	{
		_predicate = predicate;
	}

	~CacheEntryMetadataSearcher()
	{
		_foundEntries.Clear();
	}

	public bool VisitMetaDataElement(string key, string value)
	{
		if (_predicate(key, value))
		{
			_foundEntries.Add(new KeyValuePair<string, string>(key, value));
		}
		return true;
	}

	public void Dispose()
	{
		_foundEntries.Clear();
		GC.SuppressFinalize(this);
	}

	public KeyValuePair<string, string>[] GetResult()
	{
		return _foundEntries.ToArray();
	}
}
