using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class EventWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralPool()
	{
	}
}
