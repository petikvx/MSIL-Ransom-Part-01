using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StrategyRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FillRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillRecord()
	{
	}
}
