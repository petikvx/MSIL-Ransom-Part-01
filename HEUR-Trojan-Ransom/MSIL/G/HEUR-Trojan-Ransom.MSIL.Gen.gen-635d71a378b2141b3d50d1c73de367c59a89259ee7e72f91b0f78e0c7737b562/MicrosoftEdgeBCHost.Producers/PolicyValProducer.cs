using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
