using System;
using ns4;

namespace ns2;

public sealed class GClass0
{
	public static string AppName => AppNameMinusVersion + " " + MajorVersion;

	public static int MajorVersion
	{
		get
		{
			Version version = new Version("6.8.0.117");
			return version.Major;
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private GClass0()
	{
	}

	static GClass0()
	{
		GClass11.smethod_0();
	}
}
