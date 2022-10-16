using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralWriter()
	{
	}
}
