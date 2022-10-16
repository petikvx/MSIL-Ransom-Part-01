using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ImporterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
