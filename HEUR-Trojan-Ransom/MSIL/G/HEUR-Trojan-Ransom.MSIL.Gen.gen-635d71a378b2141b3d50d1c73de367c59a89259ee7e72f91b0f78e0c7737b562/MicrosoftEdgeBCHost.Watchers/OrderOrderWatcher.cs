using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class OrderOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralAdapter()
	{
	}
}
