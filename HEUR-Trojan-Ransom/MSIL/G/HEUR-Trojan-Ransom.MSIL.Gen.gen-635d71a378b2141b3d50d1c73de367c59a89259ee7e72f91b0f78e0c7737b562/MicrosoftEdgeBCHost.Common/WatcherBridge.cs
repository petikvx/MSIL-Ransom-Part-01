using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WatcherBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherBridge()
	{
		WriterPropertyProducer.ResolveStub();
		RunQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunQueue()
	{
	}
}
