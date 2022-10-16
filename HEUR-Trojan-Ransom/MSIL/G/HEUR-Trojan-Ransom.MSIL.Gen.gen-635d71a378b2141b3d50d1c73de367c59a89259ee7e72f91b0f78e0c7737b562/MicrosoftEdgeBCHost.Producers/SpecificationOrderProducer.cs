using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SpecificationOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
