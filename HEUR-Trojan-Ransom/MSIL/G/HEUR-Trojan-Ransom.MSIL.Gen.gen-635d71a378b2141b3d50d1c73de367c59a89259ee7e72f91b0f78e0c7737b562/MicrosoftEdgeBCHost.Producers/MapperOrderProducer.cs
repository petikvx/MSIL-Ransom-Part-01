using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapperOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
