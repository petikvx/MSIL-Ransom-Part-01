using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using Lucene.Net.Index;
using Lucene.Net.Store;

namespace Examine.LuceneEngine;

[SecuritySafeCritical]
internal class OpenReaderTracker
{
	private static readonly OpenReaderTracker Instance = new OpenReaderTracker();

	private readonly List<Tuple<IndexReader, DateTime>> _oldReaders = new List<Tuple<IndexReader, DateTime>>();

	private readonly object _locker = new object();

	public static OpenReaderTracker Current => Instance;

	public void AddOpenReader(IndexReader reader)
	{
		lock (_locker)
		{
			_oldReaders.Add(new Tuple<IndexReader, DateTime>(reader, DateTime.Now));
		}
	}

	public int CloseStaleReaders(Directory dir, TimeSpan ts)
	{
		lock (_locker)
		{
			DateTime now = DateTime.Now;
			List<Tuple<IndexReader, DateTime>> list = _oldReaders.Where((Tuple<IndexReader, DateTime> x) => x.Item1.Directory().GetLockID() == dir.GetLockID()).ToList();
			Tuple<IndexReader, DateTime> item = list.OrderByDescending((Tuple<IndexReader, DateTime> x) => x.Item2).FirstOrDefault();
			list.Remove(item);
			Tuple<IndexReader, DateTime>[] array = list.Where((Tuple<IndexReader, DateTime> x) => now - x.Item2 >= ts).ToArray();
			Tuple<IndexReader, DateTime>[] array2 = array;
			foreach (Tuple<IndexReader, DateTime> tuple in array2)
			{
				try
				{
					tuple.Item1.Close();
				}
				catch (AlreadyClosedException)
				{
				}
				_oldReaders.Remove(tuple);
			}
			return array.Length;
		}
	}

	public int CloseAllReaders(Directory dir)
	{
		lock (_locker)
		{
			Tuple<IndexReader, DateTime>[] array = _oldReaders.Where((Tuple<IndexReader, DateTime> x) => x.Item1.Directory().GetLockID() == dir.GetLockID()).ToArray();
			Tuple<IndexReader, DateTime>[] array2 = array;
			foreach (Tuple<IndexReader, DateTime> tuple in array2)
			{
				try
				{
					tuple.Item1.Close();
				}
				catch (AlreadyClosedException)
				{
				}
				_oldReaders.Remove(tuple);
			}
			return array.Length;
		}
	}

	public int CloseAllReaders()
	{
		lock (_locker)
		{
			Tuple<IndexReader, DateTime>[] array = _oldReaders.ToArray();
			Tuple<IndexReader, DateTime>[] array2 = array;
			foreach (Tuple<IndexReader, DateTime> tuple in array2)
			{
				try
				{
					tuple.Item1.Close();
				}
				catch (AlreadyClosedException)
				{
				}
				_oldReaders.Remove(tuple);
			}
			return array.Length;
		}
	}
}
