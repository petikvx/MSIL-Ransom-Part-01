using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CustomerValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
