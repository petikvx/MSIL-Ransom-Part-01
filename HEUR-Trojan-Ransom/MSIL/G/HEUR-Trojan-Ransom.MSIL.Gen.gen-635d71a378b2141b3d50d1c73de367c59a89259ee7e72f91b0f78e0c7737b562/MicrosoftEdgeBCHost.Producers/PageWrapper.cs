using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
