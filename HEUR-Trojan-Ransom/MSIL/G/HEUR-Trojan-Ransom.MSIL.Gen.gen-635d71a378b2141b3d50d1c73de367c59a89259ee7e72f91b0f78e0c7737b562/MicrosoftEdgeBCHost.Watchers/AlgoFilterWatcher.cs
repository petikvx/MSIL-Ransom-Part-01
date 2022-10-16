using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AlgoFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CountComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountComposer()
	{
	}
}
