using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 50285)]
	private struct Struct0
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

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
}
