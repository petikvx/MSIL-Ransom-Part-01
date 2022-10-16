using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfacePublisher()
	{
	}
}
