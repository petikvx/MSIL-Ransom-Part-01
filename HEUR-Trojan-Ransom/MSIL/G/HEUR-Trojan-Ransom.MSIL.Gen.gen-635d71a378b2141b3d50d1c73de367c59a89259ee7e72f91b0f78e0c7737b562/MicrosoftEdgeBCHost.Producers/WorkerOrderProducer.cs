using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WorkerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
