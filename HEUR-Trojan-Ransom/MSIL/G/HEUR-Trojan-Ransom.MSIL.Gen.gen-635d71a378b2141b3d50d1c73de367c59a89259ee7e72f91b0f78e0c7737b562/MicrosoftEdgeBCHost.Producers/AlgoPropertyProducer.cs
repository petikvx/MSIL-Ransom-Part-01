using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AlgoPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
