using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
