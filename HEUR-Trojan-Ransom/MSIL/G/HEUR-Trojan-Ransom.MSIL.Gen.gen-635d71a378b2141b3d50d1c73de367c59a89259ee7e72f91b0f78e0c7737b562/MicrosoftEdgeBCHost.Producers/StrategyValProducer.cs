using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StrategyValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdatePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdatePredicate()
	{
	}
}
