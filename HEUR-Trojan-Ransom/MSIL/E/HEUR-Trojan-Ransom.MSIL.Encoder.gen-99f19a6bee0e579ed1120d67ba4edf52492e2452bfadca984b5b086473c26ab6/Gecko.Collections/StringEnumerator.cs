using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class StringEnumerator : IEnumerator<string>, IDisposable, IEnumerator
{
	private nsIStringEnumerator _enumerator;

	private string _current;

	public string Current => _current;

	object IEnumerator.Current => Current;

	internal StringEnumerator(nsIStringEnumerator enumerator)
	{
		_enumerator = enumerator;
	}

	public void Dispose()
	{
		if (_enumerator is IDisposable disposable)
		{
			disposable.Dispose();
		}
		_enumerator = null;
		_current = null;
		GC.SuppressFinalize(this);
	}

	public bool MoveNext()
	{
		bool result;
		if (result = _enumerator.HasMore())
		{
			_current = nsString.Get(_enumerator.GetNext);
		}
		return result;
	}

	public void Reset()
	{
		throw new NotSupportedException("Reset is not supported for this enumeration");
	}

	public static string[] ToStringArray(nsIStringEnumerator enumerator)
	{
		List<string> list = new List<string>();
		while (enumerator.HasMore())
		{
			string item = nsString.Get(enumerator.GetNext);
			list.Add(item);
		}
		return list.ToArray();
	}
}
