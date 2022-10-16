using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class QueueOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralIndexer()
	{
	}
}
