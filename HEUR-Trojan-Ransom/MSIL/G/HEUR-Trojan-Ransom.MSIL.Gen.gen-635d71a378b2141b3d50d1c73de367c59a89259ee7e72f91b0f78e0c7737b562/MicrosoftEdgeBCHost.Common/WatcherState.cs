using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WatcherState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherState()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceDispatcher()
	{
	}
}
