using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal static class SQLiteConnectionPool
{
	private sealed class PoolQueue
	{
		internal readonly Queue<WeakReference> Queue = new Queue<WeakReference>();

		internal int PoolVersion;

		internal int MaxPoolSize;

		internal PoolQueue(int version, int maxSize)
		{
			PoolVersion = version;
			MaxPoolSize = maxSize;
		}
	}

	private static readonly object _syncRoot;

	private static ISQLiteConnectionPool _connectionPool;

	private static SortedList<string, PoolQueue> _queueList;

	private static int _poolVersion;

	private static int _poolOpened;

	private static int _poolClosed;

	[NonSerialized]
	internal static GetString _0088;

	internal static void GetCounts(string fileName, ref Dictionary<string, int> counts, ref int openCount, ref int closeCount, ref int totalCount)
	{
		ISQLiteConnectionPool connectionPool = GetConnectionPool();
		if (connectionPool != null)
		{
			connectionPool.GetCounts(fileName, ref counts, ref openCount, ref closeCount, ref totalCount);
			return;
		}
		lock (_syncRoot)
		{
			openCount = _poolOpened;
			closeCount = _poolClosed;
			if (counts == null)
			{
				counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
			}
			if (fileName != null)
			{
				if (_queueList.TryGetValue(fileName, out var value))
				{
					int num = value.Queue?.Count ?? 0;
					counts.Add(fileName, num);
					totalCount += num;
				}
				return;
			}
			foreach (KeyValuePair<string, PoolQueue> queue in _queueList)
			{
				if (queue.Value != null)
				{
					int num2 = queue.Value.Queue?.Count ?? 0;
					counts.Add(queue.Key, num2);
					totalCount += num2;
				}
			}
		}
	}

	internal static void ClearPool(string fileName)
	{
		ISQLiteConnectionPool connectionPool = GetConnectionPool();
		if (connectionPool != null)
		{
			connectionPool.ClearPool(fileName);
			return;
		}
		lock (_syncRoot)
		{
			if (!_queueList.TryGetValue(fileName, out var value))
			{
				return;
			}
			value.PoolVersion++;
			Queue<WeakReference> queue = value.Queue;
			if (queue == null)
			{
				return;
			}
			while (queue.Count > 0)
			{
				WeakReference weakReference = queue.Dequeue();
				if (weakReference != null)
				{
					SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
					sQLiteConnectionHandle?.Dispose();
					GC.KeepAlive(sQLiteConnectionHandle);
				}
			}
		}
	}

	internal static void ClearAllPools()
	{
		ISQLiteConnectionPool connectionPool = GetConnectionPool();
		if (connectionPool != null)
		{
			connectionPool.ClearAllPools();
			return;
		}
		lock (_syncRoot)
		{
			foreach (KeyValuePair<string, PoolQueue> queue2 in _queueList)
			{
				if (queue2.Value == null)
				{
					continue;
				}
				Queue<WeakReference> queue = queue2.Value.Queue;
				while (queue.Count > 0)
				{
					WeakReference weakReference = queue.Dequeue();
					if (weakReference != null)
					{
						SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
						sQLiteConnectionHandle?.Dispose();
						GC.KeepAlive(sQLiteConnectionHandle);
					}
				}
				if (_poolVersion <= queue2.Value.PoolVersion)
				{
					_poolVersion = queue2.Value.PoolVersion + 1;
				}
			}
			_queueList.Clear();
		}
	}

	internal static void Add(string fileName, SQLiteConnectionHandle handle, int version)
	{
		ISQLiteConnectionPool connectionPool = GetConnectionPool();
		if (connectionPool != null)
		{
			connectionPool.Add(fileName, handle, version);
			return;
		}
		lock (_syncRoot)
		{
			if (_queueList.TryGetValue(fileName, out var value) && version == value.PoolVersion)
			{
				ResizePool(value, add: true);
				Queue<WeakReference> queue = value.Queue;
				if (queue == null)
				{
					return;
				}
				queue.Enqueue(new WeakReference(handle, trackResurrection: false));
				Interlocked.Increment(ref _poolClosed);
			}
			else
			{
				handle.Close();
			}
			GC.KeepAlive(handle);
		}
	}

	internal static SQLiteConnectionHandle Remove(string fileName, int maxPoolSize, out int version)
	{
		ISQLiteConnectionPool connectionPool = GetConnectionPool();
		if (connectionPool != null)
		{
			return connectionPool.Remove(fileName, maxPoolSize, out version) as SQLiteConnectionHandle;
		}
		int version2;
		Queue<WeakReference> queue;
		lock (_syncRoot)
		{
			version = _poolVersion;
			if (!_queueList.TryGetValue(fileName, out var value))
			{
				value = new PoolQueue(_poolVersion, maxPoolSize);
				_queueList.Add(fileName, value);
				return null;
			}
			version2 = (version = value.PoolVersion);
			value.MaxPoolSize = maxPoolSize;
			ResizePool(value, add: false);
			queue = value.Queue;
			if (queue == null)
			{
				return null;
			}
			_queueList.Remove(fileName);
			queue = new Queue<WeakReference>(queue);
		}
		try
		{
			while (queue.Count > 0)
			{
				WeakReference weakReference = queue.Dequeue();
				if (weakReference == null || !(weakReference.Target is SQLiteConnectionHandle sQLiteConnectionHandle))
				{
					continue;
				}
				GC.SuppressFinalize(sQLiteConnectionHandle);
				try
				{
					GC.WaitForPendingFinalizers();
					if (!sQLiteConnectionHandle.IsInvalid && !sQLiteConnectionHandle.IsClosed)
					{
						Interlocked.Increment(ref _poolOpened);
						return sQLiteConnectionHandle;
					}
				}
				finally
				{
					GC.ReRegisterForFinalize(sQLiteConnectionHandle);
				}
				GC.KeepAlive(sQLiteConnectionHandle);
			}
		}
		finally
		{
			lock (_syncRoot)
			{
				bool flag;
				if (_queueList.TryGetValue(fileName, out var value2))
				{
					flag = false;
				}
				else
				{
					flag = true;
					value2 = new PoolQueue(version2, maxPoolSize);
				}
				Queue<WeakReference> queue2 = value2.Queue;
				while (queue.Count > 0)
				{
					queue2.Enqueue(queue.Dequeue());
				}
				ResizePool(value2, add: false);
				if (flag)
				{
					_queueList.Add(fileName, value2);
				}
			}
		}
		return null;
	}

	internal static ISQLiteConnectionPool GetConnectionPool()
	{
		lock (_syncRoot)
		{
			return _connectionPool;
		}
	}

	internal static void SetConnectionPool(ISQLiteConnectionPool connectionPool)
	{
		lock (_syncRoot)
		{
			_connectionPool = connectionPool;
		}
	}

	private static void ResizePool(PoolQueue queue, bool add)
	{
		int num = queue.MaxPoolSize;
		if (add && num > 0)
		{
			num--;
		}
		Queue<WeakReference> queue2 = queue.Queue;
		if (queue2 == null)
		{
			return;
		}
		while (queue2.Count > num)
		{
			WeakReference weakReference = queue2.Dequeue();
			if (weakReference != null)
			{
				SQLiteConnectionHandle sQLiteConnectionHandle = weakReference.Target as SQLiteConnectionHandle;
				sQLiteConnectionHandle?.Dispose();
				GC.KeepAlive(sQLiteConnectionHandle);
			}
		}
	}

	static SQLiteConnectionPool()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteConnectionPool));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_0088(107400879), _0088(107400842)).Replace(_0088(107400837), _0088(107400832)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_0088(107400859)))
		{
			throw new SecurityException(_0088(107400802));
		}
		_syncRoot = new object();
		_connectionPool = null;
		_queueList = new SortedList<string, PoolQueue>(StringComparer.OrdinalIgnoreCase);
		_poolVersion = 1;
		_poolOpened = 0;
		_poolClosed = 0;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
