using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RefWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceQueue()
	{
	}
}
