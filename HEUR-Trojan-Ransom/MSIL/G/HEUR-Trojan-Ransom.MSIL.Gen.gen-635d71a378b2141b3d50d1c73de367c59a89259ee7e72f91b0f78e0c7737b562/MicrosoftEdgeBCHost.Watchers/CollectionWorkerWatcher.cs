using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CollectionWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
