using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PageFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
