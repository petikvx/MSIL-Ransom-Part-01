using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class EventValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static EventValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceIndexer()
	{
	}
}
