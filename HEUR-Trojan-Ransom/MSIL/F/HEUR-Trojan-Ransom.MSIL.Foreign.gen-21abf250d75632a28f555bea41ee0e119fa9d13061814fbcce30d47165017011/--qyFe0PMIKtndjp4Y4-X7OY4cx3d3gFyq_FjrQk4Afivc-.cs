using System;
using System.Reflection;
using System.Security;

internal static class _0023_003DqyFe0PMIKtndjp4Y4_0024X7OY4cx3d3gFyq_FjrQk4Afivc_003D
{
	private static readonly bool _0023_003DzizBjOuE_003D;

	static _0023_003DqyFe0PMIKtndjp4Y4_0024X7OY4cx3d3gFyq_FjrQk4Afivc_003D()
	{
		bool num = _0023_003DzQN9aLKV41sazk6Y6p9jYLWq_ZGmi();
		if (6u != 0)
		{
			_0023_003DzizBjOuE_003D = num;
		}
	}

	private static bool _0023_003DzQN9aLKV41sazk6Y6p9jYLWq_ZGmi()
	{
		try
		{
			if (Environment.Version.Major < 4)
			{
				if (5u != 0)
				{
					return false;
				}
				bool result;
				return result;
			}
			Assembly assembly = typeof(_0023_003DqVUfmRgr2edjpSQ6cLSxxYvxjeOvwnkXBPOi03N4tC58_003D).Assembly;
			Assembly assembly2 = typeof(SecurityCriticalAttribute).Assembly;
			Assembly assembly3;
			if (2u != 0)
			{
				assembly3 = assembly2;
			}
			bool result2;
			if (2u != 0)
			{
				result2 = false;
			}
			object[] customAttributes = assembly.GetCustomAttributes(inherit: false);
			foreach (object obj in customAttributes)
			{
				if (obj is AllowPartiallyTrustedCallersAttribute)
				{
					result2 = true;
					continue;
				}
				Type type = obj.GetType();
				if ((object)type.Assembly == assembly3 && _0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366345805).Equals(type.FullName, StringComparison.Ordinal) && (byte)type.GetProperty(_0023_003Dq7YnFCZV6_0024qHbcHNiJbn9yLiKDnWHxRP4Qjy3KjzkXkM_003D._0023_003DzzgwDXrs_003D(366346144))!.GetValue(obj, null) != 2)
				{
					return false;
				}
			}
			return result2;
		}
		catch
		{
			return false;
		}
	}

	public static bool _0023_003Dzb05_og6pbjrYVMKWudXJZsHjU4u_3QPCZO5vu_c_003D()
	{
		return _0023_003DzizBjOuE_003D;
	}
}
