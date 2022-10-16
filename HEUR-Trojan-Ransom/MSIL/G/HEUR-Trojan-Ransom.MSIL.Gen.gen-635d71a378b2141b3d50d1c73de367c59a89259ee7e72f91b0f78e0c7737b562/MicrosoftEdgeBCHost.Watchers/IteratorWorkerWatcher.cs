using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IteratorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralWorker()
	{
	}
}
