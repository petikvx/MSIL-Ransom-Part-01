using System;
using _009D_0003_009E_0006;

namespace _0023P;

internal class _00231 : _0023V
{
	public _00231()
		: base(UIntPtr.Zero)
	{
	}

	public _00231(UIntPtr _0023W)
		: base(_0023W)
	{
	}

	public override void _0023U()
	{
		_009C_0003_009E_0006._007F_0004_0006(base.HKey);
	}

	public override object _0023S(string _0023x)
	{
		return _009C_0003_009E_0006._0089_0098(base.HKey, _0023x);
	}

	public override bool _0023T(string _0023x, out object _0023z)
	{
		_0023z = _009C_0003_009E_0006._0089_0098(base.HKey, _0023x);
		return _0023z != null;
	}
}
