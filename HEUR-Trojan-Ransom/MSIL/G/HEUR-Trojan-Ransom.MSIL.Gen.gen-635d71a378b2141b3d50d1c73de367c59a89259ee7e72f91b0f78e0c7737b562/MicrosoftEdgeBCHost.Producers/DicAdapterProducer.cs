using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
