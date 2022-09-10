using System;
using System.Collections.Concurrent;
using System.Threading;

namespace MOISHE.Core;

public abstract class AbstractWorker
{
	protected Thread runner;

	protected bool _run;

	public static BlockingCollection<T> NewBlockingQueue<T>(int capacity)
	{
		ConcurrentQueue<T> collection = new ConcurrentQueue<T>();
		return new BlockingCollection<T>(collection, capacity);
	}

	public static void ExecuteOnce(ThreadStart Entrypoint)
	{
		Thread thread = new Thread(Entrypoint);
		thread.IsBackground = true;
		thread.Start();
	}

	protected abstract void Execute();

	public void Start()
	{
		lock (this)
		{
			if (runner == null)
			{
				_run = true;
				runner = new Thread(ThreadEntry);
				runner.IsBackground = true;
				runner.Priority = ThreadPriority.BelowNormal;
			}
			runner.Start();
		}
	}

	public void Cancel()
	{
		if (!_run)
		{
			return;
		}
		lock (this)
		{
			_run = false;
			if (runner != null && runner.IsAlive)
			{
				if (runner.ThreadState != ThreadState.Aborted)
				{
					runner.Abort();
				}
				runner.Join();
				runner = null;
			}
		}
	}

	protected void ThreadEntry()
	{
		try
		{
			Execute();
		}
		catch (Exception)
		{
		}
		finally
		{
			runner = null;
		}
	}
}
