using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WatcherWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceClass()
	{
	}
}
