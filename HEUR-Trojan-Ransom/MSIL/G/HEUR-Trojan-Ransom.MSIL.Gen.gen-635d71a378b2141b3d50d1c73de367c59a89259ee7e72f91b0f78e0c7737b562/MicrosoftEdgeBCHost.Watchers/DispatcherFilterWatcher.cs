using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DispatcherFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortRequest()
	{
	}
}
