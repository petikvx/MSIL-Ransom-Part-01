using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfacePrinter()
	{
	}
}
