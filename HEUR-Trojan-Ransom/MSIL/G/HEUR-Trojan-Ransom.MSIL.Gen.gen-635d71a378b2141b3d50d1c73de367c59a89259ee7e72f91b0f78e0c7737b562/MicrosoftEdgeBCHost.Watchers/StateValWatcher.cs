using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class StateValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceEvent()
	{
	}
}
