using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TaskBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskBridge()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
