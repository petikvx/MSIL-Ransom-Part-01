using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko.Collections;

internal sealed class Utf8StringEnumerator : IEnumerator<string>, IDisposable, IEnumerator
{
	private nsIUTF8StringEnumerator _enumerator;

	private string _current;

	public string Current => _current;

	object IEnumerator.Current => Current;

	internal Utf8StringEnumerator(nsIUTF8StringEnumerator enumerator)
	{
		_enumerator = enumerator;
	}

	public void Dispose()
	{
		_enumerator = null;
		_current = null;
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

	public static string[] ToStringArray(nsIUTF8StringEnumerator enumerator)
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
