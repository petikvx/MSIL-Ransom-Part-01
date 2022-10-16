using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PublisherFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherFacade()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralItem()
	{
	}
}
