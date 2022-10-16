using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ResolverSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralBroadcaster()
	{
	}
}
