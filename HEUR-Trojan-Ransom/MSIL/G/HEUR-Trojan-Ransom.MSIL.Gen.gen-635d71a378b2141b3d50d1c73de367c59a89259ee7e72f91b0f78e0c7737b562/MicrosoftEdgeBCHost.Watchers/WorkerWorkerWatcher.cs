using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WorkerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfacePublisher()
	{
	}
}
