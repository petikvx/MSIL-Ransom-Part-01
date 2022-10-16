using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProductWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceReader()
	{
	}
}
