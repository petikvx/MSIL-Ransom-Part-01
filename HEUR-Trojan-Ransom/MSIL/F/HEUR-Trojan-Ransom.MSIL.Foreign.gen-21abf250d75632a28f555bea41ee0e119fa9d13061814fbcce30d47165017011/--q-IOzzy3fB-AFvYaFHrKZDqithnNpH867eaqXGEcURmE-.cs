using System;

internal static class _0023_003Dq_0024IOzzy3fB_0024AFvYaFHrKZDqithnNpH867eaqXGEcURmE_003D
{
	public static bool _0023_003Dz_002495az0UtnGFkpq8nDkRM0h0_003D(Type _0023_003DzizBjOuE_003D, Type _0023_003DzYtBeqWc_003D)
	{
		if ((object)_0023_003DzizBjOuE_003D == _0023_003DzYtBeqWc_003D)
		{
			return true;
		}
		if ((object)_0023_003DzizBjOuE_003D == null || (object)_0023_003DzYtBeqWc_003D == null)
		{
			return false;
		}
		if (_0023_003DzizBjOuE_003D.IsByRef)
		{
			if (!_0023_003DzYtBeqWc_003D.IsByRef)
			{
				return false;
			}
			return _0023_003Dz_002495az0UtnGFkpq8nDkRM0h0_003D(_0023_003DzizBjOuE_003D.GetElementType(), _0023_003DzYtBeqWc_003D.GetElementType());
		}
		if (_0023_003DzYtBeqWc_003D.IsByRef)
		{
			return false;
		}
		if (_0023_003DzizBjOuE_003D.IsPointer)
		{
			if (!_0023_003DzYtBeqWc_003D.IsPointer)
			{
				return false;
			}
			return _0023_003Dz_002495az0UtnGFkpq8nDkRM0h0_003D(_0023_003DzizBjOuE_003D.GetElementType(), _0023_003DzYtBeqWc_003D.GetElementType());
		}
		if (_0023_003DzYtBeqWc_003D.IsPointer)
		{
			return false;
		}
		if (_0023_003DzizBjOuE_003D.IsArray)
		{
			if (!_0023_003DzYtBeqWc_003D.IsArray)
			{
				return false;
			}
			if (_0023_003DzizBjOuE_003D.GetArrayRank() != _0023_003DzYtBeqWc_003D.GetArrayRank())
			{
				return false;
			}
			return _0023_003Dz_002495az0UtnGFkpq8nDkRM0h0_003D(_0023_003DzizBjOuE_003D.GetElementType(), _0023_003DzYtBeqWc_003D.GetElementType());
		}
		if (_0023_003DzYtBeqWc_003D.IsArray)
		{
			return false;
		}
		if (_0023_003DzizBjOuE_003D.IsGenericType && !_0023_003DzizBjOuE_003D.IsGenericTypeDefinition)
		{
			Type genericTypeDefinition = _0023_003DzizBjOuE_003D.GetGenericTypeDefinition();
			if (3u != 0)
			{
				_0023_003DzizBjOuE_003D = genericTypeDefinition;
			}
		}
		if (_0023_003DzYtBeqWc_003D.IsGenericType && !_0023_003DzYtBeqWc_003D.IsGenericTypeDefinition)
		{
			Type genericTypeDefinition2 = _0023_003DzYtBeqWc_003D.GetGenericTypeDefinition();
			if (3u != 0)
			{
				_0023_003DzYtBeqWc_003D = genericTypeDefinition2;
			}
		}
		if ((object)_0023_003DzizBjOuE_003D == _0023_003DzYtBeqWc_003D)
		{
			return true;
		}
		return false;
	}
}
