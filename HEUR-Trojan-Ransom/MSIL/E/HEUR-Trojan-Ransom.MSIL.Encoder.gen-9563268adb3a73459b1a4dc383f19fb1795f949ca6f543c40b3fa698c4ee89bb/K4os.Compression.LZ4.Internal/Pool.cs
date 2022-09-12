using System;
using System.Collections.Concurrent;
using System.Threading;

namespace K4os.Compression.LZ4.Internal;

internal class Pool<T>
{
	private readonly ConcurrentQueue<T> _queue;

	private readonly Func<T> _create;

	private readonly Action<T> _reset;

	private readonly Action<T> _destroy;

	private int _freeSlots;

	public Pool(Func<T> create, Action<T> reset, Action<T> destroy, int size)
	{
		_queue = new ConcurrentQueue<T>();
		_create = create;
		_reset = reset ?? ((Action<T>)delegate
		{
		});
		_destroy = destroy ?? ((Action<T>)delegate
		{
		});
		_freeSlots = size;
	}

	public T Borrow()
	{
		if (!_queue.TryDequeue(out var result))
		{
			return _create();
		}
		_reset(result);
		Interlocked.Increment(ref _freeSlots);
		return result;
	}

	public void Return(T resource)
	{
		if (Interlocked.Decrement(ref _freeSlots) < 0)
		{
			Interlocked.Increment(ref _freeSlots);
			_destroy(resource);
		}
		else
		{
			_queue.Enqueue(resource);
		}
	}
}
