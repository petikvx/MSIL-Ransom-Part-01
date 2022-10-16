using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class Page
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Page()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
