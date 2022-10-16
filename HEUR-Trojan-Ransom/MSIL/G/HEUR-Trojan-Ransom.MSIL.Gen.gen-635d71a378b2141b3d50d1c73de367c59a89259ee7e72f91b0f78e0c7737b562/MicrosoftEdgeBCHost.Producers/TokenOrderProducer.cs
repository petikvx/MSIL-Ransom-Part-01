using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
