using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GreenPixelsCalculator.Threading;

public class WaitBagSlim : IDisposable
{
	public const ushort MaxLength = 65534;

	private ConcurrentDictionary<ushort, ManualResetEventSlim> events;

	private Dictionary<ushort, object> results;

	public bool ThrowWhenInvalidKey { get; set; } = false;


	public int Length => events.Count;

	public WaitBagSlim()
	{
		events = new ConcurrentDictionary<ushort, ManualResetEventSlim>();
		results = new Dictionary<ushort, object>();
	}

	public void Dispose()
	{
		lock (events)
		{
			foreach (ManualResetEventSlim value in events.Values)
			{
				value.Set();
				value.Dispose();
			}
			events.Clear();
			results.Clear();
		}
	}

	public ushort PrepareTurn()
	{
		ManualResetEventSlim value = new ManualResetEventSlim();
		lock (events)
		{
			ushort num = (ushort)Enumerable.Range(1, 65535).Except(((IEnumerable<ushort>)events.Keys).Select((Func<ushort, int>)((ushort n) => n))).First();
			if (!events.TryAdd(num, value))
			{
				throw new Exception("Unable to add turn to WaitBag.");
			}
			return num;
		}
	}

	private ManualResetEventSlim getTurn(in ushort key)
	{
		if (events.TryGetValue(key, out var value))
		{
			return value;
		}
		if (ThrowWhenInvalidKey)
		{
			throw new InvalidOperationException("WaitBag does not contain this key.");
		}
		return null;
	}

	public void WaitTurn(in ushort key)
	{
		getTurn(in key).Wait();
	}

	public bool WaitTurn(int msTimeout, in ushort key)
	{
		return getTurn(in key).Wait(msTimeout);
	}

	public object PopTurnResult(in ushort key)
	{
		lock (results)
		{
			if (results.ContainsKey(key))
			{
				object result = results[key];
				results.Remove(key);
				return result;
			}
			return null;
		}
	}

	public void Free(ushort key, object turnResult = null)
	{
		if (!events.TryRemove(key, out var value))
		{
			if (ThrowWhenInvalidKey)
			{
				throw new InvalidOperationException("WaitBag does not contain this key.");
			}
			return;
		}
		lock (results)
		{
			results[key] = turnResult;
		}
		value.Set();
		value.Dispose();
	}
}
