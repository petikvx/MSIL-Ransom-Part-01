using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategySerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategySerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralBroadcaster()
	{
	}
}
