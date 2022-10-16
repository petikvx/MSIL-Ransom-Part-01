using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ManagerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
