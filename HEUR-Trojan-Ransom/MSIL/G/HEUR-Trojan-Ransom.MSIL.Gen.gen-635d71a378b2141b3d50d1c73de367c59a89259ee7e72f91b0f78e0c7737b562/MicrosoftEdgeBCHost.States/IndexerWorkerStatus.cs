using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IndexerWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralCreator()
	{
	}
}
