using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BroadcasterRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeMapping()
	{
	}
}
