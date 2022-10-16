using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceMapper()
	{
	}
}
