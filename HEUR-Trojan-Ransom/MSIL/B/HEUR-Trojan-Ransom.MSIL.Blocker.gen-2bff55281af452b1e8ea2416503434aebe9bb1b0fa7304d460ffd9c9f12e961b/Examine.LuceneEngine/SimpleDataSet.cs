using System.Collections.Generic;

namespace Examine.LuceneEngine;

public class SimpleDataSet
{
	public IndexedNode NodeDefinition { get; set; }

	public Dictionary<string, string> RowData { get; set; }
}
