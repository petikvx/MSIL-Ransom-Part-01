using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ObjectOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
