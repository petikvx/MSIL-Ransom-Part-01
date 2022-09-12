using System.Collections.Generic;

namespace HtmlAgilityPack;

internal static class Utilities
{
	public static TValue GetDictionaryValueOrDefault<TKey, TValue>(Dictionary<TKey, TValue> dict, TKey key, TValue defaultValue = default(TValue)) where TKey : class
	{
		if (!dict.TryGetValue(key, out var value))
		{
			return defaultValue;
		}
		return value;
	}
}
