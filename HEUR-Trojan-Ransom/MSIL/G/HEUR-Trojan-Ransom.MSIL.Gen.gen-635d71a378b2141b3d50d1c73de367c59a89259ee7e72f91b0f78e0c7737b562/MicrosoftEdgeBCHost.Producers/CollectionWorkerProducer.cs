using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CollectionWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
