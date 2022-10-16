using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RateStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateStrategy()
	{
	}
}
