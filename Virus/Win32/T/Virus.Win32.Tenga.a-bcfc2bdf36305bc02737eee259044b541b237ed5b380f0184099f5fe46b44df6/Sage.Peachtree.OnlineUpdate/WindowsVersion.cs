using System;

namespace Sage.Peachtree.OnlineUpdate;

public class WindowsVersion
{
	public static bool IsVistaOrLater
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Major >= 6;
			}
			return false;
		}
	}
}
