using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProxyPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
