using System;

namespace Orcus.Utilities;

public static class CoreHelper
{
	public static bool RunningOnXP
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Major < 6;
			}
			return false;
		}
	}

	public static bool RunningOnXPOrGreater
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Major >= 5;
			}
			return false;
		}
	}

	public static bool RunningOnVista
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Equals(new Version(6, 0));
			}
			return false;
		}
	}

	public static bool RunningOnVistaOrGreater
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

	public static bool RunningOnWin7
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Equals(new Version(6, 1));
			}
			return false;
		}
	}

	public static bool RunningOnWin7OrGreater
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.CompareTo(new Version(6, 1)) >= 0;
			}
			return false;
		}
	}

	public static bool RunningOnWin8
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Equals(new Version(6, 2));
			}
			return false;
		}
	}

	public static bool RunningOnWin8OrGreater
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.CompareTo(new Version(6, 2)) >= 0;
			}
			return false;
		}
	}

	public static bool RunningOnWin8d1
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Equals(new Version(6, 3));
			}
			return false;
		}
	}

	public static bool RunningOnWin8d1OrGreater
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.CompareTo(new Version(6, 3)) >= 0;
			}
			return false;
		}
	}

	public static bool RunningOnWin10
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.Equals(new Version(10, 0));
			}
			return false;
		}
	}

	public static bool RunningOnWin10OrGreater
	{
		get
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return Environment.OSVersion.Version.CompareTo(new Version(10, 0)) >= 0;
			}
			return false;
		}
	}
}
