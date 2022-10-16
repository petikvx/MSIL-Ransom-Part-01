using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IndexerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralParameter()
	{
	}
}
