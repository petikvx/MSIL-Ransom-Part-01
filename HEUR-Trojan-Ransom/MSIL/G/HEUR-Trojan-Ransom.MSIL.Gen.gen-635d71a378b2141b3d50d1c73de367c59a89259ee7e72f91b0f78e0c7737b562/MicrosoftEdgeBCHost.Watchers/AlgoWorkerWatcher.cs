using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AlgoWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceProducer()
	{
	}
}
