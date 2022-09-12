using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class GeckoEnumerableCollection<TWrapper, TGeckoObject> : IEnumerable<TWrapper>, IEnumerable
{
	private readonly Func<TGeckoObject, TWrapper> _translator;

	private readonly Func<nsISimpleEnumerator> _enumeratorCreator;

	public GeckoEnumerableCollection(Func<nsISimpleEnumerator> enumeratorCreator, Func<TGeckoObject, TWrapper> translator)
	{
		_enumeratorCreator = enumeratorCreator;
		_translator = translator;
	}

	public IEnumerator<TWrapper> GetEnumerator()
	{
		return new GeckoEnumerator<TWrapper, TGeckoObject>(_enumeratorCreator(), _translator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
