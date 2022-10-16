using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
