using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DispatcherWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
