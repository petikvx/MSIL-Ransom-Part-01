using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServiceAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
