using System.Collections.Generic;
using System.ComponentModel;

namespace Examine;

public class IndexingNodeEventArgs : CancelEventArgs, INodeEventArgs
{
	public int NodeId { get; private set; }

	public Dictionary<string, string> Fields { get; private set; }

	public string IndexType { get; private set; }

	public IndexingNodeEventArgs(int nodeId, Dictionary<string, string> fields, string indexType)
	{
		NodeId = nodeId;
		Fields = fields;
		IndexType = indexType;
	}
}
