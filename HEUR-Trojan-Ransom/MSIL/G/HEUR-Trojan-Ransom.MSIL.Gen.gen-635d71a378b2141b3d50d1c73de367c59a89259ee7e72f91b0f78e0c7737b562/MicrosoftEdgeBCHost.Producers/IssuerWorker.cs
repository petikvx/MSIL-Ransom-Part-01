using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IssuerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
