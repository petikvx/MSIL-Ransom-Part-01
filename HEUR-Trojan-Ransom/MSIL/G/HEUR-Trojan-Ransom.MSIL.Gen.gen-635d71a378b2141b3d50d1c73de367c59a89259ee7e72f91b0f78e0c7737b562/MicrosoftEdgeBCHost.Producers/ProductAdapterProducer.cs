using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProductAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
