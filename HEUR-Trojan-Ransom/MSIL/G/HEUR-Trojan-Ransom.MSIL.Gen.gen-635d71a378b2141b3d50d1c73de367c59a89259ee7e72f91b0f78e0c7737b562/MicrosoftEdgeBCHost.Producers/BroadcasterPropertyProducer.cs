using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BroadcasterPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
