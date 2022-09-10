using System.Collections;
using System.Collections.Generic;
using LinqBridge;

namespace System.Linq;

internal sealed class Lookup<TKey, TElement> : IEnumerable, IEnumerable<IGrouping<TKey, TElement>>, ILookup<TKey, TElement>
{
	private readonly Dictionary<Key<TKey>, IGrouping<TKey, TElement>> _map;

	private readonly List<Key<TKey>> _orderedKeys;

	public int Count => _map.Count;

	public IEnumerable<TElement> this[TKey key]
	{
		get
		{
			if (!_map.TryGetValue(new Key<TKey>(key), out var value))
			{
				return Enumerable.Empty<TElement>();
			}
			return value;
		}
	}

	internal Lookup(IEqualityComparer<TKey> comparer)
	{
		_map = new Dictionary<Key<TKey>, IGrouping<TKey, TElement>>(new KeyComparer<TKey>(comparer));
		_orderedKeys = new List<Key<TKey>>();
	}

	internal void Add(IGrouping<TKey, TElement> item)
	{
		Key<TKey> key = new Key<TKey>(item.Key);
		_map.Add(key, item);
		_orderedKeys.Add(key);
	}

	internal IEnumerable<TElement> Find(TKey key)
	{
		if (!_map.TryGetValue(new Key<TKey>(key), out var value))
		{
			return null;
		}
		return value;
	}

	public bool Contains(TKey key)
	{
		return _map.ContainsKey(new Key<TKey>(key));
	}

	public IEnumerable<TResult> ApplyResultSelector<TResult>(Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
	{
		try
		{
			int num = default(int);
			Dictionary<Key<TKey>, IGrouping<TKey, TElement>>.Enumerator enumerator = default(Dictionary<Key<TKey>, IGrouping<TKey, TElement>>.Enumerator);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				if (resultSelector == null)
				{
					throw new ArgumentNullException("resultSelector");
				}
				enumerator = _map.GetEnumerator();
				break;
			case 2:
				break;
			}
			if (!enumerator.MoveNext())
			{
				((_003CApplyResultSelector_003Ed__0<TResult>)/*Error near IL_0068: stateMachine*/)._003C_003Em__Finally3();
			}
			else
			{
				KeyValuePair<Key<TKey>, IGrouping<TKey, TElement>> pair = enumerator.Current;
				KeyValuePair<Key<TKey>, IGrouping<TKey, TElement>> keyValuePair = pair;
				TKey value = keyValuePair.Key.Value;
				KeyValuePair<Key<TKey>, IGrouping<TKey, TElement>> keyValuePair2 = pair;
				resultSelector(value, keyValuePair2.Value);
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00c4: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00d2: Unexpected return in MoveNext()*/;
		yield break;
	}

	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		try
		{
			int num = default(int);
			List<Key<TKey>>.Enumerator enumerator = default(List<Key<TKey>>.Enumerator);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				enumerator = _orderedKeys.GetEnumerator();
				break;
			case 2:
				break;
			}
			if (!enumerator.MoveNext())
			{
				((_003CGetEnumerator_003Ed__6)/*Error near IL_0055: stateMachine*/)._003C_003Em__Finally9();
			}
			else
			{
				Key<TKey> key = enumerator.Current;
				_ = _map[key];
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_0097: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00a3: Unexpected return in MoveNext()*/;
		yield break;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
