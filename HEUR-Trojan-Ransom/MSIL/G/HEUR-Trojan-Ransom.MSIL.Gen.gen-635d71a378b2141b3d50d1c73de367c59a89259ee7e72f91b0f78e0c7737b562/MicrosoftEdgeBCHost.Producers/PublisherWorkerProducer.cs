using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PublisherWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
