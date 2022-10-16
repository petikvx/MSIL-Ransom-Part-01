using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInfo()
	{
	}
}
