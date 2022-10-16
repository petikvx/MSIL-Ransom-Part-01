using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
