using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RuleWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
