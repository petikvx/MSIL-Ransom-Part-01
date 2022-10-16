using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AlgoWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
