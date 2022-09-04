using System.Collections.Generic;

namespace System.Data.SQLite;

internal static class SQLiteConnectionPool
{
	internal class Pool
	{
		internal readonly Queue<WeakReference> Queue = new Queue<WeakReference>();

		internal int PoolVersion;

		internal int MaxPoolSize;

		internal Pool(int version, int maxSize)
		{
			PoolVersion = version;
			MaxPoolSize = maxSize;
		}
	}

	private static SortedList<string, Pool> _connections = new SortedList<string, Pool>(StringComparer.OrdinalIgnoreCase);

	private static int _poolVersion = 1;

	internal static SQLiteConnectionHandle Remove(string fileName, int maxPoolSize, out int version)
	{
		lock (_connections)
		{
			version = _poolVersion;
			if (!_connections.TryGetValue(fileName, out var value))
			{
				value = new Pool(_poolVersion, maxPoolSize);
				_connections.Add(fileName, value);
				return null;
			}
			version = value.PoolVersion;
			value.MaxPoolSize = maxPoolSize;
			ResizePool(value, forAdding: false);
			SQLiteConnectionHandle sQLiteConnectionHandle;
			do
			{
				if (value.Queue.Count > 0)
				{
					WeakReference weakReference = value.Queue.Dequeue();
					sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
					continue;
				}
				return null;
			}
			while (sQLiteConnectionHandle == null);
			return sQLiteConnectionHandle;
		}
	}

	internal static void ClearAllPools()
	{
		lock (_connections)
		{
			foreach (KeyValuePair<string, Pool> connection in _connections)
			{
				while (connection.Value.Queue.Count > 0)
				{
					WeakReference weakReference = connection.Value.Queue.Dequeue();
					if (weakReference.Target is SQLiteConnectionHandle sQLiteConnectionHandle)
					{
						sQLiteConnectionHandle.Dispose();
					}
				}
				if (_poolVersion <= connection.Value.PoolVersion)
				{
					_poolVersion = connection.Value.PoolVersion + 1;
				}
			}
			_connections.Clear();
		}
	}

	internal static void ClearPool(string fileName)
	{
		lock (_connections)
		{
			if (!_connections.TryGetValue(fileName, out var value))
			{
				return;
			}
			value.PoolVersion++;
			while (value.Queue.Count > 0)
			{
				WeakReference weakReference = value.Queue.Dequeue();
				if (weakReference.Target is SQLiteConnectionHandle sQLiteConnectionHandle)
				{
					sQLiteConnectionHandle.Dispose();
				}
			}
		}
	}

	internal static void Add(string fileName, SQLiteConnectionHandle hdl, int version)
	{
		lock (_connections)
		{
			if (_connections.TryGetValue(fileName, out var value) && version == value.PoolVersion)
			{
				ResizePool(value, forAdding: true);
				value.Queue.Enqueue(new WeakReference(hdl, trackResurrection: false));
				GC.KeepAlive(hdl);
			}
			else
			{
				hdl.Close();
			}
		}
	}

	private static void ResizePool(Pool queue, bool forAdding)
	{
		int num = queue.MaxPoolSize;
		if (forAdding && num > 0)
		{
			num--;
		}
		while (queue.Queue.Count > num)
		{
			WeakReference weakReference = queue.Queue.Dequeue();
			if (weakReference.Target is SQLiteConnectionHandle sQLiteConnectionHandle)
			{
				sQLiteConnectionHandle.Dispose();
			}
		}
	}
}
