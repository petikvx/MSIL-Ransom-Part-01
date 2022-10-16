using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
