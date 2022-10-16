using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CollectionValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralBroadcaster()
	{
	}
}
