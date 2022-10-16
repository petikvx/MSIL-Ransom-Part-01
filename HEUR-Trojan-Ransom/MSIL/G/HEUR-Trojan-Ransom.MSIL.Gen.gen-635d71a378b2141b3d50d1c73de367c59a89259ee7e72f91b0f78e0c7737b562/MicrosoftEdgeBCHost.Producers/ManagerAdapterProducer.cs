using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
