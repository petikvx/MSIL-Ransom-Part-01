using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RequestWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceThread()
	{
	}
}
