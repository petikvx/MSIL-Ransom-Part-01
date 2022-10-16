using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceInstance()
	{
	}
}
