using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
