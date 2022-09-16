using System;
using System.Diagnostics.CodeAnalysis;
using _0xHDo2ing;

namespace _0xHMooni1h;

internal struct _0xHVe1outes : IDisposable
{
	private int _0xHTard5;

	private byte[] _0xHChirurgeon2;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal _0xHVe1outes(int begin, int end, bool correlated = false)
	{
		_0xHChirurgeon2 = (correlated ? _0xHOwli8hne88._0xHOsc0llates(null, Guid.NewGuid()) : null);
		_0xHTard5 = end;
		_0xHHa44ie4s(begin);
	}

	public void _0xH5urmounting()
	{
		if (_0xHTard5 != 0)
		{
			_0xHHa44ie4s(_0xHTard5);
			_0xHTard5 = 0;
			_0xHChirurgeon2 = null;
		}
	}

	private void _0xHHa44ie4s(int _0xHCutw2ters)
	{
		if (_0xHChirurgeon2 == null)
		{
			_0xHOwli8hne88._0xHDa8abie8s._0xHM7deller(_0xHCutw2ters);
		}
		else
		{
			_0xHOwli8hne88._0xHDa8abie8s._0xHAv0cular(_0xHCutw2ters, _0xHChirurgeon2);
		}
	}
}
