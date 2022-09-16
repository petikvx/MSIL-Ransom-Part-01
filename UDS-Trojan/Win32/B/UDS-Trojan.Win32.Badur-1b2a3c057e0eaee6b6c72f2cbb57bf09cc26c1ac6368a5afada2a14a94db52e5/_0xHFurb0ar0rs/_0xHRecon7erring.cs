using System.Collections;
using System.Collections.Generic;
using _0xH3yoglobins;

namespace _0xHFurb0ar0rs;

[_0xHAlliu0s]
internal class _0xHRecon7erring : IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
	public string _0xHRe3isters { get; set; }

	public float _0xHDr1amworld { get; set; }

	public float _0xHTe3ry { get; set; }

	public int _0xHCompacte8 { get; set; }

	public float _0xHOiti6i6as { get; set; }

	public float _0xHRep1diation { get; set; }

	public float _0xHLoami1st { get; internal set; }

	private IEnumerable<KeyValuePair<string, object>> _0xHR7coupl7
	{
		get
		{
			yield return new KeyValuePair<string, object>("Name", _0xHRe3isters);
			yield return new KeyValuePair<string, object>("Mean", _0xHDr1amworld);
			yield return new KeyValuePair<string, object>("StandardDerivation", _0xHTe3ry);
			yield return new KeyValuePair<string, object>("Count", _0xHCompacte8);
			yield return new KeyValuePair<string, object>("Min", _0xHOiti6i6as);
			yield return new KeyValuePair<string, object>("Max", _0xHRep1diation);
		}
	}

	public IEnumerator<KeyValuePair<string, object>> _0xHT4ysh4ps()
	{
		return _0xHR7coupl7.GetEnumerator();
	}

	private IEnumerator _0xHHep0tic0s()
	{
		return _0xHR7coupl7.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in _0xHHep0tic0s
		return this._0xHHep0tic0s();
	}
}
