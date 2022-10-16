using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
