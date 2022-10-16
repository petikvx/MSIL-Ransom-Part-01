using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ItemServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemServer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
