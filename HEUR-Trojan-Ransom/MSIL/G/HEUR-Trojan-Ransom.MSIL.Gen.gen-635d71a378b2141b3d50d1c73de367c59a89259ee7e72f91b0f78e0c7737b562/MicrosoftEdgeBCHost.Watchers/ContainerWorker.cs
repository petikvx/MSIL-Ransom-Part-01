using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ContainerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		MapList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapList()
	{
	}
}
