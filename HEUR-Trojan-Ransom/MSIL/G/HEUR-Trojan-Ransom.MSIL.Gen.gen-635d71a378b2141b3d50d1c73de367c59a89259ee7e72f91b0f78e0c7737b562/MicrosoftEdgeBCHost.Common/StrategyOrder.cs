using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StrategyOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyOrder()
	{
		WriterPropertyProducer.ResolveStub();
		OrderBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderBase()
	{
	}
}
