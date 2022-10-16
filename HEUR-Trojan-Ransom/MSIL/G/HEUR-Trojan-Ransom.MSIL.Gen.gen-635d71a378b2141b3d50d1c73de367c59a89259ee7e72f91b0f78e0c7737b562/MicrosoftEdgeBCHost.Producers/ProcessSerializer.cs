using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralBroadcaster()
	{
	}
}
