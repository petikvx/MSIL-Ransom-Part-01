using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TaskWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceObserver()
	{
	}
}
