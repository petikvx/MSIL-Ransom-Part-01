using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WatcherWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceCode()
	{
	}
}
