using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralInstance()
	{
	}
}
