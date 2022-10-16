using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PredicateAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
