using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InitializerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
