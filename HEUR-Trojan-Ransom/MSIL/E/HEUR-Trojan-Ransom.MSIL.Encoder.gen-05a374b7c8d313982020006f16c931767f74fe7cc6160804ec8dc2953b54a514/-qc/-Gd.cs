using System;

namespace _0023qc;

internal class _0023Gd : EventArgs
{
	private _0023Hd _0023a;

	private readonly bool _0023b;

	private readonly string _0023c = string.Empty;

	private readonly string _0023d = string.Empty;

	public _0023Hd Step => _0023a;

	public bool Failed => _0023b;

	public string ErrorMessage => _0023c;

	public string ReportID => _0023d;

	internal _0023Gd(_0023Hd _0023md)
		: this(_0023md, string.Empty)
	{
	}

	internal _0023Gd(_0023Hd _0023md, string _0023nd)
		: this(_0023md, _0023nd, string.Empty)
	{
	}

	internal _0023Gd(_0023Hd _0023md, string _0023nd, string _0023od)
	{
		_0023a = _0023md;
		_0023b = _0023nd != null && _0023nd.Length > 0;
		_0023c = _0023nd;
		_0023d = _0023od;
	}
}
