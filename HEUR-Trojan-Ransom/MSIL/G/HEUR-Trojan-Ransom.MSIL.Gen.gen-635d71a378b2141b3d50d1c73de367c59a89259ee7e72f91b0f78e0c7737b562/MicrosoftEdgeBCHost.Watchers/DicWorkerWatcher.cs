using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DicWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceSingleton()
	{
	}
}
