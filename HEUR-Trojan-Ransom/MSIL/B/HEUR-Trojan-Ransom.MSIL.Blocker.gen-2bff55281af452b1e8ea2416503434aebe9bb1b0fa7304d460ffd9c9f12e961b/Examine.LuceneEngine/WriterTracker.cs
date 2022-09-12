using System;
using System.Collections.Concurrent;
using System.Security;
using Lucene.Net.Index;
using Lucene.Net.Store;

namespace Examine.LuceneEngine;

[SecuritySafeCritical]
public sealed class WriterTracker
{
	private readonly ConcurrentDictionary<string, IndexWriter> _writers = new ConcurrentDictionary<string, IndexWriter>();

	public static WriterTracker Current { get; } = new WriterTracker();


	internal void Reset()
	{
		_writers.Clear();
	}

	public IndexWriter GetWriter(Directory dir)
	{
		return GetWriter(dir, throwIfEmpty: false);
	}

	public IndexWriter GetWriter(Directory dir, bool throwIfEmpty)
	{
		IndexWriter value = null;
		if (!_writers.TryGetValue(dir.GetLockID(), out value) && throwIfEmpty)
		{
			throw new NullReferenceException("No writer was added with directory key " + dir.GetLockID() + ", maybe an indexer hasn't been initialized?");
		}
		return value;
	}

	public IndexWriter GetWriter(Directory dir, Func<Directory, IndexWriter> factory)
	{
		return _writers.GetOrAdd(dir.GetLockID(), (Func<string, IndexWriter>)((string s) => factory(dir)));
	}
}
