using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WatcherContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherContext()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceWrapper()
	{
	}
}
