using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StrategyState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyState()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceParam()
	{
	}
}
