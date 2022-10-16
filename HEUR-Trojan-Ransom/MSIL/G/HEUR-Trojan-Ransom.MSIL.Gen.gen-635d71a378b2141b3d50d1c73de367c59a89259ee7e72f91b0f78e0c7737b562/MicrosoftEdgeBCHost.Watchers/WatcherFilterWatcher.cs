using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WatcherFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CancelRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelRepository()
	{
	}
}
