using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class PublisherOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralProxy()
	{
	}
}
