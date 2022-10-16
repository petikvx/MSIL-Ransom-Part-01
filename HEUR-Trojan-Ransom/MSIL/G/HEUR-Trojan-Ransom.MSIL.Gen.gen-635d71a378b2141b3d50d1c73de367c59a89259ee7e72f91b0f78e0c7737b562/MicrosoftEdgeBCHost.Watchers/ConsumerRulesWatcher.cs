using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConsumerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateBroadcaster()
	{
	}
}
