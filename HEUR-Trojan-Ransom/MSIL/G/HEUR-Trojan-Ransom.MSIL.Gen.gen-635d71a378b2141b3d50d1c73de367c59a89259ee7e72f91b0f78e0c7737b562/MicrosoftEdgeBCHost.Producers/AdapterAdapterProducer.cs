using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AdapterAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
