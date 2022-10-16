using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StrategyPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceAdvisor()
	{
	}
}
