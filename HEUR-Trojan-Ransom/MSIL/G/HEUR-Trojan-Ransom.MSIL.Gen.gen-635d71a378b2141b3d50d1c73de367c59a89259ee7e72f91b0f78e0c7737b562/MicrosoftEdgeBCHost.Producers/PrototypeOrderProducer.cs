using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PrototypeOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
