using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ImporterWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
