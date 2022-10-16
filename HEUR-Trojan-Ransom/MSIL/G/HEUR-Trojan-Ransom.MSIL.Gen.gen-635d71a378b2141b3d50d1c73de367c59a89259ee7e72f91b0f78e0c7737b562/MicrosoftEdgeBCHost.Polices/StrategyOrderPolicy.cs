using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralMapper()
	{
	}
}
