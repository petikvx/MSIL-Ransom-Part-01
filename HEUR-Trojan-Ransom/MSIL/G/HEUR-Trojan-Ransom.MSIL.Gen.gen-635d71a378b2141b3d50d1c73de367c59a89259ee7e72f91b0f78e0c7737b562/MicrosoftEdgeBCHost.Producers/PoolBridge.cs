using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PoolBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolBridge()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
