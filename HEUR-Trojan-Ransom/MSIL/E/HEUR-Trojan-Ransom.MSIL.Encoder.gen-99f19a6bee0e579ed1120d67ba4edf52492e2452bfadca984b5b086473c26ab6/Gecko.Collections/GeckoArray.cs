using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class GeckoArray<TWrapper, TGeckoObject> : IEnumerable<TWrapper>, IGeckoArray<TWrapper>, IEnumerable where TWrapper : class where TGeckoObject : class
{
	private nsIArray _array;

	private Func<TGeckoObject, TWrapper> _translator;

	public int Length => (int)_array.GetLengthAttribute();

	public TWrapper this[int index]
	{
		get
		{
			TGeckoObject elementAs = _array.GetElementAs<TGeckoObject>(index);
			if (elementAs == null)
			{
				return null;
			}
			return _translator(elementAs);
		}
	}

	internal GeckoArray(nsIArray array, Func<TGeckoObject, TWrapper> translator)
	{
		_array = array;
		_translator = translator;
	}

	public IEnumerator<TWrapper> GetEnumerator()
	{
		return new GeckoEnumerator<TWrapper, TGeckoObject>(_array.Enumerate(), _translator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
