using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GetterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
