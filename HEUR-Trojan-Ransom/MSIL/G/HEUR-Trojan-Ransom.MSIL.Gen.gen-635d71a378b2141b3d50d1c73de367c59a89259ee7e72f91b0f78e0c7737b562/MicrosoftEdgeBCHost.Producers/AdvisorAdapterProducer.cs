using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdvisorAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
