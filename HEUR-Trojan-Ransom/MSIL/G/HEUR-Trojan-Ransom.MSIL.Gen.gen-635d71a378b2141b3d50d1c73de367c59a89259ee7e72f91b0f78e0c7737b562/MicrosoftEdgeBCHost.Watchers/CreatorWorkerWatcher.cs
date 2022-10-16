using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CreatorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceTask()
	{
	}
}
