using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IndexerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceFilter()
	{
	}
}
