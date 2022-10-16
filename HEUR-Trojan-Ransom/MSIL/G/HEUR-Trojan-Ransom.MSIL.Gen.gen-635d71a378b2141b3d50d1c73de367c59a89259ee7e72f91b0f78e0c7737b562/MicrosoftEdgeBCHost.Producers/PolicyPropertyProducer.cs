using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class PolicyPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
