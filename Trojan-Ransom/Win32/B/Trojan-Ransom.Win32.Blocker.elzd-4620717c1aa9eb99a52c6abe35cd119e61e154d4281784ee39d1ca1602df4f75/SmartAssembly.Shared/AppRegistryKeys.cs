namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys
{
	public static string SubkeyApplication => "Software\\Red Gate\\" + AppNameFinder.AppName;

	public static string WowSubkeyApplication => "Software\\Wow6432Node\\Red Gate\\" + AppNameFinder.AppName;
}
