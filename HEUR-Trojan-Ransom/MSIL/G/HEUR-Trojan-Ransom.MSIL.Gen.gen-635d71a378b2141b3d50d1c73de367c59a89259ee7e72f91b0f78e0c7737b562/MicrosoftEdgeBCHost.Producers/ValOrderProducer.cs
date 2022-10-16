using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
