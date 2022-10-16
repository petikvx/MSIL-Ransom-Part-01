using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralConnection()
	{
	}
}
