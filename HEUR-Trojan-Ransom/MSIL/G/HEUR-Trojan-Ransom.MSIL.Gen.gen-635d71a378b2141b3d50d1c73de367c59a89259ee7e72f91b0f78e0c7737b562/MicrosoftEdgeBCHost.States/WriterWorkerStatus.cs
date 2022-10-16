using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WriterWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralSystem()
	{
	}
}
