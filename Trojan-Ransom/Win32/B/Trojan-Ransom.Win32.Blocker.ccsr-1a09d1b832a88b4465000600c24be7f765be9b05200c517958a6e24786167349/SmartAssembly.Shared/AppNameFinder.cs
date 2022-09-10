using System;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName => AutoHeightLabel.smethod_0(AppNameMinusVersion, " ", MajorVersion, 645, 718);

	public static int MajorVersion
	{
		get
		{
			Version version_ = new Version("6.5.0.1037");
			return Class13.smethod_1(version_, 427, 422);
		}
	}

	public static string AppNameMinusVersion => "SmartAssembly";

	private AppNameFinder()
	{
	}

	static AppNameFinder()
	{
		DESCryptoIndirector.smethod_0();
	}
}
