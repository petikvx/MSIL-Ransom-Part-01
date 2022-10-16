using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ThreadAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
