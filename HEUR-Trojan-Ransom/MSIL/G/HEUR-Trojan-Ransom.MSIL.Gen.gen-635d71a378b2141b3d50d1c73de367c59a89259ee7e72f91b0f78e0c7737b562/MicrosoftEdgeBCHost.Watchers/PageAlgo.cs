using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralProxy()
	{
	}
}
