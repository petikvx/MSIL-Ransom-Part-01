using System;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName => AppNameMinusVersion + " " + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version("6.5.0.1037");
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private AppNameFinder()
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
	}
}
