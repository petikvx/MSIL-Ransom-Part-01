using System;

namespace MySql.Data.Common;

internal class Platform
{
	private static bool _inited;

	private static bool _isMono;

	private Platform()
	{
	}

	public static bool IsWindows()
	{
		PlatformID platform = Environment.OSVersion.Platform;
		if ((uint)platform <= 2u)
		{
			return true;
		}
		return false;
	}

	public static bool IsMacOSX()
	{
		return Environment.OSVersion.Platform == PlatformID.MacOSX;
	}

	public static bool IsMono()
	{
		if (!_inited)
		{
			Init();
		}
		return _isMono;
	}

	private static void Init()
	{
		_inited = true;
		_isMono = Type.GetType("Mono.Runtime") != null;
	}

	public static bool IsDotNetCore()
	{
		return false;
	}
}
