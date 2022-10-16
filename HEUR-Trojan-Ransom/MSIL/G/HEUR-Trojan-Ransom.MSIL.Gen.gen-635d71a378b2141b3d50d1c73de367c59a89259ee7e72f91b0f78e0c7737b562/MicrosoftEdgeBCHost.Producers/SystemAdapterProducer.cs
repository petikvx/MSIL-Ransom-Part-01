using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SystemAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
