using System.Reflection;
using System.Resources;

internal static class CommonResStrings
{
	private static ResourceManager resmgr = new ResourceManager("CommonResStrings", Assembly.GetExecutingAssembly());

	internal static string CopyrightForCmdLine => GetString("Microsoft_Copyright_CommandLine_Logo");

	internal static string GetString(string id)
	{
		return resmgr.GetString(id);
	}
}
