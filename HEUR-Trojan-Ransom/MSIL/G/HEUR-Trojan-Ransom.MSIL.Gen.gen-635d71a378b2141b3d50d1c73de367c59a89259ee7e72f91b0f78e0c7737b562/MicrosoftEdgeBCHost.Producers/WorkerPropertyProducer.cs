using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WorkerPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
