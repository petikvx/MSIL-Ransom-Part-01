using System.Collections.Generic;
using System.Linq;

namespace Examine.Providers;

internal class CombinedIndexerDataFields : Dictionary<string, IReadOnlyList<IIndexField>>
{
	public CombinedIndexerDataFields(IEnumerable<IIndexField> allFields)
	{
		foreach (IGrouping<string, IIndexField> item in from x in allFields
			group x by x.Name)
		{
			Add(item.Key, item.ToList());
		}
	}
}
