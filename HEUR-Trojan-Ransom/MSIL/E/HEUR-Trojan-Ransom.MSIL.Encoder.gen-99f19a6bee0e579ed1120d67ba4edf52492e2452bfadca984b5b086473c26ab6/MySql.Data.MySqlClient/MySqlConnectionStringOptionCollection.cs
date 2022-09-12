using System;
using System.Collections.Generic;

namespace MySql.Data.MySqlClient;

internal class MySqlConnectionStringOptionCollection : Dictionary<string, MySqlConnectionStringOption>
{
	internal List<MySqlConnectionStringOption> Options { get; }

	internal MySqlConnectionStringOptionCollection()
		: base((IEqualityComparer<string>?)StringComparer.OrdinalIgnoreCase)
	{
		Options = new List<MySqlConnectionStringOption>();
	}

	internal void Add(MySqlConnectionStringOption option)
	{
		Options.Add(option);
		Add(option.Keyword, option);
		if (option.Synonyms != null)
		{
			string[] synonyms = option.Synonyms;
			foreach (string key in synonyms)
			{
				Add(key, option);
			}
		}
	}

	internal MySqlConnectionStringOption Get(string keyword)
	{
		MySqlConnectionStringOption value = null;
		TryGetValue(keyword, out value);
		return value;
	}
}
