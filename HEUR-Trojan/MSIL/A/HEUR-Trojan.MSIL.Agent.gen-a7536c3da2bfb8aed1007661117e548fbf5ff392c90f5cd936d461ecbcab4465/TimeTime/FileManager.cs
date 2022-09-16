using Microsoft.Win32;

namespace TimeTime;

public static class FileManager
{
	public static RegistryKey key;

	private static RegistryKey CreateKey()
	{
		return Registry.CurrentUser.CreateSubKey(Class0.string_25);
	}

	public static void AddFile(string file)
	{
		key.SetValue(file, Class0.string_26);
	}

	public static string[] GetFiles()
	{
		return key.GetValueNames();
	}

	public static void Init()
	{
		key = CreateKey();
	}
}
