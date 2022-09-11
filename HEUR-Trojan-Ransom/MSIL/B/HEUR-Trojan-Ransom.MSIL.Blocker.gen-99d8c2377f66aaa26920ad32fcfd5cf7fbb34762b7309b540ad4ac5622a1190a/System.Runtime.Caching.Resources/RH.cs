using System.Globalization;

namespace System.Runtime.Caching.Resources;

internal static class RH
{
	public static string Format(string resource, params object[] args)
	{
		return string.Format(CultureInfo.CurrentCulture, resource, args);
	}
}
