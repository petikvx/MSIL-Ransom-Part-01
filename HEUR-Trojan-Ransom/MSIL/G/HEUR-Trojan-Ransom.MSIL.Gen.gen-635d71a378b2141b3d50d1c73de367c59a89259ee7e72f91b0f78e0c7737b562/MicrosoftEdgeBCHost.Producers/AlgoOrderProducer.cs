using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AlgoOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
