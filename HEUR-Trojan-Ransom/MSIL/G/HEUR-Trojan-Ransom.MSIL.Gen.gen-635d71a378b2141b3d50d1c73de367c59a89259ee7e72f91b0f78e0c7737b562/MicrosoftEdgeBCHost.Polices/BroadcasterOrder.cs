using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class BroadcasterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatPolicy()
	{
	}
}
