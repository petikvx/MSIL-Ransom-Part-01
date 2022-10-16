using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WatcherValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfaceIndexer()
	{
	}
}
