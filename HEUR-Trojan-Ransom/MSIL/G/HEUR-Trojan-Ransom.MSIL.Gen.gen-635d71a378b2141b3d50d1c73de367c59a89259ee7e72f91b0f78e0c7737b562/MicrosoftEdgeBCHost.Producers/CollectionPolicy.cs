using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CollectionPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
