using System.Globalization;
using Microsoft.Win32;

namespace WatsonDialog;

internal static class RegistryInteractor
{
	internal static bool SetRegKeyValue(RegistryKey baseKey, string keyStr, string keyNameStr, object value, string settingsType, string component)
	{
		return SetRegKeyValue(baseKey, keyStr, keyNameStr, value, string.Format(CultureInfo.InvariantCulture, Constants.UPDATE_ERROR_SPECIFIC, new object[2] { settingsType, component }));
	}

	internal static bool SetRegKeyValue(RegistryKey baseKey, string keyStr, string keyNameStr, object value, string errorMsg)
	{
		RegistryKey regKey = GetRegKey(baseKey, keyStr, errorMsg, showError: true);
		if (regKey == null)
		{
			return false;
		}
		regKey.SetValue(keyNameStr, value);
		return true;
	}

	internal static object GetRegKeyValue(RegistryKey baseKey, string keyStr, string keyNameStr, string settingsType, string component)
	{
		return GetRegKeyValue(baseKey, keyStr, keyNameStr, string.Format(CultureInfo.InvariantCulture, Constants.ACCESS_ERROR_SPECIFIC, new object[2] { settingsType, component }));
	}

	internal static object GetRegKeyValue(RegistryKey baseKey, string keyStr, string keyNameStr, string errorMsg)
	{
		return GetRegKey(baseKey, keyStr, errorMsg)?.GetValue(keyNameStr);
	}

	internal static object GetRegKeyValue(RegistryKey baseKey, string keyStr, string keyNameStr)
	{
		return GetRegKey(baseKey, keyStr, null, showError: false)?.GetValue(keyNameStr);
	}

	internal static RegistryKey GetRegKey(RegistryKey baseKey, string keyStr, string errorMsg)
	{
		return GetRegKey(baseKey, keyStr, errorMsg, showError: true);
	}

	internal static RegistryKey GetRegKey(RegistryKey baseKey, string keyStr, string errorMsg, bool showError)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		RegistryKey registryKey = baseKey.OpenSubKey(keyStr, writable: true);
		if (registryKey == null && showError)
		{
			ErrorHandler.Error(errorMsg);
		}
		return registryKey;
	}

	internal static bool KeyExists(RegistryKey baseKey, string keyName)
	{
		return baseKey.OpenSubKey(keyName, writable: true) != null;
	}

	internal static RegistryKey[] GetSubRegKeys(RegistryKey baseKey)
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		string[] subKeyNames = baseKey.GetSubKeyNames();
		RegistryKey[] array = new RegistryKey[subKeyNames.Length];
		int num = 0;
		string[] array2 = subKeyNames;
		foreach (string text in array2)
		{
			RegistryKey registryKey = baseKey.OpenSubKey(text);
			if (registryKey == null)
			{
				string text2 = Constants.UNKNOWN_SERVICE;
				switch (text)
				{
				case "SQL":
					text2 = Constants.COMPONENT_SQL_SERVER_STRING;
					break;
				case "RS":
					text2 = Constants.COMPONENT_REPORT_SERVER_STRING;
					break;
				case "OLAP":
					text2 = Constants.COMPONENT_ANALYSIS_SERVER_STRING;
					break;
				}
				ErrorHandler.Error(string.Format(CultureInfo.InvariantCulture, Constants.ACCESS_ERROR, new object[1] { text2 }));
			}
			else
			{
				array[num] = registryKey;
				num++;
			}
		}
		return array;
	}
}
