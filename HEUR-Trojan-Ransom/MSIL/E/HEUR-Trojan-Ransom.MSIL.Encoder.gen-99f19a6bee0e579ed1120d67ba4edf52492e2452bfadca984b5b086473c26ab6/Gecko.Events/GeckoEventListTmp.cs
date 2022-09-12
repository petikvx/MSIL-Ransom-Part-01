using System;
using System.Collections.Generic;

namespace Gecko.Events;

public sealed class GeckoEventListTmp
{
	private Dictionary<int, Delegate> _delegates = new Dictionary<int, Delegate>();

	public Delegate this[int key]
	{
		get
		{
			Delegate value = null;
			if (_delegates.TryGetValue(key, out value))
			{
				return value;
			}
			return null;
		}
		set
		{
			Delegate value2 = null;
			if (_delegates.TryGetValue(key, out value2))
			{
				_delegates[key] = value;
			}
			else
			{
				_delegates.Add(key, value);
			}
		}
	}

	public void AddHandler(int key, Delegate handler)
	{
		Delegate value = null;
		if (_delegates.TryGetValue(key, out value))
		{
			_delegates[key] = Delegate.Combine(value, handler);
		}
		else
		{
			_delegates.Add(key, handler);
		}
	}

	public void RemoveHandler(int key, Delegate handler)
	{
		Delegate value = null;
		if (_delegates.TryGetValue(key, out value))
		{
			_delegates[key] = Delegate.Remove(value, handler);
		}
	}
}
