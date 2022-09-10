using System;

namespace ns4;

internal sealed class Class9
{
	public static string AppName => AppNameMinusVersion + " " + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version("6.8.0.121");
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private Class9()
	{
	}
}
