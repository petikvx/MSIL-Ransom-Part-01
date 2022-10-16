using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WorkerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
