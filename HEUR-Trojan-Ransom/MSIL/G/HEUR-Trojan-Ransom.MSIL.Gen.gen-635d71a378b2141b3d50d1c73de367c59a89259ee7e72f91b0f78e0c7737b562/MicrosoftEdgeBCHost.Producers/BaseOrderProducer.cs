using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BaseOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
