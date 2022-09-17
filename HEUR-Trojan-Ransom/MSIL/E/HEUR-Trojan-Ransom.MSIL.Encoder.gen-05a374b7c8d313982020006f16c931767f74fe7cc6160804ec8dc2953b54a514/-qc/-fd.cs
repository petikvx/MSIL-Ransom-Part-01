using System;

namespace _0023qc;

internal class _0023fd : EventArgs
{
	internal _0023Uc _0023a;

	private Exception _0023b;

	internal bool _0023c;

	internal bool _0023d = true;

	internal bool _0023e = true;

	internal bool _0023f;

	public Exception Exception => _0023b;

	public bool CanDebug => _0023c;

	public bool CanSendReport => _0023d;

	public bool ShowContinueCheckbox => _0023e;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => _0023e;

	public bool TryToContinue
	{
		get
		{
			return _0023f;
		}
		set
		{
			_0023f = value;
		}
	}

	internal _0023fd(_0023Uc _0023gd, Exception _0023hd)
	{
		_0023a = _0023gd;
		_0023b = _0023hd;
	}
}
