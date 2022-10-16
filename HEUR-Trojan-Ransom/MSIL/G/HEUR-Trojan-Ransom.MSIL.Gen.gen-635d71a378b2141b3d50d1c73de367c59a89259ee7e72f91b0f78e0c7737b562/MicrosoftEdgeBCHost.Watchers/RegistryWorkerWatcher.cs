using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegistryWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceThread()
	{
	}
}
