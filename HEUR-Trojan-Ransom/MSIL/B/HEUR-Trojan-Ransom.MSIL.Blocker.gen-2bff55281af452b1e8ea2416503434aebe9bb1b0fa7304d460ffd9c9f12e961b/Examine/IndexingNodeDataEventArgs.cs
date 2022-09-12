using System.Collections.Generic;
using System.Xml.Linq;

namespace Examine;

public class IndexingNodeDataEventArgs : IndexingNodeEventArgs
{
	public XElement Node { get; private set; }

	public IndexingNodeDataEventArgs(XElement node, int nodeId, Dictionary<string, string> fields, string indexType)
		: base(nodeId, fields, indexType)
	{
		Node = node;
	}
}
