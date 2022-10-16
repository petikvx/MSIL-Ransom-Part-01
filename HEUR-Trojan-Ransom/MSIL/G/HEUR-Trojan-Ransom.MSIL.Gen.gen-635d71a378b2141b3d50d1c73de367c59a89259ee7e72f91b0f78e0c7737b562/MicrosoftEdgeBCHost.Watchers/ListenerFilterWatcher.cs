using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ListenerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		QueryContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryContainer()
	{
	}
}
