using System;
using System.Reflection;
using System.Resources;

namespace RegAsm;

internal class Resource
{
	private static ResourceManager _resmgr;

	private static void InitResourceManager()
	{
		if (_resmgr == null)
		{
			_resmgr = new ResourceManager("RegAsm", Assembly.GetAssembly(typeof(RegAsm)));
		}
	}

	internal static string GetString(string key)
	{
		InitResourceManager();
		string @string = _resmgr.GetString(key, null);
		if (@string == null)
		{
			throw new ApplicationException("FATAL: Resource string for '" + key + "' is null");
		}
		return @string;
	}

	internal static string FormatString(string key)
	{
		return GetString(key);
	}

	internal static string FormatString(string key, object a1)
	{
		return string.Format(GetString(key), a1);
	}

	internal static string FormatString(string key, object a1, object a2)
	{
		return string.Format(GetString(key), a1, a2);
	}

	internal static string FormatString(string key, object a1, object a2, object a3)
	{
		return string.Format(GetString(key), a1, a2, a3);
	}

	internal static string FormatString(string key, object[] a)
	{
		return string.Format(GetString(key), a);
	}
}
