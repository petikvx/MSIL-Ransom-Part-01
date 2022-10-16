using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralRule()
	{
	}
}
