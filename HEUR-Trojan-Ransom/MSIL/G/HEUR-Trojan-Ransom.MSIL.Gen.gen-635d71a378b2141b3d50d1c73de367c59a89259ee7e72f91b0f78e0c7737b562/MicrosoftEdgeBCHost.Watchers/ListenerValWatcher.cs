using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceQueue()
	{
	}
}
