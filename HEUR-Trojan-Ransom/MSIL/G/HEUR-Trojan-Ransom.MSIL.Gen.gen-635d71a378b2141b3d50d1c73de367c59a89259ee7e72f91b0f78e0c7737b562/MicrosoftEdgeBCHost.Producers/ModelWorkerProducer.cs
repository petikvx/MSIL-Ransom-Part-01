using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
