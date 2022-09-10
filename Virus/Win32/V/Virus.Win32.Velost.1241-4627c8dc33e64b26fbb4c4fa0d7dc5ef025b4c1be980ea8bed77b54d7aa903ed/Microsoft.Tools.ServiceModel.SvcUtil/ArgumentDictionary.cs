using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Tools.ServiceModel.SvcUtil;

internal class ArgumentDictionary
{
	private Dictionary<string, IList<string>> contents;

	internal int Count => contents.Count;

	internal ArgumentDictionary(int capacity)
	{
		contents = new Dictionary<string, IList<string>>(capacity);
	}

	internal void Add(string key, string value)
	{
		IList<string> list;
		if (!ContainsArgument(key))
		{
			list = new List<string>();
			Add(key, list);
		}
		else
		{
			list = GetArguments(key);
		}
		list.Add(value);
	}

	internal string GetArgument(string key)
	{
		if (contents.TryGetValue(key.ToLower(CultureInfo.InvariantCulture), out var value))
		{
			return value[0];
		}
		return null;
	}

	internal IList<string> GetArguments(string key)
	{
		if (!contents.TryGetValue(key.ToLower(CultureInfo.InvariantCulture), out var value))
		{
			return new List<string>();
		}
		return value;
	}

	internal bool ContainsArgument(string key)
	{
		return contents.ContainsKey(key.ToLower(CultureInfo.InvariantCulture));
	}

	internal void Add(string key, IList<string> values)
	{
		contents.Add(key.ToLower(CultureInfo.InvariantCulture), values);
	}
}
