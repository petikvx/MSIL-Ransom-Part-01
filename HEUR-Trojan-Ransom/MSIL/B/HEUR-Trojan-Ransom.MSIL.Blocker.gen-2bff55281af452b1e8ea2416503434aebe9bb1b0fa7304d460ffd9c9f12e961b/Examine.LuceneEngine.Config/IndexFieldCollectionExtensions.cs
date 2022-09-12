using System.Collections.Generic;
using System.Configuration;

namespace Examine.LuceneEngine.Config;

public static class IndexFieldCollectionExtensions
{
	public static List<IndexField> ToList(this IndexFieldCollection indexes)
	{
		List<IndexField> list = new List<IndexField>();
		foreach (IndexField item in (ConfigurationElementCollection)indexes)
		{
			list.Add(item);
		}
		return list;
	}
}
