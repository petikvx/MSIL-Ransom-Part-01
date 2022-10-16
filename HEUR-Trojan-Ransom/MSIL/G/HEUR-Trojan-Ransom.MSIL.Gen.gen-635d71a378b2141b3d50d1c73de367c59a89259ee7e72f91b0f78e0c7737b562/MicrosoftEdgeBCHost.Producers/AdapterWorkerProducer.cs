using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdapterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
