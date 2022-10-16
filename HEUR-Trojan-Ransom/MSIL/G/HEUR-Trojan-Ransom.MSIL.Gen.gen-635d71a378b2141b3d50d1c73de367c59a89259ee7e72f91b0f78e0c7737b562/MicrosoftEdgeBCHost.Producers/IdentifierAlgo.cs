using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
