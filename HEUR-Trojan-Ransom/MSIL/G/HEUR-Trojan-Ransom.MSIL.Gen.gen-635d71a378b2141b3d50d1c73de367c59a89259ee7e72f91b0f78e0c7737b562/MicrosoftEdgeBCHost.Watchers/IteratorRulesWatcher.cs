using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IteratorRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitAdapter()
	{
	}
}
