using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StubOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
