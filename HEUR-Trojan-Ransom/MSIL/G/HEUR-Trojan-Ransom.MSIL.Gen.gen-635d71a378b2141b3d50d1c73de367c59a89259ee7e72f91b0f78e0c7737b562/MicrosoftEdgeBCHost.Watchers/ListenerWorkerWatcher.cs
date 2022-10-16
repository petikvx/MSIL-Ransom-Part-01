using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceList()
	{
	}
}
