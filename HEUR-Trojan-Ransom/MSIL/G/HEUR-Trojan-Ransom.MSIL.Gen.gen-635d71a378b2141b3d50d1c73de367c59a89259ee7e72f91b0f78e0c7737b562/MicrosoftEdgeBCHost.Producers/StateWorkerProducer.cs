using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StateWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
