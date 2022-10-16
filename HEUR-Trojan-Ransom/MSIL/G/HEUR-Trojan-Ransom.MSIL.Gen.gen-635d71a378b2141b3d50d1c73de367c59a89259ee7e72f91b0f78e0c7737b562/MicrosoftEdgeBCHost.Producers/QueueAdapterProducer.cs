using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class QueueAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralBroadcaster()
	{
	}
}
