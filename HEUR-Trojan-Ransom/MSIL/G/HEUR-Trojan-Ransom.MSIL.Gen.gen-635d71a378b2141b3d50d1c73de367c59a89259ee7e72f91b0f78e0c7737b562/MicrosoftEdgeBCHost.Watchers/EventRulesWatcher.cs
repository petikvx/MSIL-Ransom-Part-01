using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class EventRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostBroadcaster()
	{
	}
}
