using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PredicateRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitConfiguration()
	{
	}
}
