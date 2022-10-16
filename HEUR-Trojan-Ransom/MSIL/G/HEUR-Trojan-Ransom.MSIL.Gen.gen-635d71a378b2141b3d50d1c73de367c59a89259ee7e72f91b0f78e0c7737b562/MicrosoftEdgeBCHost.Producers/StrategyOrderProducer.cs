using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StrategyOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
