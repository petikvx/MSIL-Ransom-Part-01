using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StrategyValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StrategyValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceComposer()
	{
	}
}
