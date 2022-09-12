using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class SimpleGeckoEnumerableCollection<T> : IEnumerable<T>, IEnumerable
{
	private Func<IEnumerator<T>> _enumeratorCreator;

	public SimpleGeckoEnumerableCollection(Func<IEnumerator<T>> enumeratorCreator)
	{
		_enumeratorCreator = enumeratorCreator;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _enumeratorCreator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
