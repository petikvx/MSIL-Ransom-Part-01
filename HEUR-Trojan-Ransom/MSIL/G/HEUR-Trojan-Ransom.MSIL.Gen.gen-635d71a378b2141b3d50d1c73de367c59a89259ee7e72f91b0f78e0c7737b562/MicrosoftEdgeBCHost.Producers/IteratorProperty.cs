using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IteratorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
