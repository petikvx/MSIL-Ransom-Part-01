using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
