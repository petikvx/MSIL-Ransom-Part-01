using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
