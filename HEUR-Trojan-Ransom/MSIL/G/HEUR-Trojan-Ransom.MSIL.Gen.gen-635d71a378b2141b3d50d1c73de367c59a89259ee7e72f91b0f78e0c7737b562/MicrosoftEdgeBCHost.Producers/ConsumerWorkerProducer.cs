using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConsumerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
