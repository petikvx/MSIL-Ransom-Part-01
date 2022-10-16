using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RuleValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
