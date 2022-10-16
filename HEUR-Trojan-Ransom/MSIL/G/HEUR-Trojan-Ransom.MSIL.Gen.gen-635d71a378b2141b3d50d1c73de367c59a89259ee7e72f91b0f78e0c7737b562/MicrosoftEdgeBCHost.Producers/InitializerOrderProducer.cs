using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InitializerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
