using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal static class HelperMethods
{
	private static readonly object staticSyncRoot;

	private static readonly string MonoRuntimeType;

	private static bool? isMono;

	[NonSerialized]
	internal static GetString _009F;

	private static bool IsMono()
	{
		try
		{
			lock (staticSyncRoot)
			{
				if (!isMono.HasValue)
				{
					isMono = (object)Type.GetType(MonoRuntimeType) != null;
				}
				return isMono.Value;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static bool IsWindows()
	{
		PlatformID platform = Environment.OSVersion.Platform;
		if (platform == PlatformID.Win32S || platform == PlatformID.Win32Windows || platform == PlatformID.Win32NT || platform == PlatformID.WinCE)
		{
			return true;
		}
		return false;
	}

	internal static string StringFormat(IFormatProvider provider, string format, params object[] args)
	{
		if (IsMono())
		{
			return string.Format(format, args);
		}
		return string.Format(provider, format, args);
	}

	static HelperMethods()
	{
		Strings.CreateGetStringDelegate(typeof(HelperMethods));
		staticSyncRoot = new object();
		MonoRuntimeType = _009F(107381351);
		isMono = null;
	}
}
