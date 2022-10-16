using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MockValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
