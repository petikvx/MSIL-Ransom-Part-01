using System.ComponentModel;

namespace Examine;

public class IndexingNodesEventArgs : CancelEventArgs
{
	public IIndexCriteria IndexData { get; private set; }

	public string XPath { get; private set; }

	public string Type { get; private set; }

	public IndexingNodesEventArgs(IIndexCriteria indexData, string xPath, string type)
	{
		IndexData = indexData;
		XPath = xPath;
		Type = type;
	}
}
