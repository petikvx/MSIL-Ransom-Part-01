using System;

namespace _0023qc;

internal class _00233c : EventArgs
{
	internal Exception _0023a;

	public Exception FatalException => _0023a;

	internal _00233c(Exception _00234c)
	{
		_0023a = _00234c;
	}
}
