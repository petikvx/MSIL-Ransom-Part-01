using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DispatcherWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
