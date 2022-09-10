using System;
using System.EnterpriseServices;
using System.Reflection;
using System.Resources;

internal class Resource
{
	private static ResourceManager _resmgr;

	private static void InitResourceManager()
	{
		if (_resmgr == null)
		{
			_resmgr = new ResourceManager("System.EnterpriseServices", Assembly.GetAssembly(typeof(RegistrationHelper)));
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
