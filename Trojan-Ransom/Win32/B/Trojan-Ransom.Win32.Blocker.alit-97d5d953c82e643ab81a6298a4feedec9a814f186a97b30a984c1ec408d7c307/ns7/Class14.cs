using System;

namespace ns7;

internal sealed class Class14
{
	public static string AppName => "SmartAssembly" + " " + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version("6.6.1.31");
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private Class14()
	{
	}
}
