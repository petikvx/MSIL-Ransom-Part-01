using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
