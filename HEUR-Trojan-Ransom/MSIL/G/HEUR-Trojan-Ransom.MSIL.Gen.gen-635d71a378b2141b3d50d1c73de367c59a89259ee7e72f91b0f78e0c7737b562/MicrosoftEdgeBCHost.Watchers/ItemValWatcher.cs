using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ItemValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceStrategy()
	{
	}
}
