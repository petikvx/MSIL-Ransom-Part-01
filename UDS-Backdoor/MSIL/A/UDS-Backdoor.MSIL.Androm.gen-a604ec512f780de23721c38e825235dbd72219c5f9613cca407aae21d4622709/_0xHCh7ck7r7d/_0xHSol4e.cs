using System;

namespace _0xHCh7ck7r7d;

internal class _0xHSol4e
{
	public static int _0xHU0surpassable(string _0xHVul7arity, int _0xHP0is0ning, int _0xH0riefers)
	{
		if (string.IsNullOrEmpty(_0xHVul7arity))
		{
			throw new ArgumentException("extension");
		}
		if (_0xHAli4a4e(_0xHVul7arity, out var _0xHUnner4es))
		{
			if (_0xHP0is0ning != -1 && _0xHUnner4es < _0xHP0is0ning)
			{
				return -1;
			}
			if (_0xH0riefers != -1 && _0xHUnner4es > _0xH0riefers)
			{
				return 1;
			}
		}
		return 0;
	}

	private static bool _0xHAli4a4e(string _0xHSternp4sts, out int _0xHUnner4es)
	{
		string[] array = _0xHSternp4sts.Split(new char[1] { '.' });
		if (array.Length < 2)
		{
			_0xHUnner4es = -1;
			return false;
		}
		return int.TryParse(array[0], out _0xHUnner4es);
	}
}
