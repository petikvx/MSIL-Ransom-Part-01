using System;
using System.Collections.Concurrent;
using System.Threading;

namespace pal.EventLogAnalyzer.Threading;

public class WaitQueue : IDisposable
{
	private ConcurrentQueue<ManualResetEventSlim> events;

	public bool ThrowWhenEmpty { get; set; } = false;


	public int Length => events.Count;

	public WaitQueue()
	{
		events = new ConcurrentQueue<ManualResetEventSlim>();
	}

	public void Dispose()
	{
		lock (events)
		{
			foreach (ManualResetEventSlim @event in events)
			{
				@event.Set();
				@event.Dispose();
			}
			for (int i = 0; i < events.Count; i++)
			{
				events.TryDequeue(out var _);
			}
		}
	}

	private ManualResetEventSlim newEvent()
	{
		ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim();
		events.Enqueue(manualResetEventSlim);
		return manualResetEventSlim;
	}

	public void WaitTurn()
	{
		newEvent().Wait();
	}

	public bool WaitTurn(int msTimeout)
	{
		return newEvent().Wait(msTimeout);
	}

	public void FreeNext()
	{
		if (events.TryDequeue(out var result))
		{
			result.Set();
			result.Dispose();
		}
		else if (ThrowWhenEmpty)
		{
			throw new InvalidOperationException("The call queue is empty.");
		}
	}
}
