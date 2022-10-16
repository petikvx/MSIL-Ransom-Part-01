using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PropertyWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
