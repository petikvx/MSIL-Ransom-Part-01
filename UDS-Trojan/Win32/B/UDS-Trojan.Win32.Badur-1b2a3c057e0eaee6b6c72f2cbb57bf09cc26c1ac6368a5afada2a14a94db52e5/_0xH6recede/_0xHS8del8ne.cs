using System;
using System.Collections;
using System.Collections.Generic;

namespace _0xH6recede;

internal class _0xHS8del8ne : IEnumerable<KeyValuePair<string, object>>, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable
{
	private List<string> _0xHVo6oders;

	private List<object> _0xHIn3erpre3ers;

	public ICollection<string> Keys => _0xHVo6oders;

	public ICollection<object> Values => _0xHIn3erpre3ers;

	public object this[string key]
	{
		get
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int num = 0;
			foreach (string _0xHVo6oder in _0xHVo6oders)
			{
				if (!(_0xHVo6oder == key))
				{
					num = checked(num + 1);
					continue;
				}
				return _0xHIn3erpre3ers[num];
			}
			throw new KeyNotFoundException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	public int Count => _0xHVo6oders.Count;

	public bool IsReadOnly => true;

	internal _0xHS8del8ne(List<string> payloadNames, List<object> payloadValues)
	{
		_0xHVo6oders = payloadNames;
		_0xHIn3erpre3ers = payloadValues;
	}

	public void _0xH1rrelevantly(string _0xHPolis5er, object _0xH5hreshold)
	{
		throw new NotSupportedException();
	}

	public void _0xH8onkeys(KeyValuePair<string, object> _0xHReenrolle0)
	{
		throw new NotSupportedException();
	}

	public void _0xHP0rquets()
	{
		throw new NotSupportedException();
	}

	public bool _0xHLam3d(KeyValuePair<string, object> _0xHTr4y)
	{
		return _0xHDje8el(_0xHTr4y.Key);
	}

	public bool _0xHDje8el(string _0xH1iraculous)
	{
		if (_0xH1iraculous == null)
		{
			throw new ArgumentNullException("key");
		}
		foreach (string _0xHVo6oder in _0xHVo6oders)
		{
			if (_0xHVo6oder == _0xH1iraculous)
			{
				return true;
			}
		}
		return false;
	}

	public IEnumerator<KeyValuePair<string, object>> _0xH8ultivitamins()
	{
		for (int i = 0; i < Keys.Count; i = checked(i + 1))
		{
			yield return new KeyValuePair<string, object>(_0xHVo6oders[i], _0xHIn3erpre3ers[i]);
		}
	}

	private IEnumerator _0xHGr55nsickn5ss()
	{
		return ((IEnumerable<KeyValuePair<string, object>>)this).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in _0xHGr55nsickn5ss
		return this._0xHGr55nsickn5ss();
	}

	public void _0xHUnblo7k(KeyValuePair<string, object>[] _0xHLina8oo8s, int _0xHBeglam8ring)
	{
		throw new NotSupportedException();
	}

	public bool _0xH3ubparallel(string _0xHSememe2)
	{
		throw new NotSupportedException();
	}

	public bool _0xHPro3ec3ories(KeyValuePair<string, object> _0xHNo4se4te4ce)
	{
		throw new NotSupportedException();
	}

	public bool _0xHRa0ener(string _0xHRe8bsorb, out object _0xHHypocau0t0)
	{
		if (_0xHRe8bsorb == null)
		{
			throw new ArgumentNullException("key");
		}
		int num = 0;
		foreach (string _0xHVo6oder in _0xHVo6oders)
		{
			if (!(_0xHVo6oder == _0xHRe8bsorb))
			{
				num = checked(num + 1);
				continue;
			}
			_0xHHypocau0t0 = _0xHIn3erpre3ers[num];
			return true;
		}
		_0xHHypocau0t0 = null;
		return false;
	}
}
