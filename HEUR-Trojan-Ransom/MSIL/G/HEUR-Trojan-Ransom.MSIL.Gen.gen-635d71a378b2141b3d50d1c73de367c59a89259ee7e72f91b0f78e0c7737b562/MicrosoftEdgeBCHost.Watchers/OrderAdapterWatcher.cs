using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class OrderAdapterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderAdapterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralFilter()
	{
	}
}
