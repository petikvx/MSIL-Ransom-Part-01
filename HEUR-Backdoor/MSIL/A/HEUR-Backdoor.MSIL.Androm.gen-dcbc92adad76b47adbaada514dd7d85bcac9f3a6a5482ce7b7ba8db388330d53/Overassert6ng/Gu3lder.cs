using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Geopoliti7ians;
using ns1;

namespace Overassert6ng;

public class Gu3lder<T> : IEnumeratorAsync<T>
{
	private readonly HashSet<T> Re8etter;

	private readonly IComparer<T> Intracutaneou2;

	private readonly List<IEnumeratorAsync<T>> Halakhi6t;

	private IEnumeratorAsync<T> Palt3ie3;

	private IEnumeratorAsync<T> L3femansh3ps;

	private bool Gi5lf5iends;

	public T Current
	{
		get
		{
			if (this._currentEnumeratorAsync == null)
			{
				return default(T);
			}
			return this._currentEnumeratorAsync.Current;
		}
	}

	public Gu3lder(IList<IEnumerableAsync<T>> asyncEnumerables, IComparer<T> orderingComparer, IEqualityComparer<T> equalityComparer)
	{
		this._asyncEnumerators = new List<IEnumeratorAsync<T>>();
		this.firstPass = true;
		base._002Ector();
		if (asyncEnumerables == null)
		{
			throw new ArgumentNullException("asyncEnumerables");
		}
		foreach (IEnumerableAsync<T> asyncEnumerable in asyncEnumerables)
		{
			IEnumeratorAsync<T> enumeratorAsync = asyncEnumerable.GetEnumeratorAsync();
			this._asyncEnumerators.Add(enumeratorAsync);
		}
		IComparer<T> orderingComparer2;
		if (orderingComparer != null)
		{
			orderingComparer2 = orderingComparer;
		}
		else
		{
			IComparer<T> @default = Comparer<T>.Default;
			orderingComparer2 = @default;
		}
		this._orderingComparer = orderingComparer2;
		this._seen = ((equalityComparer == null) ? new HashSet<T>() : new HashSet<T>(equalityComparer));
	}

	public async Task<bool> P0tsaws()
	{
		while (this._asyncEnumerators.Count > 0)
		{
			T currentValue = default(T);
			bool hasValue = false;
			List<IEnumeratorAsync<T>> completedEnums = null;
			if (this.firstPass)
			{
				foreach (IEnumeratorAsync<T> enumerator in this._asyncEnumerators)
				{
					if (await enumerator.MoveNextAsync())
					{
						if (!hasValue || this._orderingComparer.Compare(currentValue, enumerator.Current) > 0)
						{
							hasValue = true;
							currentValue = enumerator.Current;
							this._currentEnumeratorAsync = enumerator;
						}
					}
					else
					{
						if (completedEnums == null)
						{
							completedEnums = new List<IEnumeratorAsync<T>>();
						}
						completedEnums.Add(enumerator);
					}
				}
				this.firstPass = false;
			}
			else
			{
				foreach (IEnumeratorAsync<T> enumerator in this._asyncEnumerators)
				{
					bool flag = true;
					if (enumerator == this._lastAwaitedEnumeratorAsync)
					{
						bool num = await enumerator.MoveNextAsync();
						flag = num;
						if (!num)
						{
							if (completedEnums == null)
							{
								completedEnums = new List<IEnumeratorAsync<T>>();
							}
							completedEnums.Add(enumerator);
						}
					}
					if (flag && (!hasValue || this._orderingComparer.Compare(currentValue, enumerator.Current) > 0))
					{
						hasValue = true;
						currentValue = enumerator.Current;
						this._currentEnumeratorAsync = enumerator;
					}
				}
			}
			this._lastAwaitedEnumeratorAsync = this._currentEnumeratorAsync;
			if (completedEnums != null)
			{
				this._asyncEnumerators.RemoveAll((IEnumeratorAsync<T> obj) => completedEnums.Contains(obj));
			}
			if (hasValue && this._seen.Add(currentValue))
			{
				return true;
			}
		}
		return false;
	}
}
