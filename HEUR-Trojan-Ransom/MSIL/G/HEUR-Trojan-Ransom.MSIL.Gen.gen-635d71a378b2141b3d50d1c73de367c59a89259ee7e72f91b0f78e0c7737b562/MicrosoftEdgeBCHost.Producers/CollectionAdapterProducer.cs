using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CollectionAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralBroadcaster()
	{
	}
}
