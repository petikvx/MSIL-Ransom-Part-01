using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CreatorPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
