using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BroadcasterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfacePrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfacePrototype()
	{
	}
}
