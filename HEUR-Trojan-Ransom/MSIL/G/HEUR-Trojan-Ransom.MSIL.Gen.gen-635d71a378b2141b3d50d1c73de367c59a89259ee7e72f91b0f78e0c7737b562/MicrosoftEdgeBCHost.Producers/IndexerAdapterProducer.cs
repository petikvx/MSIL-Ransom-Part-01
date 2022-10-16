using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IndexerAdapterProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerAdapterProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralPrototype()
	{
	}
}
