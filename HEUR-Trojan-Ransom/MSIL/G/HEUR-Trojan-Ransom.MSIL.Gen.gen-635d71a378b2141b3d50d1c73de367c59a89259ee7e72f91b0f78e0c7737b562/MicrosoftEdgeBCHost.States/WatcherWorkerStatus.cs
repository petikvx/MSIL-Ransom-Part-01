using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class WatcherWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralPool()
	{
	}
}
