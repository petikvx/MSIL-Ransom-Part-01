using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StatusWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceHelper()
	{
	}
}
