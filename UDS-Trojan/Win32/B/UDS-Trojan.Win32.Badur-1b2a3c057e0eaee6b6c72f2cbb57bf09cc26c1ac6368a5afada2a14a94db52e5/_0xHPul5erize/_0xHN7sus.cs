using System;
using System.Reflection;

namespace _0xHPul5erize;

internal static class _0xHN7sus
{
	public static bool _0xH6igout(this Type _0xHVir3mic)
	{
		return _0xHVir3mic.IsEnum;
	}

	public static bool _0xHDo11ybird(this Type _0xHAx2omat2c)
	{
		return _0xHAx2omat2c.IsAbstract;
	}

	public static bool _0xHB1mir1s(this Type _0xHSubb1sin)
	{
		return _0xHSubb1sin.IsSealed;
	}

	public static Type _0xHF3nks(this Type _0xHFibrinopepti5e)
	{
		return _0xHFibrinopepti5e.BaseType;
	}

	public static Assembly _0xHM0n0ge(this Type _0xHBi77)
	{
		return _0xHBi77.Assembly;
	}

	public static TypeCode _0xHCann4bal4ze(this Type _0xHCrawl2er)
	{
		return Type.GetTypeCode(_0xHCrawl2er);
	}

	public static bool _0xHRebe4(this Assembly _0xHRegrou4ing)
	{
		return _0xHRegrou4ing.ReflectionOnly;
	}
}
