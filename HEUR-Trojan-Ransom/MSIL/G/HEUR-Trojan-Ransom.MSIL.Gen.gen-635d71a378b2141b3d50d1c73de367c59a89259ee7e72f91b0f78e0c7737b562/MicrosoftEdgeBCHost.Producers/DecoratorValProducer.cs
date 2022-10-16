using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
