using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PageOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralAnnotation()
	{
	}
}
