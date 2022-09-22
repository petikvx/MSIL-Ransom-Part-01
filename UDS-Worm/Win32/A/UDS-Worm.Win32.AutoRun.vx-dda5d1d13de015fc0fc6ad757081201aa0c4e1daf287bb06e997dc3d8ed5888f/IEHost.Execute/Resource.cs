using System.Reflection;
using System.Resources;

namespace IEHost.Execute;

internal static class Resource
{
	private static ResourceManager _resmgr;

	private static void InitResourceManager()
	{
		if (_resmgr == null)
		{
			_resmgr = new ResourceManager("IEExec", Assembly.GetAssembly(typeof(IEExecute)));
		}
	}

	internal static string GetString(string key)
	{
		return GetStringIfExists(key);
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
}
