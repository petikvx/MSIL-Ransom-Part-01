using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerContext()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
