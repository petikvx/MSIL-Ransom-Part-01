using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceProducer()
	{
	}
}
