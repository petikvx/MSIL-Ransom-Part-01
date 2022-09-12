using System;

namespace Examine;

public class IndexedNodeEventArgs : EventArgs
{
	public int NodeId { get; private set; }

	public IndexedNodeEventArgs(int nodeId)
	{
		NodeId = nodeId;
	}
}
