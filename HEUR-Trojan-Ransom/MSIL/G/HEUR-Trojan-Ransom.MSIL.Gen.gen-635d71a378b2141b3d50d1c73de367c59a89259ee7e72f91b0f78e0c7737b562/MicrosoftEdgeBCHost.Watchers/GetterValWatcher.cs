using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class GetterValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceStrategy()
	{
	}
}
