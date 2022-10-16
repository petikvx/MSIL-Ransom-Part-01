using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceRule()
	{
	}
}
