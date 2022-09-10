using System.Collections;
using System.Collections.Generic;
using LinqBridge;

namespace System.Linq;

public static class Enumerable
{
	private static class Futures<T>
	{
		public static readonly Func<T> Default = () => default(T);

		public static readonly Func<T> Undefined = delegate
		{
			throw new InvalidOperationException();
		};
	}

	private static class Sequence<T>
	{
		public static readonly IEnumerable<T> Empty = new T[0];
	}

	private sealed class Grouping<K, V> : List<V>, IGrouping<K, V>, IEnumerable<V>, IEnumerable
	{
		public K Key { get; private set; }

		internal Grouping(K key)
		{
			Key = key;
		}
	}

	public static IEnumerable<TSource> AsEnumerable<TSource>(this IEnumerable<TSource> source)
	{
		return source;
	}

	public static IEnumerable<TResult> Empty<TResult>()
	{
		return Sequence<TResult>.Empty;
	}

	public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return CastYield<TResult>(source);
	}

	private static IEnumerable<TResult> CastYield<TResult>(IEnumerable source)
	{
		try
		{
			int num = default(int);
			IEnumerator enumerator = default(IEnumerator);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				enumerator = source.GetEnumerator();
				break;
			case 2:
				break;
			}
			if (!enumerator.MoveNext())
			{
				((_003CCastYield_003Ed__0<TResult>)/*Error near IL_0050: stateMachine*/)._003C_003Em__Finally4();
			}
			else
			{
				object item = enumerator.Current;
				_ = (TResult)item;
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_0087: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_0093: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TResult> OfType<TResult>(this IEnumerable source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return OfTypeYield<TResult>(source);
	}

	private static IEnumerable<TResult> OfTypeYield<TResult>(IEnumerable source)
	{
		try
		{
			int num = default(int);
			IEnumerator enumerator = default(IEnumerator);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				enumerator = source.GetEnumerator();
				break;
			case 2:
				break;
			}
			while (true)
			{
				if (enumerator.MoveNext())
				{
					object item = enumerator.Current;
					if (item is TResult)
					{
						_ = (TResult)item;
						break;
					}
					continue;
				}
				((_003COfTypeYield_003Ed__7<TResult>)/*Error near IL_0070: stateMachine*/)._003C_003Em__Finallyb();
				break;
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_0096: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00a2: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<int> Range(int start, int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", count, null);
		}
		long num = (long)start + (long)count;
		if (num - 1L >= 2147483647L)
		{
			throw new ArgumentOutOfRangeException("count", count, null);
		}
		return RangeYield(start, num);
	}

	private static IEnumerable<int> RangeYield(int start, long end)
	{
		for (int i = start; i < end; i++)
		{
			yield return i;
		}
	}

	public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count)
	{
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", count, null);
		}
		return RepeatYield(element, count);
	}

	private static IEnumerable<TResult> RepeatYield<TResult>(TResult element, int count)
	{
		for (int i = 0; i < count; i++)
		{
			yield return element;
		}
	}

	public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return source.Where((TSource item, int i) => predicate(item));
	}

	public static IEnumerable<TSource> Where<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return WhereYield(source, predicate);
	}

	private static IEnumerable<TSource> WhereYield<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		try
		{
			int num = default(int);
			int i = default(int);
			IEnumerator<TSource> enumerator = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				i = 0;
				enumerator = source.GetEnumerator();
				break;
			case 2:
				break;
			}
			TSource item;
			do
			{
				if (enumerator.MoveNext())
				{
					item = enumerator.Current;
					continue;
				}
				((_003CWhereYield_003Ed__19<TSource>)/*Error near IL_008e: stateMachine*/)._003C_003Em__Finally1d();
				break;
			}
			while (!predicate(item, i++));
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00af: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00bb: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return source.Select((TSource item, int i) => selector(item));
	}

	public static IEnumerable<TResult> Select<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return SelectYield(source, selector);
	}

	private static IEnumerable<TResult> SelectYield<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector)
	{
		try
		{
			int num = default(int);
			int i = default(int);
			IEnumerator<TSource> enumerator = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				i = 0;
				enumerator = source.GetEnumerator();
				break;
			case 2:
				break;
			}
			if (!enumerator.MoveNext())
			{
				((_003CSelectYield_003Ed__23<TSource, TResult>)/*Error near IL_0057: stateMachine*/)._003C_003Em__Finally27();
			}
			else
			{
				TSource item = enumerator.Current;
				selector(item, i);
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00a5: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00b1: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return source.SelectMany((TSource item, int i) => selector(item));
	}

	public static IEnumerable<TResult> SelectMany<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TResult>> selector)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		return source.SelectMany(selector, (TSource item, TResult subitem) => subitem);
	}

	public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		if (collectionSelector == null)
		{
			throw new ArgumentNullException("collectionSelector");
		}
		return source.SelectMany((TSource item, int i) => collectionSelector(item), resultSelector);
	}

	public static IEnumerable<TResult> SelectMany<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (collectionSelector == null)
		{
			throw new ArgumentNullException("collectionSelector");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		return source.SelectManyYield(collectionSelector, resultSelector);
	}

	private static IEnumerable<TResult> SelectManyYield<TSource, TCollection, TResult>(this IEnumerable<TSource> source, Func<TSource, int, IEnumerable<TCollection>> collectionSelector, Func<TSource, TCollection, TResult> resultSelector)
	{
		try
		{
			int num = default(int);
			int num2 = num;
			int i = default(int);
			IEnumerator<TSource> enumerator = default(IEnumerator<TSource>);
			if (num2 == 0)
			{
				i = 0;
				enumerator = source.GetEnumerator();
				goto IL_009d;
			}
			if (num2 == 3)
			{
				goto IL_008a;
			}
			goto end_IL_0000;
			IL_009d:
			TSource item = default(TSource);
			IEnumerator<TCollection> enumerator2 = default(IEnumerator<TCollection>);
			if (enumerator.MoveNext())
			{
				item = enumerator.Current;
				enumerator2 = collectionSelector(item, i++).GetEnumerator();
				goto IL_008a;
			}
			((_003CSelectManyYield_003Ed__31<TSource, TCollection, TResult>)/*Error near IL_00aa: stateMachine*/)._003C_003Em__Finally36();
			goto end_IL_0000;
			IL_008a:
			if (!enumerator2.MoveNext())
			{
				((_003CSelectManyYield_003Ed__31<TSource, TCollection, TResult>)/*Error near IL_0097: stateMachine*/)._003C_003Em__Finally38();
				goto IL_009d;
			}
			TCollection subitem = enumerator2.Current;
			resultSelector(item, subitem);
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00ed: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00f9: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return source.TakeWhile((TSource item, int i) => predicate(item));
	}

	public static IEnumerable<TSource> TakeWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return source.TakeWhileYield(predicate);
	}

	private static IEnumerable<TSource> TakeWhileYield<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		try
		{
			int num = default(int);
			int i = default(int);
			IEnumerator<TSource> enumerator = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				i = 0;
				enumerator = source.GetEnumerator();
				break;
			case 2:
				break;
			}
			if (!enumerator.MoveNext())
			{
				goto IL_00a6;
			}
			TSource item = enumerator.Current;
			if (!predicate(item, i))
			{
				goto IL_00a6;
			}
			goto end_IL_0000;
			IL_00a6:
			((_003CTakeWhileYield_003Ed__3e<TSource>)/*Error near IL_00a6: stateMachine*/)._003C_003Em__Finally42();
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00b0: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00bc: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
	{
		return source.TakeWhile((TSource item, int i) => i < count);
	}

	private static TSource FirstImpl<TSource>(this IEnumerable<TSource> source, Func<TSource> empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (source is IList<TSource> list)
		{
			if (list.Count <= 0)
			{
				return empty();
			}
			return list[0];
		}
		TSource result;
		using (IEnumerator<TSource> enumerator = source.GetEnumerator())
		{
			result = (enumerator.MoveNext() ? enumerator.Current : empty());
		}
		return result;
	}

	public static TSource First<TSource>(this IEnumerable<TSource> source)
	{
		return source.FirstImpl(Futures<TSource>.Undefined);
	}

	public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).First();
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		return source.FirstImpl(Futures<TSource>.Default);
	}

	public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).FirstOrDefault();
	}

	private static TSource LastImpl<TSource>(this IEnumerable<TSource> source, Func<TSource> empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (source is IList<TSource> list)
		{
			if (list.Count <= 0)
			{
				return empty();
			}
			return list[list.Count - 1];
		}
		TSource result;
		using (IEnumerator<TSource> enumerator = source.GetEnumerator())
		{
			if (!enumerator.MoveNext())
			{
				result = empty();
			}
			else
			{
				TSource current = enumerator.Current;
				while (enumerator.MoveNext())
				{
					current = enumerator.Current;
				}
				result = current;
			}
		}
		return result;
	}

	public static TSource Last<TSource>(this IEnumerable<TSource> source)
	{
		return source.LastImpl(Futures<TSource>.Undefined);
	}

	public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).Last();
	}

	public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		return source.LastImpl(Futures<TSource>.Default);
	}

	public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).LastOrDefault();
	}

	private static TSource SingleImpl<TSource>(this IEnumerable<TSource> source, Func<TSource> empty)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		if (enumerator.MoveNext())
		{
			TSource current = enumerator.Current;
			if (!enumerator.MoveNext())
			{
				return current;
			}
			throw new InvalidOperationException();
		}
		return empty();
	}

	public static TSource Single<TSource>(this IEnumerable<TSource> source)
	{
		return source.SingleImpl(Futures<TSource>.Undefined);
	}

	public static TSource Single<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).Single();
	}

	public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
	{
		return source.SingleImpl(Futures<TSource>.Default);
	}

	public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).SingleOrDefault();
	}

	public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (index < 0)
		{
			throw new ArgumentOutOfRangeException("index", index, null);
		}
		if (source is IList<TSource> list)
		{
			return list[index];
		}
		TSource result;
		try
		{
			result = source.SkipWhile((TSource item, int i) => i < index).First();
		}
		catch (InvalidOperationException)
		{
			throw new ArgumentOutOfRangeException("index", index, null);
		}
		return result;
	}

	public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (index < 0)
		{
			return default(TSource);
		}
		if (source is IList<TSource> list)
		{
			if (index >= list.Count)
			{
				return default(TSource);
			}
			return list[index];
		}
		return source.SkipWhile((TSource item, int i) => i < index).FirstOrDefault();
	}

	public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return ReverseYield(source);
	}

	private static IEnumerable<TSource> ReverseYield<TSource>(IEnumerable<TSource> source)
	{
		try
		{
			int num = default(int);
			Stack<TSource>.Enumerator enumerator2 = default(Stack<TSource>.Enumerator);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
			{
				Stack<TSource> stack = new Stack<TSource>();
				foreach (TSource item in source)
				{
					stack.Push(item);
				}
				enumerator2 = stack.GetEnumerator();
				break;
			}
			case 3:
				break;
			}
			if (!enumerator2.MoveNext())
			{
				((_003CReverseYield_003Ed__4f<TSource>)/*Error near IL_0087: stateMachine*/)._003C_003Em__Finally53();
			}
			else
			{
				_ = enumerator2.Current;
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00b9: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00c7: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return source.SkipWhile((TSource item, int i) => predicate(item));
	}

	public static IEnumerable<TSource> SkipWhile<TSource>(this IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return SkipWhileYield(source, predicate);
	}

	private static IEnumerable<TSource> SkipWhileYield<TSource>(IEnumerable<TSource> source, Func<TSource, int, bool> predicate)
	{
		try
		{
			int num = default(int);
			IEnumerator<TSource> e = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
			{
				e = source.GetEnumerator();
				int num2 = 0;
				while (true)
				{
					if (e.MoveNext())
					{
						if (!predicate(e.Current, num2))
						{
							goto end_IL_0008;
						}
						num2++;
						continue;
					}
					((IDisposable)/*Error near IL_0068: stateMachine*/).Dispose();
					break;
				}
				goto end_IL_0000;
			}
			case 2:
				{
					if (e.MoveNext())
					{
						break;
					}
					((_003CSkipWhileYield_003Ed__59<TSource>)/*Error near IL_0084: stateMachine*/)._003C_003Em__Finally5b();
					goto end_IL_0000;
				}
				end_IL_0008:
				break;
			}
			_ = e.Current;
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00aa: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00b6: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static IEnumerable<TSource> Skip<TSource>(this IEnumerable<TSource> source, int count)
	{
		return source.SkipWhile((TSource item, int i) => i < count);
	}

	public static int Count<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (!(source is ICollection collection))
		{
			return source.Aggregate(0, (int count, TSource item) => checked(count + 1));
		}
		return collection.Count;
	}

	public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).Count();
	}

	public static long LongCount<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (!(source is Array array))
		{
			return source.Aggregate(0L, (long count, TSource item) => count + 1L);
		}
		return array.LongLength;
	}

	public static long LongCount<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).LongCount();
	}

	public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		if (first == null)
		{
			throw new ArgumentNullException("first");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second");
		}
		return ConcatYield(first, second);
	}

	private static IEnumerable<TSource> ConcatYield<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		try
		{
			int num = default(int);
			IEnumerator<TSource> enumerator = default(IEnumerator<TSource>);
			IEnumerator<TSource> enumerator2 = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				enumerator = first.GetEnumerator();
				goto case 2;
			case 2:
				if (!enumerator.MoveNext())
				{
					((_003CConcatYield_003Ed__63<TSource>)/*Error near IL_005b: stateMachine*/)._003C_003Em__Finally67();
					enumerator2 = second.GetEnumerator();
					break;
				}
				_ = enumerator.Current;
				goto end_IL_0000;
			case 4:
				break;
			}
			if (!enumerator2.MoveNext())
			{
				((_003CConcatYield_003Ed__63<TSource>)/*Error near IL_00b7: stateMachine*/)._003C_003Em__Finally69();
			}
			else
			{
				_ = enumerator2.Current;
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00e9: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00f5: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return new List<TSource>(source);
	}

	public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source)
	{
		return source.ToList().ToArray();
	}

	public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source)
	{
		return source.Distinct(null);
	}

	public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return DistinctYield(source, comparer);
	}

	private static IEnumerable<TSource> DistinctYield<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer)
	{
		try
		{
			int num = default(int);
			Dictionary<TSource, object> set = default(Dictionary<TSource, object>);
			bool gotNull = default(bool);
			IEnumerator<TSource> enumerator = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				set = new Dictionary<TSource, object>(comparer);
				gotNull = false;
				enumerator = source.GetEnumerator();
				break;
			case 2:
				break;
			}
			while (true)
			{
				if (enumerator.MoveNext())
				{
					TSource item = enumerator.Current;
					if (item == null)
					{
						if (!gotNull)
						{
							break;
						}
					}
					else if (!set.ContainsKey(item))
					{
						set.Add(item, null);
						break;
					}
					continue;
				}
				((_003CDistinctYield_003Ed__6c<TSource>)/*Error near IL_00a8: stateMachine*/)._003C_003Em__Finally71();
				break;
			}
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00e4: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00f0: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.ToLookup(keySelector, (TSource e) => e, null);
	}

	public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return source.ToLookup(keySelector, (TSource e) => e, comparer);
	}

	public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return source.ToLookup(keySelector, elementSelector, null);
	}

	public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		if (elementSelector == null)
		{
			throw new ArgumentNullException("elementSelector");
		}
		Lookup<TKey, TElement> lookup = new Lookup<TKey, TElement>(comparer);
		foreach (TSource item in source)
		{
			TKey key = keySelector(item);
			Grouping<TKey, TElement> grouping = (Grouping<TKey, TElement>)lookup.Find(key);
			if (grouping == null)
			{
				grouping = new Grouping<TKey, TElement>(key);
				lookup.Add(grouping);
			}
			grouping.Add(elementSelector(item));
		}
		return lookup;
	}

	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.GroupBy(keySelector, null);
	}

	public static IEnumerable<IGrouping<TKey, TSource>> GroupBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return source.GroupBy(keySelector, (TSource e) => e, comparer);
	}

	public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return source.GroupBy(keySelector, elementSelector, null);
	}

	public static IEnumerable<IGrouping<TKey, TElement>> GroupBy<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		if (elementSelector == null)
		{
			throw new ArgumentNullException("elementSelector");
		}
		return source.ToLookup(keySelector, elementSelector, comparer);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector)
	{
		return source.GroupBy(keySelector, resultSelector, null);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TKey, IEnumerable<TSource>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		return from g in source.ToLookup(keySelector, comparer)
			select resultSelector(g.Key, g);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector)
	{
		return source.GroupBy(keySelector, elementSelector, resultSelector, null);
	}

	public static IEnumerable<TResult> GroupBy<TSource, TKey, TElement, TResult>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		if (elementSelector == null)
		{
			throw new ArgumentNullException("elementSelector");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		return from g in source.ToLookup(keySelector, elementSelector, comparer)
			select resultSelector(g.Key, g);
	}

	public static TSource Aggregate<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, TSource> func)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (func == null)
		{
			throw new ArgumentNullException("func");
		}
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			throw new InvalidOperationException();
		}
		return enumerator.Renumerable().Skip(1).Aggregate(enumerator.Current, func);
	}

	public static TAccumulate Aggregate<TSource, TAccumulate>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
	{
		return source.Aggregate(seed, func, (TAccumulate r) => r);
	}

	public static TResult Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (func == null)
		{
			throw new ArgumentNullException("func");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		TAccumulate val = seed;
		foreach (TSource item in source)
		{
			val = func(val, item);
		}
		return resultSelector(val);
	}

	public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return first.Union(second, null);
	}

	public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		return first.Concat(second).Distinct(comparer);
	}

	public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source)
	{
		return source.DefaultIfEmpty(default(TSource));
	}

	public static IEnumerable<TSource> DefaultIfEmpty<TSource>(this IEnumerable<TSource> source, TSource defaultValue)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return DefaultIfEmptyYield(source, defaultValue);
	}

	private static IEnumerable<TSource> DefaultIfEmptyYield<TSource>(IEnumerable<TSource> source, TSource defaultValue)
	{
		try
		{
			int num = default(int);
			IEnumerator<TSource> e = default(IEnumerator<TSource>);
			switch (num)
			{
			default:
				goto end_IL_0000;
			case 0:
				e = source.GetEnumerator();
				if (e.MoveNext())
				{
					break;
				}
				goto end_IL_0000;
			case 3:
				if (e.MoveNext())
				{
					break;
				}
				goto case 2;
			case 2:
				((_003CDefaultIfEmptyYield_003Ed__7e<TSource>)/*Error near IL_007f: stateMachine*/)._003C_003Em__Finally80();
				goto end_IL_0000;
			}
			_ = e.Current;
			end_IL_0000:;
		}
		catch
		{
			//try-fault
			((IDisposable)/*Error near IL_00a5: stateMachine*/).Dispose();
			throw;
		}
		/*Error near IL_00b1: Unexpected return in MoveNext()*/;
		yield break;
	}

	public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		bool result;
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				continue;
			}
			result = false;
			goto IL_0052;
		}
		return true;
		IL_0052:
		return result;
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		using IEnumerator<TSource> enumerator = source.GetEnumerator();
		return enumerator.MoveNext();
	}

	public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
	{
		return source.Where(predicate).Any();
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		return source.Contains(value, null);
	}

	public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (comparer == null && source is ICollection<TSource> collection)
		{
			return collection.Contains(value);
		}
		comparer = comparer ?? EqualityComparer<TSource>.Default;
		return source.Any((TSource item) => comparer.Equals(item, value));
	}

	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return first.SequenceEqual(second, null);
	}

	public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		if (first == null)
		{
			throw new ArgumentNullException("frist");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second");
		}
		comparer = comparer ?? EqualityComparer<TSource>.Default;
		bool result;
		using (IEnumerator<TSource> enumerator = first.GetEnumerator())
		{
			using IEnumerator<TSource> enumerator2 = second.GetEnumerator();
			while (true)
			{
				if (enumerator.MoveNext())
				{
					if (enumerator2.MoveNext())
					{
						if (!comparer.Equals(enumerator.Current, enumerator2.Current))
						{
							break;
						}
						continue;
					}
					result = false;
				}
				else
				{
					result = !enumerator2.MoveNext();
				}
				goto IL_0088;
			}
		}
		return false;
		IL_0088:
		return result;
	}

	private static TSource MinMaxImpl<TSource>(this IEnumerable<TSource> source, Func<TSource, TSource, bool> lesser)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (typeof(TSource).IsClass)
		{
			source = source.Where((TSource e) => e != null).DefaultIfEmpty();
		}
		return source.Aggregate((TSource a, TSource item) => (!lesser(a, item)) ? item : a);
	}

	private static TSource? MinMaxImpl<TSource>(this IEnumerable<TSource?> source, TSource? seed, Func<TSource?, TSource?, bool> lesser) where TSource : struct
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Aggregate(seed, (TSource? a, TSource? item) => (!lesser(a, item)) ? item : a);
	}

	public static TSource Min<TSource>(this IEnumerable<TSource> source)
	{
		Comparer<TSource> comparer = Comparer<TSource>.Default;
		return source.MinMaxImpl((TSource x, TSource y) => comparer.Compare(x, y) < 0);
	}

	public static TResult Min<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		return source.Select(selector).Min();
	}

	public static TSource Max<TSource>(this IEnumerable<TSource> source)
	{
		Comparer<TSource> comparer = Comparer<TSource>.Default;
		return source.MinMaxImpl((TSource x, TSource y) => comparer.Compare(x, y) > 0);
	}

	public static TResult Max<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
	{
		return source.Select(selector).Max();
	}

	private static IEnumerable<T> Renumerable<T>(this IEnumerator<T> e)
	{
		do
		{
			yield return e.Current;
		}
		while (e.MoveNext());
	}

	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.OrderBy(keySelector, null);
	}

	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, descending: false);
	}

	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.OrderByDescending(keySelector, null);
	}

	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (source == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer, descending: true);
	}

	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.ThenBy(keySelector, null);
	}

	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.CreateOrderedEnumerable(keySelector, comparer, descending: false);
	}

	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.ThenByDescending(keySelector, null);
	}

	public static IOrderedEnumerable<TSource> ThenByDescending<TSource, TKey>(this IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.CreateOrderedEnumerable(keySelector, comparer, descending: true);
	}

	private static IEnumerable<TSource> IntersectExceptImpl<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer, bool flag)
	{
		if (first == null)
		{
			throw new ArgumentNullException("first");
		}
		if (second == null)
		{
			throw new ArgumentNullException("second");
		}
		List<Key<TSource>> list = new List<Key<TSource>>();
		Dictionary<Key<TSource>, bool> flags = new Dictionary<Key<TSource>, bool>(new KeyComparer<TSource>(comparer));
		foreach (Key<TSource> item in from item in first
			select new Key<TSource>(item) into item
			where !flags.ContainsKey(item)
			select item)
		{
			flags.Add(item, !flag);
			list.Add(item);
		}
		foreach (Key<TSource> item2 in from item in second
			select new Key<TSource>(item) into item
			where flags.ContainsKey(item)
			select item)
		{
			flags[item2] = flag;
		}
		return from item in list
			where flags[item]
			select item.Value;
	}

	public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return first.Intersect(second, null);
	}

	public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		return first.IntersectExceptImpl(second, comparer, flag: true);
	}

	public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
	{
		return first.Except(second, null);
	}

	public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
	{
		return first.IntersectExceptImpl(second, comparer, flag: false);
	}

	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
	{
		return source.ToDictionary(keySelector, null);
	}

	public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer)
	{
		return source.ToDictionary(keySelector, (TSource e) => e, comparer);
	}

	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector)
	{
		return source.ToDictionary(keySelector, elementSelector, null);
	}

	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		if (elementSelector == null)
		{
			throw new ArgumentNullException("elementSelector");
		}
		Dictionary<TKey, TElement> dictionary = new Dictionary<TKey, TElement>(comparer);
		foreach (TSource item in source)
		{
			dictionary.Add(keySelector(item), elementSelector(item));
		}
		return dictionary;
	}

	public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector)
	{
		return outer.Join(inner, outerKeySelector, innerKeySelector, resultSelector, null);
	}

	public static IEnumerable<TResult> Join<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, TInner, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (outer == null)
		{
			throw new ArgumentNullException("outer");
		}
		if (inner == null)
		{
			throw new ArgumentNullException("inner");
		}
		if (outerKeySelector == null)
		{
			throw new ArgumentNullException("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw new ArgumentNullException("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		ILookup<TKey, TInner> lookup = inner.ToLookup(innerKeySelector, comparer);
		return from o in outer
			from i in lookup[outerKeySelector(o)]
			select resultSelector(o, i);
	}

	public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector)
	{
		return outer.GroupJoin(inner, outerKeySelector, innerKeySelector, resultSelector, null);
	}

	public static IEnumerable<TResult> GroupJoin<TOuter, TInner, TKey, TResult>(this IEnumerable<TOuter> outer, IEnumerable<TInner> inner, Func<TOuter, TKey> outerKeySelector, Func<TInner, TKey> innerKeySelector, Func<TOuter, IEnumerable<TInner>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
		if (outer == null)
		{
			throw new ArgumentNullException("outer");
		}
		if (inner == null)
		{
			throw new ArgumentNullException("inner");
		}
		if (outerKeySelector == null)
		{
			throw new ArgumentNullException("outerKeySelector");
		}
		if (innerKeySelector == null)
		{
			throw new ArgumentNullException("innerKeySelector");
		}
		if (resultSelector == null)
		{
			throw new ArgumentNullException("resultSelector");
		}
		ILookup<TKey, TInner> lookup = inner.ToLookup(innerKeySelector, comparer);
		return outer.Select((TOuter o) => resultSelector(o, lookup[outerKeySelector(o)]));
	}

	public static int Sum(this IEnumerable<int> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		int num = 0;
		foreach (int item in source)
		{
			num = checked(num + item);
		}
		return num;
	}

	public static int Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double Average(this IEnumerable<int> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (int item in source)
			{
				num += item;
				num2++;
			}
			if (num2 == 0L)
			{
				throw new InvalidOperationException();
			}
			return (double)num / (double)num2;
		}
	}

	public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
	{
		return source.Select(selector).Average();
	}

	public static int? Sum(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		int num = 0;
		foreach (int? item in source)
		{
			num = checked(num + (item ?? 0));
		}
		return num;
	}

	public static int? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double? Average(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (int? item in source.Where((int? n) => n.HasValue))
			{
				num += item.Value;
				num2++;
			}
			if (num2 == 0L)
			{
				return null;
			}
			return new double?(num) / (double)num2;
		}
	}

	public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Average();
	}

	public static int? Min(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((int? x) => x.HasValue).MinMaxImpl(null, (int? min, int? x) => min < x);
	}

	public static int? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Min();
	}

	public static int? Max(this IEnumerable<int?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((int? x) => x.HasValue).MinMaxImpl(null, (int? max, int? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
	}

	public static int? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, int?> selector)
	{
		return source.Select(selector).Max();
	}

	public static long Sum(this IEnumerable<long> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		long num = 0L;
		foreach (long item in source)
		{
			num = checked(num + item);
		}
		return num;
	}

	public static long Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double Average(this IEnumerable<long> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (long item in source)
			{
				num += item;
				num2++;
			}
			if (num2 == 0L)
			{
				throw new InvalidOperationException();
			}
			return (double)num / (double)num2;
		}
	}

	public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long> selector)
	{
		return source.Select(selector).Average();
	}

	public static long? Sum(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		long num = 0L;
		foreach (long? item in source)
		{
			num = checked(num + (item ?? 0L));
		}
		return num;
	}

	public static long? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double? Average(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		long num = 0L;
		long num2 = 0L;
		checked
		{
			foreach (long? item in source.Where((long? n) => n.HasValue))
			{
				num += item.Value;
				num2++;
			}
			if (num2 == 0L)
			{
				return null;
			}
			return new double?(num) / (double)num2;
		}
	}

	public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Average();
	}

	public static long? Min(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((long? x) => x.HasValue).MinMaxImpl(null, (long? min, long? x) => min < x);
	}

	public static long? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Min();
	}

	public static long? Max(this IEnumerable<long?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((long? x) => x.HasValue).MinMaxImpl(null, (long? max, long? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
	}

	public static long? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, long?> selector)
	{
		return source.Select(selector).Max();
	}

	public static float Sum(this IEnumerable<float> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		float num = 0f;
		foreach (float item in source)
		{
			float num2 = item;
			num += num2;
		}
		return num;
	}

	public static float Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
	{
		return source.Select(selector).Sum();
	}

	public static float Average(this IEnumerable<float> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		float num = 0f;
		long num2 = 0L;
		foreach (float item in source)
		{
			float num3 = item;
			num += num3;
			num2 = checked(num2 + 1L);
		}
		if (num2 == 0L)
		{
			throw new InvalidOperationException();
		}
		return num / (float)num2;
	}

	public static float Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float> selector)
	{
		return source.Select(selector).Average();
	}

	public static float? Sum(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		float num = 0f;
		foreach (float? item in source)
		{
			num += item ?? 0f;
		}
		return num;
	}

	public static float? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static float? Average(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		float num = 0f;
		long num2 = 0L;
		foreach (float? item in source.Where((float? n) => n.HasValue))
		{
			num += item.Value;
			num2 = checked(num2 + 1L);
		}
		if (num2 == 0L)
		{
			return null;
		}
		return new float?(num) / (float)num2;
	}

	public static float? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Average();
	}

	public static float? Min(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((float? x) => x.HasValue).MinMaxImpl(null, (float? min, float? x) => min < x);
	}

	public static float? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Min();
	}

	public static float? Max(this IEnumerable<float?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((float? x) => x.HasValue).MinMaxImpl(null, (float? max, float? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
	}

	public static float? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, float?> selector)
	{
		return source.Select(selector).Max();
	}

	public static double Sum(this IEnumerable<double> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		double num = 0.0;
		foreach (double item in source)
		{
			double num2 = item;
			num += num2;
		}
		return num;
	}

	public static double Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double Average(this IEnumerable<double> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		double num = 0.0;
		long num2 = 0L;
		foreach (double item in source)
		{
			double num3 = item;
			num += num3;
			num2 = checked(num2 + 1L);
		}
		if (num2 == 0L)
		{
			throw new InvalidOperationException();
		}
		return num / (double)num2;
	}

	public static double Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double> selector)
	{
		return source.Select(selector).Average();
	}

	public static double? Sum(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		double num = 0.0;
		foreach (double? item in source)
		{
			num += item ?? 0.0;
		}
		return num;
	}

	public static double? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static double? Average(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		double num = 0.0;
		long num2 = 0L;
		foreach (double? item in source.Where((double? n) => n.HasValue))
		{
			num += item.Value;
			num2 = checked(num2 + 1L);
		}
		if (num2 == 0L)
		{
			return null;
		}
		return new double?(num) / (double)num2;
	}

	public static double? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Average();
	}

	public static double? Min(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((double? x) => x.HasValue).MinMaxImpl(null, (double? min, double? x) => min < x);
	}

	public static double? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Min();
	}

	public static double? Max(this IEnumerable<double?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((double? x) => x.HasValue).MinMaxImpl(null, (double? max, double? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
	}

	public static double? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, double?> selector)
	{
		return source.Select(selector).Max();
	}

	public static decimal Sum(this IEnumerable<decimal> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		decimal result = 0m;
		foreach (decimal item in source)
		{
			result += item;
		}
		return result;
	}

	public static decimal Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
	{
		return source.Select(selector).Sum();
	}

	public static decimal Average(this IEnumerable<decimal> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		decimal num = 0m;
		long num2 = 0L;
		foreach (decimal item in source)
		{
			num += item;
			num2 = checked(num2 + 1L);
		}
		if (num2 == 0L)
		{
			throw new InvalidOperationException();
		}
		return num / (decimal)num2;
	}

	public static decimal Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal> selector)
	{
		return source.Select(selector).Average();
	}

	public static decimal? Sum(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		decimal value = 0m;
		foreach (decimal? item in source)
		{
			value += item ?? 0m;
		}
		return value;
	}

	public static decimal? Sum<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Sum();
	}

	public static decimal? Average(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		decimal value = 0m;
		long num = 0L;
		foreach (decimal? item in source.Where((decimal? n) => n.HasValue))
		{
			value += item.Value;
			num = checked(num + 1L);
		}
		if (num == 0L)
		{
			return null;
		}
		return (decimal?)value / (decimal?)num;
	}

	public static decimal? Average<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Average();
	}

	public static decimal? Min(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((decimal? x) => x.HasValue).MinMaxImpl(null, (decimal? min, decimal? x) => min < x);
	}

	public static decimal? Min<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Min();
	}

	public static decimal? Max(this IEnumerable<decimal?> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.Where((decimal? x) => x.HasValue).MinMaxImpl(null, (decimal? max, decimal? x) => !x.HasValue || (max.HasValue && x.Value < max.Value));
	}

	public static decimal? Max<TSource>(this IEnumerable<TSource> source, Func<TSource, decimal?> selector)
	{
		return source.Select(selector).Max();
	}
}
