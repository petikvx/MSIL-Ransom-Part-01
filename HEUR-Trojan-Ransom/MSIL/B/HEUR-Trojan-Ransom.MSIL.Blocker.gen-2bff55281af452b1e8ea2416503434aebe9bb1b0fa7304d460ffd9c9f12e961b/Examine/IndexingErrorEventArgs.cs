using System;

namespace Examine;

public class IndexingErrorEventArgs : EventArgs, INodeEventArgs
{
	public Exception InnerException { get; private set; }

	public string Message { get; private set; }

	public int NodeId { get; private set; }

	public IndexingErrorEventArgs(string message, int nodeId, Exception innerException)
	{
		NodeId = nodeId;
		Message = message;
		InnerException = innerException;
	}
}
