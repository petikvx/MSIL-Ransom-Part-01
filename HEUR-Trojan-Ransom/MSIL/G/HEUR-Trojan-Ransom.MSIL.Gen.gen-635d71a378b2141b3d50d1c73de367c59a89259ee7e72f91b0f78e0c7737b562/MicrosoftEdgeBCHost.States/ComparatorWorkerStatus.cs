using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComparatorWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
