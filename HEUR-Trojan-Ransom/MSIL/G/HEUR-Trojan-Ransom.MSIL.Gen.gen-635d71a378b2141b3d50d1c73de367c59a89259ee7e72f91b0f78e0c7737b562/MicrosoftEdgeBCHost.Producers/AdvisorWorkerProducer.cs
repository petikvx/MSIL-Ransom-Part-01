using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdvisorWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
