using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServiceWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
