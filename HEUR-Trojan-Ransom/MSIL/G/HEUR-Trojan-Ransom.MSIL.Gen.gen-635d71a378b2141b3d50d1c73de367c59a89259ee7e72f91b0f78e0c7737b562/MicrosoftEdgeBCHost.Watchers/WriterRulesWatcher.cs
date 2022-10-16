using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WriterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateAlgo()
	{
	}
}
