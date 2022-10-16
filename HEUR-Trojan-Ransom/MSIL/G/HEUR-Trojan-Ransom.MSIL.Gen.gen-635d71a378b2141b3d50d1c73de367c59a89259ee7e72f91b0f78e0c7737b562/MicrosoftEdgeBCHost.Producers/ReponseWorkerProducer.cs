using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ReponseWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
