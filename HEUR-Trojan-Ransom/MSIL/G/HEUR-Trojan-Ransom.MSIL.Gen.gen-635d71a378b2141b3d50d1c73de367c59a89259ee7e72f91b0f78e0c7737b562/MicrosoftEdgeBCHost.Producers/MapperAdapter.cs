using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapperAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
