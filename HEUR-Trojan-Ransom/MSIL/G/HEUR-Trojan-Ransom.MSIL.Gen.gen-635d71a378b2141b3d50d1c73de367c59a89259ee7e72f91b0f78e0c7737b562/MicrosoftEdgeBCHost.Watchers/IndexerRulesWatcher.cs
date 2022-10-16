using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IndexerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SelectBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectBridge()
	{
	}
}
