using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
