using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceAdvisor()
	{
	}
}
