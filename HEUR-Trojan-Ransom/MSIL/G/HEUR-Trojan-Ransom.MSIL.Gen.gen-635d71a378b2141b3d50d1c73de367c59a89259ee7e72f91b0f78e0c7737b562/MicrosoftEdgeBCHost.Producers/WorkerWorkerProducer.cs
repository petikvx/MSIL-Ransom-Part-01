using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WorkerWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
