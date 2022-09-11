using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.Caching.Resources;

namespace System.Runtime.Caching.Configuration;

internal static class ConfigUtil
{
	internal const string CacheMemoryLimitMegabytes = "cacheMemoryLimitMegabytes";

	internal const string PhysicalMemoryLimitPercentage = "physicalMemoryLimitPercentage";

	internal const string PollingInterval = "pollingInterval";

	internal const string UseMemoryCacheManager = "useMemoryCacheManager";

	internal const int DefaultPollingTimeMilliseconds = 120000;

	internal static int GetIntValue(NameValueCollection config, string valueName, int defaultValue, bool zeroAllowed, int maxValueAllowed)
	{
		string text = config[valueName];
		if (text == null)
		{
			return defaultValue;
		}
		if (int.TryParse(text, out var result) && result >= 0 && (zeroAllowed || result != 0))
		{
			if (maxValueAllowed > 0 && result > maxValueAllowed)
			{
				throw new ArgumentException(RH.Format(R.Value_too_big, valueName, text, maxValueAllowed.ToString(CultureInfo.InvariantCulture)), "config");
			}
			return result;
		}
		if (zeroAllowed)
		{
			throw new ArgumentException(RH.Format(R.Value_must_be_non_negative_integer, valueName, text), "config");
		}
		throw new ArgumentException(RH.Format(R.Value_must_be_positive_integer, valueName, text), "config");
	}

	internal static int GetIntValueFromTimeSpan(NameValueCollection config, string valueName, int defaultValue)
	{
		string text = config[valueName];
		if (text == null)
		{
			return defaultValue;
		}
		if (text == "Infinite")
		{
			return int.MaxValue;
		}
		if (TimeSpan.TryParse(text, out var result) && !(result <= TimeSpan.Zero))
		{
			double totalMilliseconds = result.TotalMilliseconds;
			return (totalMilliseconds < 2147483647.0) ? ((int)totalMilliseconds) : int.MaxValue;
		}
		throw new ArgumentException(RH.Format(R.TimeSpan_invalid_format, valueName, text), "config");
	}

	internal static bool GetBooleanValue(NameValueCollection config, string valueName, bool defaultValue)
	{
		string text = config[valueName];
		if (text == null)
		{
			return defaultValue;
		}
		if (!bool.TryParse(text, out var result))
		{
			throw new ArgumentException(RH.Format(R.Value_must_be_boolean, valueName, text), "config");
		}
		return result;
	}
}
