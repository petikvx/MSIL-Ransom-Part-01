using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
