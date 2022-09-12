using Microsoft.Win32;

namespace TimeTime;

public static class FileManager
{
	public static RegistryKey key;

	private static RegistryKey CreateKey()
	{
		return Registry.CurrentUser.CreateSubKey("TimeTime");
	}

	public static void AddFile(string file)
	{
		key.SetValue(file, "1");
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
