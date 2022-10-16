using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MappingAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
