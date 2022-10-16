using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValueValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceQueue()
	{
	}
}
