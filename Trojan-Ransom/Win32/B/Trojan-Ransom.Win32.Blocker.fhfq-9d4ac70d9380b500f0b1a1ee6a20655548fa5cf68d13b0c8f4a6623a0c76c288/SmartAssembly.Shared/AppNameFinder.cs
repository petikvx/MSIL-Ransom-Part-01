using System;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName => AppNameMinusVersion + " " + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version("6.7.0.239");
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private AppNameFinder()
	{
	}
}
