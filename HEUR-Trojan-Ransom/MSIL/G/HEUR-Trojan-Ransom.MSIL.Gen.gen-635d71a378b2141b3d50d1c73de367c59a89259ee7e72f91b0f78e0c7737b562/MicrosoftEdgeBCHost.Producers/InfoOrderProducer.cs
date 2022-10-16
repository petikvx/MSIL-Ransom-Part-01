using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InfoOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
