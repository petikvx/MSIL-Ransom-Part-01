using System;
using System.ComponentModel;

namespace Examine;

public class BuildingEmptyIndexOnStartupEventArgs : CancelEventArgs
{
	public IIndexer Indexer { get; private set; }

	public bool IsHealthy { get; private set; }

	public Exception UnhealthyException { get; private set; }

	public BuildingEmptyIndexOnStartupEventArgs(IIndexer indexer)
	{
		Indexer = indexer;
		IsHealthy = true;
	}

	public BuildingEmptyIndexOnStartupEventArgs(IIndexer indexer, bool isHealthy, Exception unhealthyException)
	{
		Indexer = indexer;
		IsHealthy = isHealthy;
		UnhealthyException = unhealthyException;
	}
}
