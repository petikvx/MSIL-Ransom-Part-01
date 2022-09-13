using System;
using System.Globalization;

internal static class ReleaseInfo
{
	public static string GetMonthYear(CultureInfo culture)
	{
		return DateTime.Parse("12/1/2015", CultureInfo.GetCultureInfo("en-US")).ToString("Y", culture);
	}
}
