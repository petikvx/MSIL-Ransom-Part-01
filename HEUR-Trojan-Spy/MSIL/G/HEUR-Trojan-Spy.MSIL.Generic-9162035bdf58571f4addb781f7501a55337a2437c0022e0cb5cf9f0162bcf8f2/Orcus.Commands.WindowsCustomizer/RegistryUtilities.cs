using Microsoft.Win32;

namespace Orcus.Commands.WindowsCustomizer;

public static class RegistryUtilities
{
	public static int? GetIntValueSafe(RegistryKey registryKey, string valueName)
	{
		using (registryKey)
		{
			object obj = registryKey?.GetValue(valueName, null);
			if (obj == null)
			{
				return null;
			}
			if (int.TryParse(obj.ToString(), out var result))
			{
				return result;
			}
			return null;
		}
	}

	public static string GetStringValueSafe(RegistryKey registryKey, string valueName)
	{
		using (registryKey)
		{
			return registryKey?.GetValue(valueName, null)?.ToString();
		}
	}

	public static void SetValueSafe(RegistryKey hive, string path, string valueName, object value, RegistryValueKind registryValueKind)
	{
		using RegistryKey registryKey = hive.CreateSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree);
		registryKey.SetValue(valueName, value, registryValueKind);
	}
}
