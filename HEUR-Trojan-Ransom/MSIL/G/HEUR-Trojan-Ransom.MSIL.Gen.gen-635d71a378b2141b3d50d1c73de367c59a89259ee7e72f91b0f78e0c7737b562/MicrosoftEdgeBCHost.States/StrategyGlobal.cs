using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceStrategy()
	{
	}
}
