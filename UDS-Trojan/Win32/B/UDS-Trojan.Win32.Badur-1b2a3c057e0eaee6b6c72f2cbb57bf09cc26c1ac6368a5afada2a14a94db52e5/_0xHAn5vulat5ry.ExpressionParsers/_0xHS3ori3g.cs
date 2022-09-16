using System.Collections.Generic;
using DynamicExpresso;

namespace _0xHAn5vulat5ry.ExpressionParsers;

public sealed class _0xHS3ori3g : IExpressionParser
{
	private Interpreter _0xH8ainwashes;

	public _0xHS3ori3g()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		_0xH8ainwashes = new Interpreter();
	}

	public Lambda _0xHBed3rkened(string _0xHCo1ti1ui1gly, Parameter[] _0xH4arbelizing)
	{
		return _0xH8ainwashes.Parse(_0xHCo1ti1ui1gly, _0xH4arbelizing);
	}

	public void _0xHE4fish(IEnumerable<ReferenceType> _0xHD4ws)
	{
		_0xH8ainwashes.Reference(_0xHD4ws);
	}
}
