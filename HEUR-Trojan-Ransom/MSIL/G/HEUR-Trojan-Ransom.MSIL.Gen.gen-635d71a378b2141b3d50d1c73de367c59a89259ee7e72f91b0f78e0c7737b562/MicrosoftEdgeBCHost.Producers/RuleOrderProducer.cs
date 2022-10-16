using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RuleOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
