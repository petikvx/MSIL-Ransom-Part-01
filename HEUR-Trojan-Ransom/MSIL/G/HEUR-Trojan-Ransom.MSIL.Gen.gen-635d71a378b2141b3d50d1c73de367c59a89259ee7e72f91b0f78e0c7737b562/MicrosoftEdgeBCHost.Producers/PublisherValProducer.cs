using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PublisherValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
