using System;
using System.Reflection;

internal static class _0023_003DqPfKWEQ3VBW6p3exa_00246c_ZcNWph8pLsFNW42AxAJ5KwQ_003D
{
	public static readonly Type _0023_003DzizBjOuE_003D;

	public static readonly Type _0023_003DzYtBeqWc_003D;

	public static readonly Type _0023_003Dzfze_RqI_003D;

	public static readonly Type _0023_003DzldAoPbg_003D;

	public static readonly Assembly _0023_003DzgfHGZnM_003D;

	static _0023_003DqPfKWEQ3VBW6p3exa_00246c_ZcNWph8pLsFNW42AxAJ5KwQ_003D()
	{
		Type typeFromHandle = typeof(object);
		if (6u != 0)
		{
			_0023_003DzizBjOuE_003D = typeFromHandle;
		}
		Type typeFromHandle2 = typeof(Nullable<>);
		if (2u != 0)
		{
			_0023_003DzYtBeqWc_003D = typeFromHandle2;
		}
		Type typeFromHandle3 = typeof(Enum);
		if (true)
		{
			_0023_003Dzfze_RqI_003D = typeFromHandle3;
		}
		_0023_003DzldAoPbg_003D = typeof(ValueType);
		_0023_003DzgfHGZnM_003D = typeof(_0023_003DqPfKWEQ3VBW6p3exa_00246c_ZcNWph8pLsFNW42AxAJ5KwQ_003D).Assembly;
	}

	public static bool _0023_003Dz61ub4gZWvey_OhQV4ZEyToM_003D(Type _0023_003DzizBjOuE_003D)
	{
		_ = 1;
		if (1 == 0)
		{
		}
		if (_0023_003DzizBjOuE_003D.IsGenericType)
		{
			_ = 8;
			if (3 == 0)
			{
			}
			return (object)_0023_003DzizBjOuE_003D.GetGenericTypeDefinition() == _0023_003DzYtBeqWc_003D;
		}
		return false;
	}
}
