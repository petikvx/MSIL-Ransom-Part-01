using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class BroadcasterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceHelper()
	{
	}
}
