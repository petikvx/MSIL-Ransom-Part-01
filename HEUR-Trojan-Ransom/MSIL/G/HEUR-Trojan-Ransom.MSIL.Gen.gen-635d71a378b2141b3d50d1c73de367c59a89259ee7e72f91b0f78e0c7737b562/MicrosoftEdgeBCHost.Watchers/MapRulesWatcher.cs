using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectGetter()
	{
	}
}
