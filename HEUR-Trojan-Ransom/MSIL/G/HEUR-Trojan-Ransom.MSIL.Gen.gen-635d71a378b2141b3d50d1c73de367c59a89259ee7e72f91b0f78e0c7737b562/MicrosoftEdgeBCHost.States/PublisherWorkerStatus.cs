using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PublisherWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralRepository()
	{
	}
}
