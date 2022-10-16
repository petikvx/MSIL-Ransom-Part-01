using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IndexerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralQueue()
	{
	}
}
