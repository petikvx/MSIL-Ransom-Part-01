using Microsoft.Win32;

namespace Lexplorer;

internal static class Class6
{
	private const string IE_SETTINGS_REGISTRY_PATH = "SOFTWARE\\Microsoft\\Internet Explorer\\Main";

	private const string IE_PROPERTY_SAVE_SESSION_HISTORY_ON_EXIT = "Save_Session_History_On_Exit";

	private const string IE_PROPERTY_FULLSCREEN = "FullScreen";

	private const string IE_PROPERTY_TRUE = "yes";

	private const string IE_PROPERTY_FALSE = "no";

	public static bool SaveSessionHistoryOnExit
	{
		get
		{
			object registryKeyProperty = GetRegistryKeyProperty("SOFTWARE\\Microsoft\\Internet Explorer\\Main", "Save_Session_History_On_Exit");
			if (registryKeyProperty != null)
			{
				return (string)registryKeyProperty == "yes";
			}
			return false;
		}
		set
		{
			SetRegistryKeyProperty("SOFTWARE\\Microsoft\\Internet Explorer\\Main", "Save_Session_History_On_Exit", value ? "yes" : "no");
		}
	}

	public static bool StartFullscreen
	{
		get
		{
			object registryKeyProperty = GetRegistryKeyProperty("SOFTWARE\\Microsoft\\Internet Explorer\\Main", "FullScreen");
			if (registryKeyProperty == null)
			{
				return false;
			}
			return (string)registryKeyProperty == "yes";
		}
		set
		{
			SetRegistryKeyProperty("SOFTWARE\\Microsoft\\Internet Explorer\\Main", "FullScreen", value ? "yes" : "no");
		}
	}

	private static void SetRegistryKeyProperty(string path, string key, string value)
	{
		try
		{
			Registry.CurrentUser.OpenSubKey(path, writable: true)?.SetValue(key, value);
		}
		catch
		{
		}
	}

	private static object GetRegistryKeyProperty(string path, string key)
	{
		try
		{
			return Registry.CurrentUser.OpenSubKey(path)?.GetValue(key);
		}
		catch
		{
			return null;
		}
	}
}
