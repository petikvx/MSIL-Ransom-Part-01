using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
