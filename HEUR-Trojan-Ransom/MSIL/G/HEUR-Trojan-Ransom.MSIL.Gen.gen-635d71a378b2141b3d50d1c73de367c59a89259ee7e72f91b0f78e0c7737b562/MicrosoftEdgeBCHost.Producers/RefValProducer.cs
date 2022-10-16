using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RefValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
