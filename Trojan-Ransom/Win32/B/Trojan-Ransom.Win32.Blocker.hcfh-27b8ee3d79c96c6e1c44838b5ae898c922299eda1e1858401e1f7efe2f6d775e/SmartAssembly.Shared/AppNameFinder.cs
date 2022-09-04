using System;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName => AppNameMinusVersion + " " + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version("6.6.4.95");
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private AppNameFinder()
	{
	}
}
