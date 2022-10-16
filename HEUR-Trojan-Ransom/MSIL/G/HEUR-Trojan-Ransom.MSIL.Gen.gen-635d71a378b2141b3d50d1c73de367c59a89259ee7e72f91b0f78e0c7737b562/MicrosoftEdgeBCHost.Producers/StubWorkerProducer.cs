using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
