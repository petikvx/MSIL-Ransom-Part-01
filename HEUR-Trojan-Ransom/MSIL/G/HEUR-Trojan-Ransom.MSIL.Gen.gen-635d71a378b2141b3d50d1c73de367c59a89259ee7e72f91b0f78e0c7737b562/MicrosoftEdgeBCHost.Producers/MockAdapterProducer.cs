using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MockAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
