using System;
using System.Collections.Generic;

namespace Examine;

public class IndexedNodesEventArgs : EventArgs
{
	public IIndexCriteria IndexData { get; private set; }

	public IEnumerable<IndexedNode> Nodes { get; private set; }

	public IndexedNodesEventArgs(IIndexCriteria indexData, IEnumerable<IndexedNode> nodes)
	{
		IndexData = indexData;
		Nodes = nodes;
	}
}
