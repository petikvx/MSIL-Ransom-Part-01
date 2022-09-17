using System;

namespace _0023qc;

internal class _0023Zc
{
	internal readonly Type _0023a;

	internal readonly object _0023b;

	internal readonly bool _0023c;

	public bool FirstLevel => _0023c;

	public _0023Zc(object _0023wc, bool _00230c)
		: this(_0023wc, _0023wc?.GetType(), _00230c)
	{
	}

	public _0023Zc(object _0023wc, Type _00231c, bool _00230c)
	{
		_0023b = _0023wc;
		_0023a = _00231c;
		_0023c = _00230c;
	}
}
