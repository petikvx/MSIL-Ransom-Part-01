using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MapInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInterfaceRule()
	{
	}
}
