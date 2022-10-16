using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateLiteralBroadcaster()
	{
	}
}
