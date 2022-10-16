using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StrategyUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyUtils()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceTests();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceTests()
	{
	}
}
