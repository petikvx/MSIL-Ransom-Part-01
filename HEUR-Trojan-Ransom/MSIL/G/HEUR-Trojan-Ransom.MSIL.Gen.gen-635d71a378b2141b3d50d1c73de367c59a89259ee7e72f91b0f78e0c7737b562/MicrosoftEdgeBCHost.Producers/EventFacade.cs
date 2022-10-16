using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class EventFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventFacade()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
