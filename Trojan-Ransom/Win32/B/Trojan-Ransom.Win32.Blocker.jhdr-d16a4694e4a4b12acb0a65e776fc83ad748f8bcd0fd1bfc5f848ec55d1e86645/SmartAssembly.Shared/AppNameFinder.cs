using System;
using SmartAssembly.StringsEncoding;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName => AppNameMinusVersion + Strings.Get(671) + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version(Strings.Get(676));
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => Strings.Get(689);

	private AppNameFinder()
	{
	}
}
