using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralAlgo()
	{
	}
}
