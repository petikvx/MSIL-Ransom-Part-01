using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BroadcasterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListDispatcher()
	{
	}
}
