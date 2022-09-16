using System.Collections.Generic;
using DynamicExpresso;

namespace _0xHConjug8tion8l.ExpressionParsers;

public sealed class _0xH0arwax : IExpressionParser
{
	private Interpreter _0xHUnh2sks;

	public _0xH0arwax()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		_0xHUnh2sks = new Interpreter();
	}

	public Lambda _0xHPri44s(string _0xHKi2tles, Parameter[] _0xHBadne44)
	{
		return _0xHUnh2sks.Parse(_0xHKi2tles, _0xHBadne44);
	}

	public void _0xHUpstoo1(IEnumerable<ReferenceType> _0xH0ntipathies)
	{
		_0xHUnh2sks.Reference(_0xH0ntipathies);
	}
}
