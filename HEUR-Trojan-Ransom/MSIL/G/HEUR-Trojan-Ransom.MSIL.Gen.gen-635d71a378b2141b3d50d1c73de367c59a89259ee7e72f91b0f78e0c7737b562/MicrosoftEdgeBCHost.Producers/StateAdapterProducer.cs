using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StateAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
