using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObserverValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
