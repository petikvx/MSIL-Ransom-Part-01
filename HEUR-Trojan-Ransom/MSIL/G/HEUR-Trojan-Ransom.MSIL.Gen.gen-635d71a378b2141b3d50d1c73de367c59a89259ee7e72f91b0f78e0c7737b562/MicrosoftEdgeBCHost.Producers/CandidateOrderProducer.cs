using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CandidateOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
