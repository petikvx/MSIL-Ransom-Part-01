using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WatcherWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherWorker()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteSystem()
	{
	}
}
