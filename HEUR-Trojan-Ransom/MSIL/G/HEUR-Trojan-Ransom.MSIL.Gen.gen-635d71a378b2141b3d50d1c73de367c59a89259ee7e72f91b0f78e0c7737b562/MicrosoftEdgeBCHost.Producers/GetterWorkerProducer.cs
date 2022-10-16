using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GetterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
