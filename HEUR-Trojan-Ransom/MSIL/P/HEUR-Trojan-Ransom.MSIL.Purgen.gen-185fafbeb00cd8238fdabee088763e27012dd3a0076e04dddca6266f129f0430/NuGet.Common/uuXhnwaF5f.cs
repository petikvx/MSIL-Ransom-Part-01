using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NuGet.Common;

public class uuXhnwaF5f<T> : IEnumeratorAsync<T>
{
	[CompilerGenerated]
	private sealed class rdP9iS4Kht
	{
		public List<IEnumeratorAsync<T>> PFaiOq0Gps;

		internal bool Z7TRg3awKU(IEnumeratorAsync<T> QbI9zW6XNv)
		{
			return this.completedEnums.Contains(QbI9zW6XNv);
		}
	}

	private readonly HashSet<T> iUmCATWMzs;

	private readonly IComparer<T> Np8ZkmHopg;

	private readonly List<IEnumeratorAsync<T>> _9yZv0U9qA3;

	private IEnumeratorAsync<T> ykImil2Od2;

	private IEnumeratorAsync<T> aQpqKG6DCx;

	private bool seKrlzeT5W;

	public T fladtwktRS
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

	public uuXhnwaF5f(IList<IEnumerableAsync<T>> asyncEnumerables, IComparer<T> orderingComparer, IEqualityComparer<T> equalityComparer)
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

	[AsyncStateMachine(typeof(_003CMoveNextAsync_003Ed__9))]
	public Task<bool> OspDkDH6V5()
	{
		eqguVd3kBv stateMachine = default(eqguVd3kBv);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}
}
