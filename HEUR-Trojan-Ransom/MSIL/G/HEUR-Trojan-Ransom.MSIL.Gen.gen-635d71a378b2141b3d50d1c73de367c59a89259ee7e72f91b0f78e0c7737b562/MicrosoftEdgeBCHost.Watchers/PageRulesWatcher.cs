using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptException()
	{
	}
}
