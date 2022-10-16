using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DecoratorFilterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorFilterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
