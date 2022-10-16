using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StrategyAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralSystem()
	{
	}
}
