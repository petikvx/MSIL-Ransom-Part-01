using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PoolFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceWorker()
	{
	}
}
