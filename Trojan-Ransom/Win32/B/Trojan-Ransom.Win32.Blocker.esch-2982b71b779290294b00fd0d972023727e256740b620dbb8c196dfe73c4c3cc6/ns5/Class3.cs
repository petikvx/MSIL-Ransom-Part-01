using System;

namespace ns5;

internal sealed class Class3
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

	private Class3()
	{
	}
}
