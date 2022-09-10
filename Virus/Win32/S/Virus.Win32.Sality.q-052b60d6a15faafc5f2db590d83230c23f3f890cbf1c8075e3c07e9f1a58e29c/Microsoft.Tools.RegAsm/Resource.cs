using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Microsoft.Tools.RegAsm;

internal static class Resource
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
		string stringIfExists = GetStringIfExists(key);
		if (stringIfExists == null)
		{
			throw new ApplicationException("FATAL: Resource string for '" + key + "' is null");
		}
		return stringIfExists;
	}

	internal static string GetStringIfExists(string key)
	{
		InitResourceManager();
		return _resmgr.GetString(key, null);
	}

	internal static string FormatString(string key)
	{
		return GetString(key);
	}

	internal static string FormatString(string key, object a1)
	{
		return string.Format(CultureInfo.CurrentCulture, GetString(key), new object[1] { a1 });
	}

	internal static string FormatString(string key, object a1, object a2)
	{
		return string.Format(CultureInfo.CurrentCulture, GetString(key), new object[2] { a1, a2 });
	}

	internal static string FormatString(string key, object a1, object a2, object a3)
	{
		return string.Format(CultureInfo.CurrentCulture, GetString(key), new object[3] { a1, a2, a3 });
	}
}
