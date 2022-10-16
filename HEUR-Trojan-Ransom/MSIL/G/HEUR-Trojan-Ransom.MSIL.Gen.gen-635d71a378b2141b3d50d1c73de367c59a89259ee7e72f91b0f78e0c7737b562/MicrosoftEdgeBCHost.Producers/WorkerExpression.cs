using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WorkerExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerExpression()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
