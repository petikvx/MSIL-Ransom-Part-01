using System.Collections.Generic;

namespace LinqBridge;

internal sealed class KeyComparer<T> : IEqualityComparer<Key<T>>
{
	private readonly IEqualityComparer<T> _innerComparer;

	public KeyComparer(IEqualityComparer<T> innerComparer)
	{
		_innerComparer = innerComparer ?? EqualityComparer<T>.Default;
	}

	public bool Equals(Key<T> x, Key<T> y)
	{
		return _innerComparer.Equals(x.Value, y.Value);
	}

	public int GetHashCode(Key<T> obj)
	{
		if (obj.Value != null)
		{
			return _innerComparer.GetHashCode(obj.Value);
		}
		return 0;
	}
}
