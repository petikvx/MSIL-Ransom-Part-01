using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class BaseValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
