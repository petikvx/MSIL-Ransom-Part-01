using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ItemWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralTest()
	{
	}
}
