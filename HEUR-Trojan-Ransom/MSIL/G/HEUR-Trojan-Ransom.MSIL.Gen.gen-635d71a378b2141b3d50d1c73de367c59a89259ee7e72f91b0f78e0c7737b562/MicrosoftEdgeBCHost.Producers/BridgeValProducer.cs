using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BridgeValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
