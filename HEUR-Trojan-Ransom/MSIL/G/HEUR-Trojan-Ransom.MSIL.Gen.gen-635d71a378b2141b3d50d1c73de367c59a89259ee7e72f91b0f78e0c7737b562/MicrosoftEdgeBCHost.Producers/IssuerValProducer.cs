using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IssuerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
