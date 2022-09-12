using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class GeckoEnumerator<TWrapper, TGeckoObject> : IEnumerator<TWrapper>, IDisposable, IEnumerator
{
	private nsISimpleEnumerator _enumerator;

	private TGeckoObject _current;

	private Func<TGeckoObject, TWrapper> _translator;

	public TWrapper Current => _translator(_current);

	object IEnumerator.Current => Current;

	internal GeckoEnumerator(nsISimpleEnumerator enumerator, Func<TGeckoObject, TWrapper> translator)
	{
		_enumerator = enumerator;
		_translator = translator;
	}

	public void Dispose()
	{
		if (_enumerator is IDisposable disposable)
		{
			disposable.Dispose();
		}
		_enumerator = null;
		if ((object)_current is IDisposable disposable2)
		{
			disposable2.Dispose();
		}
		_current = default(TGeckoObject);
		_translator = null;
		GC.SuppressFinalize(this);
	}

	public bool MoveNext()
	{
		bool result;
		if (result = _enumerator.HasMoreElements())
		{
			nsISupports next = _enumerator.GetNext();
			_current = (TGeckoObject)next;
		}
		return result;
	}

	public void Reset()
	{
		throw new NotSupportedException("Reset is not supported for this enumeration");
	}
}
