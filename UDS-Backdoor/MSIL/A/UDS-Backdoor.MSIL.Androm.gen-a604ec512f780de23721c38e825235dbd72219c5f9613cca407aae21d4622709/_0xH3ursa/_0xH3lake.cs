using System;
using System.Linq;

namespace _0xH3ursa;

internal static class _0xH3lake
{
	public static Exception _0xHVirescen1(this Exception _0xH6utled)
	{
		if (_0xH6utled is AggregateException ex)
		{
			AggregateException ex2 = ex.Flatten();
			return ex2.InnerExceptions.First();
		}
		return _0xH6utled;
	}
}
