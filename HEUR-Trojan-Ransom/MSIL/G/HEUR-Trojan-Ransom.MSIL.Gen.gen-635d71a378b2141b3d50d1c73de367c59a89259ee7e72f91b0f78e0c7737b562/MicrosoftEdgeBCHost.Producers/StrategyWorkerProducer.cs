using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StrategyWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
