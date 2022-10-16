using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RulesWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
