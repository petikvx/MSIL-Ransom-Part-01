using System;

namespace ns2;

internal sealed class Class11
{
	private static Version version_0 = new Version("7.0.8.2472");

	private static string string_0 = null;

	public static Version Version => version_0;

	public static string AppName => "SmartAssembly" + " " + MajorVersion;

	public static string TitleVersion => string_0 ?? (string_0 = $"{version_0.Major}.{version_0.Minor}");

	public static int MajorVersion => version_0.Major;

	public static string AppNameMinusVersion => "SmartAssembly";

	private Class11()
	{
	}
}
