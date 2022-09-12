using System;
using System.Collections.Concurrent;
using System.IO;
using System.Security;
using Lucene.Net.Store;

namespace Examine.LuceneEngine;

[SecuritySafeCritical]
public sealed class DirectoryTracker
{
	private static readonly DirectoryTracker Instance = new DirectoryTracker();

	private readonly ConcurrentDictionary<string, Directory> _directories = new ConcurrentDictionary<string, Directory>();

	public static DirectoryTracker Current => Instance;

	public Directory GetDirectory(DirectoryInfo dir)
	{
		return GetDirectory(dir, throwIfEmpty: false);
	}

	public Directory GetDirectory(DirectoryInfo dir, bool throwIfEmpty)
	{
		if (throwIfEmpty)
		{
			if (!_directories.TryGetValue(dir.FullName, out var value))
			{
				throw new NullReferenceException("No directory was added with path " + dir.FullName + ", maybe an indexer hasn't been initialized?");
			}
			return value;
		}
		return _directories.GetOrAdd(dir.FullName, (Func<string, Directory>)((string s) => (Directory)new SimpleFSDirectory(dir)));
	}

	public Directory GetDirectory(DirectoryInfo dir, Func<string, Directory> factory)
	{
		return _directories.GetOrAdd(dir.FullName, factory);
	}
}
