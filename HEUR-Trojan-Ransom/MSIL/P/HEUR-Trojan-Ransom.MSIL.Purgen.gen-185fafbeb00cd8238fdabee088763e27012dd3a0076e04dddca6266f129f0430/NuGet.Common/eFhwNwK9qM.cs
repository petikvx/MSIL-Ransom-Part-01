using System.Collections.Generic;

namespace NuGet.Common;

public class eFhwNwK9qM<T> : IEnumerableAsync<T>
{
	private readonly IList<IEnumerableAsync<T>> ti4LV4o3bc;

	private readonly IComparer<T> _5gtyVbywEt;

	private readonly IEqualityComparer<T> rdwMKvMl5y;

	public eFhwNwK9qM(IList<IEnumerableAsync<T>> asyncEnumerables, IComparer<T> comparer, IEqualityComparer<T> equalityComparer)
	{
		this._asyncEnumerables = asyncEnumerables;
		this._comparer = comparer;
		this._equalityComparer = equalityComparer;
	}

	public IEnumeratorAsync<T> kGLKxlk6nU()
	{
		return new NuGet.Common.uuXhnwaF5f<T>(this._asyncEnumerables, this._comparer, this._equalityComparer);
	}
}
