using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ItemFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceServer()
	{
	}
}
