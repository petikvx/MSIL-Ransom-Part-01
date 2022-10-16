using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MapperFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceWorker()
	{
	}
}
