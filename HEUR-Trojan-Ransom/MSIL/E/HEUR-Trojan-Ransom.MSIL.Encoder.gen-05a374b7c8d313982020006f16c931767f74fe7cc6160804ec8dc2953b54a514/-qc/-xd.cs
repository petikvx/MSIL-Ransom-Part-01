using System;
using System.Security;

namespace _0023qc;

internal class _0023xd : EventArgs
{
	private SecurityException _0023a;

	private string _0023b = string.Empty;

	internal bool _0023c;

	internal bool _0023d;

	private bool _0023e = true;

	public SecurityException SecurityException => _0023a;

	public string SecurityMessage => _0023b;

	public bool CanContinue => _0023e;

	public bool TryToContinue
	{
		get
		{
			return _0023c;
		}
		set
		{
			_0023c = value;
		}
	}

	public bool ReportException
	{
		get
		{
			return _0023d;
		}
		set
		{
			_0023d = value;
		}
	}

	public _0023xd(SecurityException _0023yd)
	{
		_0023a = _0023yd;
	}

	public _0023xd(SecurityException _0023yd, bool _0023zd)
		: this(_0023yd)
	{
		_0023e = _0023zd;
	}

	public _0023xd(string _0023Ad, bool _0023zd)
		: this(new SecurityException(_0023Ad), _0023zd)
	{
		_0023b = _0023Ad;
	}
}
