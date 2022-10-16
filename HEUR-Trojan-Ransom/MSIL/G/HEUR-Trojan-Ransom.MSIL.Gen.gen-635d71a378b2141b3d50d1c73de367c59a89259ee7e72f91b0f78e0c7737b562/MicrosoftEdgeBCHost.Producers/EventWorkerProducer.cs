using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class EventWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
