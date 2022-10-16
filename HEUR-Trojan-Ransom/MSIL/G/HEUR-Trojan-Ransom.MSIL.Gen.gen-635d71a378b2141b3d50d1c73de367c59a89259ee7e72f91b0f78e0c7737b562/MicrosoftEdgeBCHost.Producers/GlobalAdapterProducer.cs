using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
