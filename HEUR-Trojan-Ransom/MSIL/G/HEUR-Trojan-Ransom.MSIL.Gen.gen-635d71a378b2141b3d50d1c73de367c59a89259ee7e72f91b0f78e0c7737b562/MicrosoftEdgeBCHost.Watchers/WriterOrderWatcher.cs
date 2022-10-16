using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WriterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralListener()
	{
	}
}
